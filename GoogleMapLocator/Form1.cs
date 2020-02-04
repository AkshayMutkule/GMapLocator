using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//GMap namspaces
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
//-----------------------------------------------------------------------------

namespace GoogleMapLocator
{
    public partial class Form1 : Form
    {
        double m_longitude = 73.8567;
        double m_latitude = 18.5204;
        string m_filepath = "";
        int m_time = 0;

        bool m_enableRoute = false;

        PointLatLng m_currentPoint = new PointLatLng();
        List<PointLatLng> m_routePoints = new List<PointLatLng>();

        GMapOverlay m_markers = new GMapOverlay("markers");
        GMapOverlay m_routes = new GMapOverlay("routes");

        List<double> m_locations = new List<double>();
        List<PointLatLng> m_trackPoints = new List<PointLatLng>();

        //-----------------------------------------------------------------------------

        public Form1()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------------

        private void loadLocation(ref double latitude, ref double longitude)
        {
            removeMarkers();
            goolgeMap.Position = new GMap.NET.PointLatLng(latitude, longitude); // by default load pune
            addMarker(ref latitude, ref longitude);
        }

        //-----------------------------------------------------------------------------

        private void addRoute(ref PointLatLng startPoint, ref PointLatLng destination)
        {
            RoutingProvider routeProvider = GMapProviders.OpenStreetMap;
            MapRoute route = routeProvider.GetRoute(startPoint, destination, false, false, 8);
            if (route != null)
            {
                // add route
                GMapRoute mapRoute = new GMapRoute(route.Points, route.Name);
                mapRoute.IsHitTestVisible = true;
                mapRoute.Stroke = new Pen(Color.Red, 3);

                removeRoutes();
                m_routes.Routes.Add(mapRoute);
                
                //Calculate Distance
                DistanceVal.Text = Math.Round(mapRoute.Distance, 2) + "Kms";

                // add route start/end marks
                GMapMarker startPos = new GMarkerGoogle(startPoint, GMarkerGoogleType.green_big_go);
                startPos.ToolTipText = "Start point ";
                startPos.ToolTipMode = MarkerTooltipMode.Always;

                GMapMarker destPos = new GMarkerGoogle(destination, GMarkerGoogleType.red_big_stop);
                destPos.ToolTipText = "Destination";
                destPos.ToolTipMode = MarkerTooltipMode.Always;

                removeMarkers();
                m_markers.Markers.Add(startPos);
                m_markers.Markers.Add(destPos);

                goolgeMap.Overlays.Add(m_markers);
                goolgeMap.Overlays.Add(m_routes);

                goolgeMap.Zoom = 15;
                goolgeMap.Position = startPoint;

                goolgeMap.Refresh();
            }
        }

        //-----------------------------------------------------------------------------

        private void removeMarkers()
        {
            if (goolgeMap.Overlays.Count > 0)
            {
                int numMarkers = m_markers.Markers.Count;
                for (int iNum = 0; iNum < numMarkers; ++iNum)
                {
                    m_markers.Markers.Remove(m_markers.Markers[0]);
                }

                goolgeMap.Overlays.Remove(m_markers);
                goolgeMap.Refresh();
            }

        }

        //-----------------------------------------------------------------------------

        private void removeRoutes()
        {
            if (goolgeMap.Overlays.Count > 0)
            {
                int numRoutes = m_routes.Routes.Count;
                for (int iNum = 0; iNum < numRoutes; ++iNum)
                {
                    m_routes.Routes.Remove(m_routes.Routes[0]);
                }

                goolgeMap.Overlays.Remove(m_routes);
                goolgeMap.Refresh();
            }
        }

        //-----------------------------------------------------------------------------

        private void readTrackedLocations(string filpath, ref List<double> locations)
        {
            double latitude = 0.0, longitude = 0.0;
            string line;

            System.IO.StreamReader reader = new System.IO.StreamReader(filpath);
            reader.ReadLine();

            while (reader.Peek() >= 0)
            {
                line = reader.ReadLine().ToString();
                string[] values = line.Split(',');

                for (int iNum = 0; iNum < 2; ++iNum)
                {
                    line = values[iNum];
                    latitude = Convert.ToDouble(line.Trim());
                    iNum++;

                    line = values[iNum];
                    longitude = Convert.ToDouble(line.Trim());

                    locations.Add(latitude);
                    locations.Add(longitude);
                }
            }
        }

        //-----------------------------------------------------------------------------

         private void loadStartDestinationPoints()
        {
            PointLatLng startPoint = m_trackPoints[0];
            PointLatLng DestPoint = m_trackPoints[m_trackPoints.Count() - 1];

            // add route start/end marks
            GMapMarker startPos = new GMarkerGoogle(startPoint, GMarkerGoogleType.green_big_go);
            startPos.ToolTipText = "Start Point";
            startPos.ToolTipMode = MarkerTooltipMode.Always;

            GMapMarker destPos = new GMarkerGoogle(DestPoint, GMarkerGoogleType.red_big_stop);
            destPos.ToolTipText = "Destination";
            destPos.ToolTipMode = MarkerTooltipMode.Always;

            removeMarkers();
            m_markers.Markers.Add(startPos);
            m_markers.Markers.Add(destPos);

            goolgeMap.Overlays.Add(m_markers);
            goolgeMap.Position = startPoint;
            goolgeMap.Zoom = 15;
            goolgeMap.Refresh();
        }

         //-----------------------------------------------------------------------------

        private void loadNevigationPath()
         {
             GMapRoute route = new GMapRoute(m_trackPoints, "Route Travelled");
             route.Stroke = new Pen(Color.Red, 3);

             //Calculate Distance
             double val = route.Distance;
             DistTravelled.Text = Math.Round(route.Distance, 2) + "Kms";

             removeRoutes();
             m_routes.Routes.Add(route);
             goolgeMap.Overlays.Add(m_routes);

             goolgeMap.Zoom = 15;
             goolgeMap.Refresh();
         }

         //-----------------------------------------------------------------------------

        private void startTracingTrack()
        {
            GMapMarker nevigator = new GMarkerGoogle(m_trackPoints[0], GMarkerGoogleType.blue_dot);
            nevigator.ToolTipText = "Nevigator";
            nevigator.ToolTipMode = MarkerTooltipMode.Always;
            m_markers.Markers.Add(nevigator);
            goolgeMap.Overlays.Add(m_markers);
            goolgeMap.Zoom = 18;
            goolgeMap.Refresh();

            //Track the route
            for (int i = 0; i < m_trackPoints.Count; ++i)
            {
                goolgeMap.Position = m_trackPoints[i];
                nevigator.Position = m_trackPoints[i];

                //add tooltip to location
                //string lat = "0.0000000", lang = "0.0000000";
                //lat = map.Position.Lat.ToString();
                //lang = map.Position.Lng.ToString();
                //MarkerTooltipMode mode = MarkerTooltipMode.Always;
                //m_stMarker.ToolTip = new GMapBaloonToolTip(m_stMarker);
                //m_stMarker.ToolTipMode = mode;
                //Brush ToolTipBackColor = new SolidBrush(Color.Transparent);
                //m_stMarker.ToolTip.Fill = ToolTipBackColor;
                //m_stMarker.ToolTipText = lat + ", " + lang;
                ////map.Zoom = 10;//current zoom factor

                //add timer
                for (int k = m_time; k >= 0; --k)
                {
                    for (int j = 100000; j >= 0; --j)
                    {
                        //do nothing
                    }
                }

                goolgeMap.Refresh();
            }
        }

        //-----------------------------------------------------------------------------

        private void addMarker(ref double latitude, ref double longitude)
        {
            GMapMarker locationMark = new GMarkerGoogle(new PointLatLng(latitude, longitude), GMarkerGoogleType.red_dot);
            m_markers.Markers.Add(locationMark);
            goolgeMap.Overlays.Add(m_markers);
        }

        //-----------------------------------------------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            goolgeMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            goolgeMap.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            goolgeMap.CacheLocation = @"cache";
            goolgeMap.DragButton = MouseButtons.Left;
            goolgeMap.ShowCenter = false;

            //load default location 
            loadLocation(ref m_latitude, ref m_longitude);
        }

        //-----------------------------------------------------------------------------

        private void LatitudeEditBox_TextChanged(object sender, EventArgs e)
        {
            m_latitude = Convert.ToDouble(LatitudeEditBox.Text.Trim());
        }
        //-----------------------------------------------------------------------------

        private void longitudeEdidBox_TextChanged(object sender, EventArgs e)
        {
            m_longitude = Convert.ToDouble(longitudeEdidBox.Text.Trim());
        }

        //-----------------------------------------------------------------------------

        private void Search_Click(object sender, EventArgs e)
        {
            if (!m_latitude.Equals(0.0) && !m_longitude.Equals(0.0))
            {
                loadLocation(ref m_latitude, ref m_longitude);
            }
            else
            {
                MessageBox.Show("Lattitude and Longitude should be greater than 0 !", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-----------------------------------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = ImportDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                m_filepath = ImportDialog.FileName;

                if (m_filepath.Contains(".txt"))
                {
                    m_locations.Clear();
                    readTrackedLocations(m_filepath, ref m_locations);

                    m_trackPoints.Clear();
                    for (int iNum = 0; iNum < m_locations.Count; ++iNum)
                    {
                        m_trackPoints.Add(new PointLatLng(m_locations[iNum], m_locations[iNum + 1]));
                        iNum++;
                    }

                    MessageBox.Show("Tracking locations read sucessfully!", "Successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid File Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        //-----------------------------------------------------------------------------

        private void button2_Click(object sender, EventArgs e)
        {
            if (m_routePoints.Count <= 0)
            {
                MessageBox.Show("Please give destination points!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PointLatLng startPoint = m_routePoints[0];
            PointLatLng DestPoint = m_routePoints[1];

            //add route
            addRoute(ref startPoint, ref DestPoint);
        }

        //-----------------------------------------------------------------------------

        private void button3_Click(object sender, EventArgs e)
        {
            if (m_trackPoints.Count <= 0)
            {
                MessageBox.Show("Please load track file first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            loadNevigationPath();
            loadStartDestinationPoints();
        }

        //-----------------------------------------------------------------------------

        private void button4_Click(object sender, EventArgs e)
        {
            removeMarkers();
            removeRoutes();

            LatitudeVal.Text = "";
            LongitudeVal.Text = "";
            LatitudeEditBox.Text = "";
            longitudeEdidBox.Text = "";
            DistanceVal.Text = "0 Kms";
            DistTravelled.Text = "Distance";
            m_routePoints.Clear();

        }

        //-----------------------------------------------------------------------------

        private void button5_Click(object sender, EventArgs e)
        {
            if (m_trackPoints.Count <= 0)
            {
                MessageBox.Show("Please load track file first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            loadStartDestinationPoints();
            loadNevigationPath();
            startTracingTrack();
        }

        //-----------------------------------------------------------------------------

        private void SpeedControl_Scroll(object sender, EventArgs e)
        {
            m_time = 0;
            int speed = SpeedControl.Maximum - SpeedControl.Value;
            m_time = 100*speed;
        }

        //-----------------------------------------------------------------------------

        private void button6_Click(object sender, EventArgs e)
        {
            if (m_routePoints.Count == 2)
            {
                m_routePoints.Clear();
                removeMarkers();
                removeRoutes();
            }
               
            m_routePoints.Add(new PointLatLng(m_currentPoint.Lat, m_currentPoint.Lng));
            double lat = m_currentPoint.Lat;
            double lng = m_currentPoint.Lng;
            addMarker(ref lat, ref lng);
            LatitudeVal.Text = "";
            LongitudeVal.Text = "";
        }

        //-----------------------------------------------------------------------------

        private void EnableRoutesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            removeMarkers();
            removeRoutes();

            if (!m_enableRoute)
                m_enableRoute = true;
            else
                m_enableRoute = false;
        }

        //-----------------------------------------------------------------------------

        private void goolgeMap_MouseClick(object sender, MouseEventArgs e)
        {
            if(m_enableRoute && e.Button == MouseButtons.Right)
            {
                m_currentPoint = goolgeMap.FromLocalToLatLng(e.X,e.Y);
                LatitudeVal.Text = m_currentPoint.Lat + "";
                LongitudeVal.Text = m_currentPoint.Lng + "";
            }
        }

        //-----------------------------------------------------------------------------


    }
}


//-----------------------------------------------------------------------------