namespace GoogleMapLocator
{
    using System.Windows.Forms;
    using GMap.NET.WindowsForms;
    using System.Drawing;
    using System;
    using System.Globalization;

    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.goolgeMap = new GMap.NET.WindowsForms.GMapControl();
            this.LatitudeLable = new System.Windows.Forms.Label();
            this.LatitudeEditBox = new System.Windows.Forms.TextBox();
            this.longitudeEdidBox = new System.Windows.Forms.TextBox();
            this.longitudeLable = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ImportDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DistTravelled = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SpeedControl = new System.Windows.Forms.TrackBar();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RouteGrpBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DistanceVal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.LongitudeVal = new System.Windows.Forms.TextBox();
            this.LatitudeVal = new System.Windows.Forms.TextBox();
            this.EnableRoutesCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedControl)).BeginInit();
            this.RouteGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // goolgeMap
            // 
            this.goolgeMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goolgeMap.Bearing = 0F;
            this.goolgeMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goolgeMap.CanDragMap = true;
            this.goolgeMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.goolgeMap.GrayScaleMode = false;
            this.goolgeMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.goolgeMap.LevelsKeepInMemmory = 5;
            this.goolgeMap.Location = new System.Drawing.Point(12, 12);
            this.goolgeMap.MarkersEnabled = true;
            this.goolgeMap.MaxZoom = 100;
            this.goolgeMap.MinZoom = 2;
            this.goolgeMap.MouseWheelZoomEnabled = true;
            this.goolgeMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.goolgeMap.Name = "goolgeMap";
            this.goolgeMap.NegativeMode = false;
            this.goolgeMap.PolygonsEnabled = true;
            this.goolgeMap.RetryLoadTile = 0;
            this.goolgeMap.RoutesEnabled = true;
            this.goolgeMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.goolgeMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.goolgeMap.ShowTileGridLines = false;
            this.goolgeMap.Size = new System.Drawing.Size(565, 513);
            this.goolgeMap.TabIndex = 0;
            this.goolgeMap.Zoom = 15D;
            this.goolgeMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goolgeMap_MouseClick);
            // 
            // LatitudeLable
            // 
            this.LatitudeLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LatitudeLable.AutoSize = true;
            this.LatitudeLable.Location = new System.Drawing.Point(7, 19);
            this.LatitudeLable.Name = "LatitudeLable";
            this.LatitudeLable.Size = new System.Drawing.Size(45, 13);
            this.LatitudeLable.TabIndex = 1;
            this.LatitudeLable.Text = "Latitude";
            // 
            // LatitudeEditBox
            // 
            this.LatitudeEditBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LatitudeEditBox.Location = new System.Drawing.Point(71, 19);
            this.LatitudeEditBox.Name = "LatitudeEditBox";
            this.LatitudeEditBox.Size = new System.Drawing.Size(101, 20);
            this.LatitudeEditBox.TabIndex = 2;
            this.LatitudeEditBox.TextChanged += new System.EventHandler(this.LatitudeEditBox_TextChanged);
            // 
            // longitudeEdidBox
            // 
            this.longitudeEdidBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.longitudeEdidBox.Location = new System.Drawing.Point(71, 47);
            this.longitudeEdidBox.Name = "longitudeEdidBox";
            this.longitudeEdidBox.Size = new System.Drawing.Size(101, 20);
            this.longitudeEdidBox.TabIndex = 3;
            this.longitudeEdidBox.TextChanged += new System.EventHandler(this.longitudeEdidBox_TextChanged);
            // 
            // longitudeLable
            // 
            this.longitudeLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.longitudeLable.AutoSize = true;
            this.longitudeLable.Location = new System.Drawing.Point(7, 47);
            this.longitudeLable.Name = "longitudeLable";
            this.longitudeLable.Size = new System.Drawing.Size(54, 13);
            this.longitudeLable.TabIndex = 4;
            this.longitudeLable.Text = "Longitude";
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Location = new System.Drawing.Point(102, 75);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(70, 24);
            this.Search.TabIndex = 5;
            this.Search.Text = "Locate";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // ImportDialog
            // 
            this.ImportDialog.FileName = "ImportTrack";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(97, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Load File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(97, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Get Route";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(97, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Get Path";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(697, 495);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Clear Map";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.longitudeLable);
            this.groupBox1.Controls.Add(this.longitudeEdidBox);
            this.groupBox1.Controls.Add(this.LatitudeEditBox);
            this.groupBox1.Controls.Add(this.LatitudeLable);
            this.groupBox1.Location = new System.Drawing.Point(589, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 109);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Location";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DistTravelled);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.SpeedControl);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(589, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 156);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tracking";
            // 
            // DistTravelled
            // 
            this.DistTravelled.AutoSize = true;
            this.DistTravelled.Location = new System.Drawing.Point(9, 128);
            this.DistTravelled.Name = "DistTravelled";
            this.DistTravelled.Size = new System.Drawing.Size(49, 13);
            this.DistTravelled.TabIndex = 15;
            this.DistTravelled.Text = "Distance";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Speed";
            // 
            // SpeedControl
            // 
            this.SpeedControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedControl.LargeChange = 2;
            this.SpeedControl.Location = new System.Drawing.Point(61, 78);
            this.SpeedControl.Maximum = 5;
            this.SpeedControl.Name = "SpeedControl";
            this.SpeedControl.Size = new System.Drawing.Size(111, 45);
            this.SpeedControl.TabIndex = 13;
            this.SpeedControl.Value = 3;
            this.SpeedControl.Scroll += new System.EventHandler(this.SpeedControl_Scroll);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(97, 122);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Nevigate";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Travelled route";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Load track file";
            // 
            // RouteGrpBox
            // 
            this.RouteGrpBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RouteGrpBox.Controls.Add(this.label7);
            this.RouteGrpBox.Controls.Add(this.DistanceVal);
            this.RouteGrpBox.Controls.Add(this.label6);
            this.RouteGrpBox.Controls.Add(this.label5);
            this.RouteGrpBox.Controls.Add(this.label2);
            this.RouteGrpBox.Controls.Add(this.button6);
            this.RouteGrpBox.Controls.Add(this.LongitudeVal);
            this.RouteGrpBox.Controls.Add(this.LatitudeVal);
            this.RouteGrpBox.Controls.Add(this.EnableRoutesCheckBox);
            this.RouteGrpBox.Controls.Add(this.button2);
            this.RouteGrpBox.Location = new System.Drawing.Point(589, 288);
            this.RouteGrpBox.Name = "RouteGrpBox";
            this.RouteGrpBox.Size = new System.Drawing.Size(183, 201);
            this.RouteGrpBox.TabIndex = 12;
            this.RouteGrpBox.TabStop = false;
            this.RouteGrpBox.Text = "Routes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Pick location by R button";
            // 
            // DistanceVal
            // 
            this.DistanceVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DistanceVal.Location = new System.Drawing.Point(71, 171);
            this.DistanceVal.Name = "DistanceVal";
            this.DistanceVal.ReadOnly = true;
            this.DistanceVal.Size = new System.Drawing.Size(101, 20);
            this.DistanceVal.TabIndex = 18;
            this.DistanceVal.Text = "O Kms";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Distance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Longiitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Latitude";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(97, 111);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Add Point";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // LongitudeVal
            // 
            this.LongitudeVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LongitudeVal.Location = new System.Drawing.Point(71, 86);
            this.LongitudeVal.Name = "LongitudeVal";
            this.LongitudeVal.ReadOnly = true;
            this.LongitudeVal.Size = new System.Drawing.Size(101, 20);
            this.LongitudeVal.TabIndex = 13;
            // 
            // LatitudeVal
            // 
            this.LatitudeVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LatitudeVal.Location = new System.Drawing.Point(71, 58);
            this.LatitudeVal.Name = "LatitudeVal";
            this.LatitudeVal.ReadOnly = true;
            this.LatitudeVal.Size = new System.Drawing.Size(101, 20);
            this.LatitudeVal.TabIndex = 12;
            // 
            // EnableRoutesCheckBox
            // 
            this.EnableRoutesCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EnableRoutesCheckBox.AutoSize = true;
            this.EnableRoutesCheckBox.Location = new System.Drawing.Point(12, 19);
            this.EnableRoutesCheckBox.Name = "EnableRoutesCheckBox";
            this.EnableRoutesCheckBox.Size = new System.Drawing.Size(99, 17);
            this.EnableRoutesCheckBox.TabIndex = 11;
            this.EnableRoutesCheckBox.Text = "Enable Routing";
            this.EnableRoutesCheckBox.UseVisualStyleBackColor = true;
            this.EnableRoutesCheckBox.CheckedChanged += new System.EventHandler(this.EnableRoutesCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 537);
            this.Controls.Add(this.RouteGrpBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.goolgeMap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Google Map Locator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedControl)).EndInit();
            this.RouteGrpBox.ResumeLayout(false);
            this.RouteGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl goolgeMap;
        private System.Windows.Forms.Label LatitudeLable;
        private System.Windows.Forms.TextBox LatitudeEditBox;
        private System.Windows.Forms.TextBox longitudeEdidBox;
        private System.Windows.Forms.Label longitudeLable;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.BindingSource bindingSource1;
        private OpenFileDialog ImportDialog;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label1;
        private Button button5;
        private TrackBar SpeedControl;
        private Label label4;
        private GroupBox RouteGrpBox;
        private Button button6;
        private TextBox LongitudeVal;
        private TextBox LatitudeVal;
        private CheckBox EnableRoutesCheckBox;
        private Label label5;
        private Label label2;
        private TextBox DistanceVal;
        private Label label6;
        private Label DistTravelled;
        private Label label7;
    }
}

