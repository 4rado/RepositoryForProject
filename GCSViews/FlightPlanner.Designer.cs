namespace MissionPlanner.GCSViews
 {
     partial class FlightPlanner
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

             if (currentMarker != null)
                 currentMarker.Dispose();
             if (blue.polygon != null)
                 blue.polygon.Dispose();
             if (kmlpolygonsoverlay != null)
                 kmlpolygonsoverlay.Dispose();
             if (wppolygon != null)
                 wppolygon.Dispose();
             if (top != null)
                 top.Dispose();
             if (geofencepolygon != null)
                 geofencepolygon.Dispose();
             if (geofenceoverlay != null)
                 geofenceoverlay.Dispose();
             if (blue.overlay != null)
                 blue.overlay.Dispose();
             if (center != null)
                 center.Dispose();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightPlanner));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Commands = new System.Windows.Forms.DataGridView();
            this.Command = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Param1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Up = new System.Windows.Forms.DataGridViewImageColumn();
            this.Down = new System.Windows.Forms.DataGridViewImageColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHK_verifyheight = new System.Windows.Forms.CheckBox();
            this.TXT_WPRad = new System.Windows.Forms.TextBox();
            this.TXT_DefaultAlt = new System.Windows.Forms.TextBox();
            this.LBL_WPRad = new System.Windows.Forms.Label();
            this.LBL_defalutalt = new System.Windows.Forms.Label();
            this.TXT_loiterrad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.panelWaypoints = new BSE.Windows.Forms.Panel();
            this.splitter1 = new BSE.Windows.Forms.Splitter();
            this.CMB_altmode = new System.Windows.Forms.ComboBox();
            this.CHK_splinedefault = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TXT_altwarn = new System.Windows.Forms.TextBox();
            this.BUT_Add = new MissionPlanner.Controls.MyButton();
            this.splitter2 = new BSE.Windows.Forms.Splitter();
            this.panelMap = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BUT_Rect = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BUT_removePoint = new System.Windows.Forms.PictureBox();
            this.BUT_Polygon = new System.Windows.Forms.PictureBox();
            this.BUT_GreenZone = new System.Windows.Forms.PictureBox();
            this.BUT_removePolygon = new System.Windows.Forms.PictureBox();
            this.BUT_RedZone = new System.Windows.Forms.PictureBox();
            this.BUT_Waypoints = new System.Windows.Forms.PictureBox();
            this.lbl_distance = new System.Windows.Forms.Label();
            this.lbl_homedist = new System.Windows.Forms.Label();
            this.lbl_prevdist = new System.Windows.Forms.Label();
            this.trackBar1 = new MissionPlanner.Controls.MyTrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.MainMap = new MissionPlanner.Controls.myGMAP();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertWpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertSplineWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loiterForeverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loitertimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loitercirclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpstartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpwPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPolygonPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setRallyPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getRallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.geoFenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.GeoFenceuploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeoFencedownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setReturnLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createWpCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSplineCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMeasure = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefetchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefetchWPPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kMLOverlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elevationGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseWPsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileLoadSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAndAppendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadKMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSHPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poiaddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poideleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poieditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackerHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flyToHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyAltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterUTMCoordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchDockingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.NUM_repttime = new System.Windows.Forms.NumericUpDown();
            this.num_reptpwm = new System.Windows.Forms.NumericUpDown();
            this.NUM_reptservo = new System.Windows.Forms.NumericUpDown();
            this.rad_digicam = new System.Windows.Forms.RadioButton();
            this.rad_repeatservo = new System.Windows.Forms.RadioButton();
            this.rad_trigdist = new System.Windows.Forms.RadioButton();
            this.panelBASE = new System.Windows.Forms.Panel();
            this.StatsPanel = new BSE.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel9 = new BSE.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            this.myButton3 = new MissionPlanner.Controls.MyButton();
            this.lbl_altitude = new System.Windows.Forms.Label();
            this.lbl_photoevery = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lbl_flighttime = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lbl_distbetweenlines = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbl_footprint = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lbl_strips = new System.Windows.Forms.Label();
            this.lbl_pictures = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.lbl_spacing = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl_area = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panelAction = new BSE.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BUT_startMission = new MissionPlanner.Controls.MyButton();
            this.myButton2 = new MissionPlanner.Controls.MyButton();
            this.Survey_Grid = new MissionPlanner.Controls.MyButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chk_grid = new System.Windows.Forms.CheckBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.comboBoxMapType = new System.Windows.Forms.ComboBox();
            this.lnk_kml = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_wpfile = new System.Windows.Forms.Label();
            this.BUT_loadwpfile = new MissionPlanner.Controls.MyButton();
            this.BUT_saveWPFile = new MissionPlanner.Controls.MyButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BUT_write = new MissionPlanner.Controls.MyButton();
            this.BUT_read = new MissionPlanner.Controls.MyButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TXT_homealt = new System.Windows.Forms.TextBox();
            this.TXT_homelng = new System.Windows.Forms.TextBox();
            this.TXT_homelat = new System.Windows.Forms.TextBox();
            this.coords1 = new MissionPlanner.Controls.Coords();
            this.panel6 = new BSE.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSimple = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TXT_overlap = new System.Windows.Forms.Label();
            this.Decline = new MissionPlanner.Controls.MyButton();
            this.label32 = new System.Windows.Forms.Label();
            this.BUT_Accept = new MissionPlanner.Controls.MyButton();
            this.label36 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.CHK_toandland_RTL = new System.Windows.Forms.CheckBox();
            this.label44 = new System.Windows.Forms.Label();
            this.CHK_toandland = new System.Windows.Forms.CheckBox();
            this.label43 = new System.Windows.Forms.Label();
            this.TBAR_overlap = new System.Windows.Forms.TrackBar();
            this.label37 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TBAR_zoom = new System.Windows.Forms.TrackBar();
            this.TXT_cmpixel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CHK_footprints = new System.Windows.Forms.CheckBox();
            this.CHK_internals = new System.Windows.Forms.CheckBox();
            this.CHK_grid1 = new System.Windows.Forms.CheckBox();
            this.CHK_markers = new System.Windows.Forms.CheckBox();
            this.CHK_boundary = new System.Windows.Forms.CheckBox();
            this.tabCamera = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.NUM_UpDownFlySpeed = new System.Windows.Forms.NumericUpDown();
            this.TXT_max_flight_time = new System.Windows.Forms.TextBox();
            this.TXT_max_dive_angle = new System.Windows.Forms.TextBox();
            this.TXT_max_climb_angle = new System.Windows.Forms.TextBox();
            this.TXT_turn_radius = new System.Windows.Forms.TextBox();
            this.TXT_max_alt = new System.Windows.Forms.TextBox();
            this.TXT_min_alt = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.myLabel1 = new MissionPlanner.Controls.MyLabel();
            this.RadioLandspace = new System.Windows.Forms.RadioButton();
            this.RadioPortrait = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TXT_sensheight = new System.Windows.Forms.TextBox();
            this.TXT_senswidth = new System.Windows.Forms.TextBox();
            this.TXT_imgheight = new System.Windows.Forms.TextBox();
            this.TXT_imgwidth = new System.Windows.Forms.TextBox();
            this.NUM_focallength = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CHK_usespeed = new System.Windows.Forms.CheckBox();
            this.BUT_samplephoto = new MissionPlanner.Controls.MyButton();
            this.BUT_save = new MissionPlanner.Controls.MyButton();
            this.CHK_advanced = new System.Windows.Forms.CheckBox();
            this.CMB_camera = new System.Windows.Forms.ComboBox();
            this.tabGrid = new System.Windows.Forms.TabPage();
            this.groupBox_copter = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CHK_copter_headinghold = new System.Windows.Forms.CheckBox();
            this.TXT_headinghold = new System.Windows.Forms.TextBox();
            this.CHK_copter_headingholdlock = new System.Windows.Forms.CheckBox();
            this.NUM_copter_delay = new System.Windows.Forms.NumericUpDown();
            this.BUT_headingholdplus = new System.Windows.Forms.Button();
            this.BUT_headingholdminus = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CHK_camdirection = new System.Windows.Forms.CheckBox();
            this.BUT_Launch_Wizard = new MissionPlanner.Controls.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.Commands)).BeginInit();
            this.panelWaypoints.SuspendLayout();
            this.panelMap.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BUT_Rect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BUT_removePoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUT_Polygon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUT_GreenZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUT_removePolygon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUT_RedZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUT_Waypoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_repttime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_reptpwm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_reptservo)).BeginInit();
            this.panelBASE.SuspendLayout();
            this.StatsPanel.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSimple.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBAR_overlap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAR_zoom)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabCamera.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_UpDownFlySpeed)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_focallength)).BeginInit();
            this.tabGrid.SuspendLayout();
            this.groupBox_copter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_copter_delay)).BeginInit();
            this.SuspendLayout();
            // 
            // Commands
            // 
            this.Commands.AllowUserToAddRows = false;
            resources.ApplyResources(this.Commands, "Commands");
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Commands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Commands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Command,
            this.Param1,
            this.Param2,
            this.Param3,
            this.Param4,
            this.Lat,
            this.Lon,
            this.Alt,
            this.Delete,
            this.Up,
            this.Down,
            this.Grad,
            this.Dist,
            this.AZ});
            this.Commands.Name = "Commands";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Commands.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.Commands.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Commands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_CellContentClick);
            this.Commands.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_CellEndEdit);
            this.Commands.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Commands_DataError);
            this.Commands.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.Commands_DefaultValuesNeeded);
            this.Commands.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Commands_EditingControlShowing);
            this.Commands.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_RowEnter);
            this.Commands.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Commands_RowsAdded);
            this.Commands.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Commands_RowValidating);
            // 
            // Command
            // 
            this.Command.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Command.DefaultCellStyle = dataGridViewCellStyle2;
            this.Command.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            resources.ApplyResources(this.Command, "Command");
            this.Command.Name = "Command";
            // 
            // Param1
            // 
            this.Param1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Param1, "Param1");
            this.Param1.Name = "Param1";
            this.Param1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param2
            // 
            this.Param2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Param2, "Param2");
            this.Param2.Name = "Param2";
            this.Param2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param3
            // 
            this.Param3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Param3, "Param3");
            this.Param3.Name = "Param3";
            this.Param3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param4
            // 
            this.Param4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Param4, "Param4");
            this.Param4.Name = "Param4";
            this.Param4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lat
            // 
            this.Lat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Lat, "Lat");
            this.Lat.Name = "Lat";
            this.Lat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lon
            // 
            this.Lon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Lon, "Lon");
            this.Lon.Name = "Lon";
            this.Lon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Alt
            // 
            this.Alt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Alt, "Alt");
            this.Alt.Name = "Alt";
            this.Alt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Name = "Delete";
            this.Delete.Text = "X";
            // 
            // Up
            // 
            this.Up.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Up.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.Up, "Up");
            this.Up.Image = ((System.Drawing.Image)(resources.GetObject("Up.Image")));
            this.Up.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Up.Name = "Up";
            // 
            // Down
            // 
            this.Down.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Down.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.Down, "Down");
            this.Down.Image = ((System.Drawing.Image)(resources.GetObject("Down.Image")));
            this.Down.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Down.Name = "Down";
            // 
            // Grad
            // 
            this.Grad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Grad, "Grad");
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            this.Grad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Dist
            // 
            this.Dist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Dist, "Dist");
            this.Dist.Name = "Dist";
            this.Dist.ReadOnly = true;
            this.Dist.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AZ
            // 
            this.AZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.AZ, "AZ");
            this.AZ.Name = "AZ";
            this.AZ.ReadOnly = true;
            this.AZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CHK_verifyheight
            // 
            resources.ApplyResources(this.CHK_verifyheight, "CHK_verifyheight");
            this.CHK_verifyheight.Name = "CHK_verifyheight";
            this.CHK_verifyheight.UseVisualStyleBackColor = true;
            // 
            // TXT_WPRad
            // 
            resources.ApplyResources(this.TXT_WPRad, "TXT_WPRad");
            this.TXT_WPRad.Name = "TXT_WPRad";
            this.TXT_WPRad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_WPRad_KeyPress);
            this.TXT_WPRad.Leave += new System.EventHandler(this.TXT_WPRad_Leave);
            // 
            // TXT_DefaultAlt
            // 
            resources.ApplyResources(this.TXT_DefaultAlt, "TXT_DefaultAlt");
            this.TXT_DefaultAlt.Name = "TXT_DefaultAlt";
            this.TXT_DefaultAlt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_DefaultAlt_KeyPress);
            this.TXT_DefaultAlt.Leave += new System.EventHandler(this.TXT_DefaultAlt_Leave);
            // 
            // LBL_WPRad
            // 
            resources.ApplyResources(this.LBL_WPRad, "LBL_WPRad");
            this.LBL_WPRad.Name = "LBL_WPRad";
            // 
            // LBL_defalutalt
            // 
            resources.ApplyResources(this.LBL_defalutalt, "LBL_defalutalt");
            this.LBL_defalutalt.Name = "LBL_defalutalt";
            // 
            // TXT_loiterrad
            // 
            resources.ApplyResources(this.TXT_loiterrad, "TXT_loiterrad");
            this.TXT_loiterrad.Name = "TXT_loiterrad";
            this.TXT_loiterrad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_loiterrad_KeyPress);
            this.TXT_loiterrad.Leave += new System.EventHandler(this.TXT_loiterrad_Leave);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // panelWaypoints
            // 
            this.panelWaypoints.AssociatedSplitter = this.splitter1;
            this.panelWaypoints.BackColor = System.Drawing.Color.Transparent;
            this.panelWaypoints.CaptionFont = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.panelWaypoints.CaptionHeight = 21;
            this.panelWaypoints.ColorScheme = BSE.Windows.Forms.ColorScheme.Custom;
            this.panelWaypoints.Controls.Add(this.CMB_altmode);
            this.panelWaypoints.Controls.Add(this.CHK_splinedefault);
            this.panelWaypoints.Controls.Add(this.label17);
            this.panelWaypoints.Controls.Add(this.TXT_altwarn);
            this.panelWaypoints.Controls.Add(this.LBL_WPRad);
            this.panelWaypoints.Controls.Add(this.label5);
            this.panelWaypoints.Controls.Add(this.TXT_loiterrad);
            this.panelWaypoints.Controls.Add(this.LBL_defalutalt);
            this.panelWaypoints.Controls.Add(this.Commands);
            this.panelWaypoints.Controls.Add(this.TXT_DefaultAlt);
            this.panelWaypoints.Controls.Add(this.CHK_verifyheight);
            this.panelWaypoints.Controls.Add(this.TXT_WPRad);
            this.panelWaypoints.Controls.Add(this.BUT_Add);
            this.panelWaypoints.CustomColors.BorderColor = System.Drawing.Color.Black;
            this.panelWaypoints.CustomColors.CaptionCloseIcon = System.Drawing.Color.White;
            this.panelWaypoints.CustomColors.CaptionExpandIcon = System.Drawing.Color.White;
            this.panelWaypoints.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.panelWaypoints.CustomColors.CaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(226)))), ((int)(((byte)(150)))));
            this.panelWaypoints.CustomColors.CaptionGradientMiddle = System.Drawing.Color.Transparent;
            this.panelWaypoints.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.Transparent;
            this.panelWaypoints.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.Transparent;
            this.panelWaypoints.CustomColors.CaptionText = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.panelWaypoints.CustomColors.CollapsedCaptionText = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.panelWaypoints.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panelWaypoints.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelWaypoints.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.panelWaypoints, "panelWaypoints");
            this.panelWaypoints.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelWaypoints.Image = null;
            this.panelWaypoints.Name = "panelWaypoints";
            this.panelWaypoints.ShowExpandIcon = true;
            this.panelWaypoints.ToolTipTextCloseIcon = null;
            this.panelWaypoints.ToolTipTextExpandIconPanelCollapsed = null;
            this.panelWaypoints.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // CMB_altmode
            // 
            this.CMB_altmode.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_altmode, "CMB_altmode");
            this.CMB_altmode.Name = "CMB_altmode";
            this.CMB_altmode.SelectedIndexChanged += new System.EventHandler(this.CMB_altmode_SelectedIndexChanged);
            // 
            // CHK_splinedefault
            // 
            resources.ApplyResources(this.CHK_splinedefault, "CHK_splinedefault");
            this.CHK_splinedefault.Name = "CHK_splinedefault";
            this.CHK_splinedefault.UseVisualStyleBackColor = true;
            this.CHK_splinedefault.CheckedChanged += new System.EventHandler(this.CHK_splinedefault_CheckedChanged);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // TXT_altwarn
            // 
            resources.ApplyResources(this.TXT_altwarn, "TXT_altwarn");
            this.TXT_altwarn.Name = "TXT_altwarn";
            // 
            // BUT_Add
            // 
            resources.ApplyResources(this.BUT_Add, "BUT_Add");
            this.BUT_Add.Name = "BUT_Add";
            this.toolTip1.SetToolTip(this.BUT_Add, resources.GetString("BUT_Add.ToolTip"));
            this.BUT_Add.UseVisualStyleBackColor = true;
            this.BUT_Add.Click += new System.EventHandler(this.BUT_Add_Click);
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.splitter2, "splitter2");
            this.splitter2.Name = "splitter2";
            this.splitter2.TabStop = false;
            // 
            // panelMap
            // 
            this.panelMap.Controls.Add(this.groupBox7);
            this.panelMap.Controls.Add(this.groupBox1);
            this.panelMap.Controls.Add(this.lbl_distance);
            this.panelMap.Controls.Add(this.lbl_homedist);
            this.panelMap.Controls.Add(this.lbl_prevdist);
            this.panelMap.Controls.Add(this.trackBar1);
            this.panelMap.Controls.Add(this.label11);
            this.panelMap.Controls.Add(this.MainMap);
            resources.ApplyResources(this.panelMap, "panelMap");
            this.panelMap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMap.Name = "panelMap";
            this.panelMap.Resize += new System.EventHandler(this.panelMap_Resize);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Controls.Add(this.BUT_Rect);
            this.groupBox7.Controls.Add(this.pictureBox8);
            this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox7.ForeColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // BUT_Rect
            // 
            this.BUT_Rect.BackColor = System.Drawing.Color.White;
            this.BUT_Rect.BackgroundImage = global::MissionPlanner.Properties.Resources.screen77;
            resources.ApplyResources(this.BUT_Rect, "BUT_Rect");
            this.BUT_Rect.InitialImage = global::MissionPlanner.Properties.Resources.screen77;
            this.BUT_Rect.Name = "BUT_Rect";
            this.BUT_Rect.TabStop = false;
            this.toolTip1.SetToolTip(this.BUT_Rect, resources.GetString("BUT_Rect.ToolTip"));
            this.BUT_Rect.Click += new System.EventHandler(this.BUT_Rect_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.BackgroundImage = global::MissionPlanner.Properties.Resources.plane24;
            this.pictureBox8.Image = global::MissionPlanner.Properties.Resources.plane24;
            resources.ApplyResources(this.pictureBox8, "pictureBox8");
            this.pictureBox8.InitialImage = global::MissionPlanner.Properties.Resources.plane24;
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox8, resources.GetString("pictureBox8.ToolTip"));
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.BUT_removePoint);
            this.groupBox1.Controls.Add(this.BUT_Polygon);
            this.groupBox1.Controls.Add(this.BUT_GreenZone);
            this.groupBox1.Controls.Add(this.BUT_removePolygon);
            this.groupBox1.Controls.Add(this.BUT_RedZone);
            this.groupBox1.Controls.Add(this.BUT_Waypoints);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Click);
            // 
            // BUT_removePoint
            // 
            this.BUT_removePoint.BackgroundImage = global::MissionPlanner.Properties.Resources.pointer17;
            resources.ApplyResources(this.BUT_removePoint, "BUT_removePoint");
            this.BUT_removePoint.InitialImage = global::MissionPlanner.Properties.Resources.pointer17;
            this.BUT_removePoint.Name = "BUT_removePoint";
            this.BUT_removePoint.TabStop = false;
            this.toolTip1.SetToolTip(this.BUT_removePoint, resources.GetString("BUT_removePoint.ToolTip"));
            this.BUT_removePoint.Click += new System.EventHandler(this.BUT_removePoint_Click);
            // 
            // BUT_Polygon
            // 
            this.BUT_Polygon.BackgroundImage = global::MissionPlanner.Properties.Resources.irregular10;
            resources.ApplyResources(this.BUT_Polygon, "BUT_Polygon");
            this.BUT_Polygon.InitialImage = global::MissionPlanner.Properties.Resources.irregular10;
            this.BUT_Polygon.Name = "BUT_Polygon";
            this.BUT_Polygon.TabStop = false;
            this.toolTip1.SetToolTip(this.BUT_Polygon, resources.GetString("BUT_Polygon.ToolTip"));
            this.BUT_Polygon.Click += new System.EventHandler(this.BUT_Polygon_Click);
            // 
            // BUT_GreenZone
            // 
            this.BUT_GreenZone.BackgroundImage = global::MissionPlanner.Properties.Resources.shield114;
            resources.ApplyResources(this.BUT_GreenZone, "BUT_GreenZone");
            this.BUT_GreenZone.InitialImage = global::MissionPlanner.Properties.Resources.shield114;
            this.BUT_GreenZone.Name = "BUT_GreenZone";
            this.BUT_GreenZone.TabStop = false;
            this.toolTip1.SetToolTip(this.BUT_GreenZone, resources.GetString("BUT_GreenZone.ToolTip"));
            this.BUT_GreenZone.Click += new System.EventHandler(this.BUT_GreenZone_Click);
            // 
            // BUT_removePolygon
            // 
            this.BUT_removePolygon.BackgroundImage = global::MissionPlanner.Properties.Resources.irregular11;
            resources.ApplyResources(this.BUT_removePolygon, "BUT_removePolygon");
            this.BUT_removePolygon.InitialImage = global::MissionPlanner.Properties.Resources.irregular11;
            this.BUT_removePolygon.Name = "BUT_removePolygon";
            this.BUT_removePolygon.TabStop = false;
            this.toolTip1.SetToolTip(this.BUT_removePolygon, resources.GetString("BUT_removePolygon.ToolTip"));
            this.BUT_removePolygon.Click += new System.EventHandler(this.BUT_removePolygon_Click);
            // 
            // BUT_RedZone
            // 
            this.BUT_RedZone.BackgroundImage = global::MissionPlanner.Properties.Resources.warning41;
            resources.ApplyResources(this.BUT_RedZone, "BUT_RedZone");
            this.BUT_RedZone.InitialImage = global::MissionPlanner.Properties.Resources.warning41;
            this.BUT_RedZone.Name = "BUT_RedZone";
            this.BUT_RedZone.TabStop = false;
            this.toolTip1.SetToolTip(this.BUT_RedZone, resources.GetString("BUT_RedZone.ToolTip"));
            this.BUT_RedZone.Click += new System.EventHandler(this.BUT_RedZone_Click);
            // 
            // BUT_Waypoints
            // 
            this.BUT_Waypoints.Image = global::MissionPlanner.Properties.Resources.map4;
            resources.ApplyResources(this.BUT_Waypoints, "BUT_Waypoints");
            this.BUT_Waypoints.InitialImage = global::MissionPlanner.Properties.Resources.map4;
            this.BUT_Waypoints.Name = "BUT_Waypoints";
            this.BUT_Waypoints.TabStop = false;
            this.BUT_Waypoints.Tag = "321";
            this.toolTip1.SetToolTip(this.BUT_Waypoints, resources.GetString("BUT_Waypoints.ToolTip"));
            this.BUT_Waypoints.Click += new System.EventHandler(this.BUT_Waypoints_Click);
            // 
            // lbl_distance
            // 
            resources.ApplyResources(this.lbl_distance, "lbl_distance");
            this.lbl_distance.Name = "lbl_distance";
            // 
            // lbl_homedist
            // 
            resources.ApplyResources(this.lbl_homedist, "lbl_homedist");
            this.lbl_homedist.Name = "lbl_homedist";
            // 
            // lbl_prevdist
            // 
            resources.ApplyResources(this.lbl_prevdist, "lbl_prevdist");
            this.lbl_prevdist.Name = "lbl_prevdist";
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.LargeChange = 0.005F;
            this.trackBar1.Maximum = 24F;
            this.trackBar1.Minimum = 1F;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.SmallChange = 0.001F;
            this.trackBar1.TickFrequency = 1F;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 2F;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // MainMap
            // 
            resources.ApplyResources(this.MainMap, "MainMap");
            this.MainMap.BackColor = System.Drawing.Color.Transparent;
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.ContextMenuStrip = this.contextMenuStrip1;
            this.MainMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Gray;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 19;
            this.MainMap.MinZoom = 0;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = false;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Zoom = 0D;
            this.MainMap.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMap_Paint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteWPToolStripMenuItem,
            this.insertWpToolStripMenuItem,
            this.insertSplineWPToolStripMenuItem,
            this.loiterToolStripMenuItem,
            this.jumpToolStripMenuItem,
            this.rTLToolStripMenuItem,
            this.landToolStripMenuItem,
            this.takeoffToolStripMenuItem,
            this.setROIToolStripMenuItem,
            this.clearMissionToolStripMenuItem,
            this.toolStripSeparator1,
            this.polygonToolStripMenuItem,
            this.rallyPointsToolStripMenuItem,
            this.geoFenceToolStripMenuItem,
            this.autoWPToolStripMenuItem,
            this.mapToolToolStripMenuItem,
            this.fileLoadSaveToolStripMenuItem,
            this.pOIToolStripMenuItem,
            this.trackerHomeToolStripMenuItem,
            this.flyToHereToolStripMenuItem,
            this.modifyAltToolStripMenuItem,
            this.enterUTMCoordToolStripMenuItem,
            this.switchDockingToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // deleteWPToolStripMenuItem
            // 
            this.deleteWPToolStripMenuItem.Name = "deleteWPToolStripMenuItem";
            resources.ApplyResources(this.deleteWPToolStripMenuItem, "deleteWPToolStripMenuItem");
            this.deleteWPToolStripMenuItem.Click += new System.EventHandler(this.deleteWPToolStripMenuItem_Click);
            // 
            // insertWpToolStripMenuItem
            // 
            this.insertWpToolStripMenuItem.Name = "insertWpToolStripMenuItem";
            resources.ApplyResources(this.insertWpToolStripMenuItem, "insertWpToolStripMenuItem");
            this.insertWpToolStripMenuItem.Click += new System.EventHandler(this.insertWpToolStripMenuItem_Click);
            // 
            // insertSplineWPToolStripMenuItem
            // 
            this.insertSplineWPToolStripMenuItem.Name = "insertSplineWPToolStripMenuItem";
            resources.ApplyResources(this.insertSplineWPToolStripMenuItem, "insertSplineWPToolStripMenuItem");
            this.insertSplineWPToolStripMenuItem.Click += new System.EventHandler(this.insertSplineWPToolStripMenuItem_Click);
            // 
            // loiterToolStripMenuItem
            // 
            this.loiterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loiterForeverToolStripMenuItem,
            this.loitertimeToolStripMenuItem,
            this.loitercirclesToolStripMenuItem});
            this.loiterToolStripMenuItem.Name = "loiterToolStripMenuItem";
            resources.ApplyResources(this.loiterToolStripMenuItem, "loiterToolStripMenuItem");
            // 
            // loiterForeverToolStripMenuItem
            // 
            this.loiterForeverToolStripMenuItem.Name = "loiterForeverToolStripMenuItem";
            resources.ApplyResources(this.loiterForeverToolStripMenuItem, "loiterForeverToolStripMenuItem");
            this.loiterForeverToolStripMenuItem.Click += new System.EventHandler(this.loiterForeverToolStripMenuItem_Click);
            // 
            // loitertimeToolStripMenuItem
            // 
            this.loitertimeToolStripMenuItem.Name = "loitertimeToolStripMenuItem";
            resources.ApplyResources(this.loitertimeToolStripMenuItem, "loitertimeToolStripMenuItem");
            this.loitertimeToolStripMenuItem.Click += new System.EventHandler(this.loitertimeToolStripMenuItem_Click);
            // 
            // loitercirclesToolStripMenuItem
            // 
            this.loitercirclesToolStripMenuItem.Name = "loitercirclesToolStripMenuItem";
            resources.ApplyResources(this.loitercirclesToolStripMenuItem, "loitercirclesToolStripMenuItem");
            this.loitercirclesToolStripMenuItem.Click += new System.EventHandler(this.loitercirclesToolStripMenuItem_Click);
            // 
            // jumpToolStripMenuItem
            // 
            this.jumpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jumpstartToolStripMenuItem,
            this.jumpwPToolStripMenuItem});
            this.jumpToolStripMenuItem.Name = "jumpToolStripMenuItem";
            resources.ApplyResources(this.jumpToolStripMenuItem, "jumpToolStripMenuItem");
            // 
            // jumpstartToolStripMenuItem
            // 
            this.jumpstartToolStripMenuItem.Name = "jumpstartToolStripMenuItem";
            resources.ApplyResources(this.jumpstartToolStripMenuItem, "jumpstartToolStripMenuItem");
            this.jumpstartToolStripMenuItem.Click += new System.EventHandler(this.jumpstartToolStripMenuItem_Click);
            // 
            // jumpwPToolStripMenuItem
            // 
            this.jumpwPToolStripMenuItem.Name = "jumpwPToolStripMenuItem";
            resources.ApplyResources(this.jumpwPToolStripMenuItem, "jumpwPToolStripMenuItem");
            this.jumpwPToolStripMenuItem.Click += new System.EventHandler(this.jumpwPToolStripMenuItem_Click);
            // 
            // rTLToolStripMenuItem
            // 
            this.rTLToolStripMenuItem.Name = "rTLToolStripMenuItem";
            resources.ApplyResources(this.rTLToolStripMenuItem, "rTLToolStripMenuItem");
            this.rTLToolStripMenuItem.Click += new System.EventHandler(this.rTLToolStripMenuItem_Click);
            // 
            // landToolStripMenuItem
            // 
            this.landToolStripMenuItem.Name = "landToolStripMenuItem";
            resources.ApplyResources(this.landToolStripMenuItem, "landToolStripMenuItem");
            this.landToolStripMenuItem.Click += new System.EventHandler(this.landToolStripMenuItem_Click);
            // 
            // takeoffToolStripMenuItem
            // 
            this.takeoffToolStripMenuItem.Name = "takeoffToolStripMenuItem";
            resources.ApplyResources(this.takeoffToolStripMenuItem, "takeoffToolStripMenuItem");
            this.takeoffToolStripMenuItem.Click += new System.EventHandler(this.takeoffToolStripMenuItem_Click);
            // 
            // setROIToolStripMenuItem
            // 
            this.setROIToolStripMenuItem.Name = "setROIToolStripMenuItem";
            resources.ApplyResources(this.setROIToolStripMenuItem, "setROIToolStripMenuItem");
            this.setROIToolStripMenuItem.Click += new System.EventHandler(this.setROIToolStripMenuItem_Click);
            // 
            // clearMissionToolStripMenuItem
            // 
            this.clearMissionToolStripMenuItem.Name = "clearMissionToolStripMenuItem";
            resources.ApplyResources(this.clearMissionToolStripMenuItem, "clearMissionToolStripMenuItem");
            this.clearMissionToolStripMenuItem.Click += new System.EventHandler(this.clearMissionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPolygonPointToolStripMenuItem,
            this.clearPolygonToolStripMenuItem,
            this.savePolygonToolStripMenuItem,
            this.loadPolygonToolStripMenuItem,
            this.fromSHPToolStripMenuItem});
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            resources.ApplyResources(this.polygonToolStripMenuItem, "polygonToolStripMenuItem");
            // 
            // addPolygonPointToolStripMenuItem
            // 
            this.addPolygonPointToolStripMenuItem.Name = "addPolygonPointToolStripMenuItem";
            resources.ApplyResources(this.addPolygonPointToolStripMenuItem, "addPolygonPointToolStripMenuItem");
            this.addPolygonPointToolStripMenuItem.Click += new System.EventHandler(this.addPolygonPointToolStripMenuItem_Click);
            // 
            // clearPolygonToolStripMenuItem
            // 
            this.clearPolygonToolStripMenuItem.Name = "clearPolygonToolStripMenuItem";
            resources.ApplyResources(this.clearPolygonToolStripMenuItem, "clearPolygonToolStripMenuItem");
            this.clearPolygonToolStripMenuItem.Click += new System.EventHandler(this.clearPolygonToolStripMenuItem_Click);
            // 
            // savePolygonToolStripMenuItem
            // 
            this.savePolygonToolStripMenuItem.Name = "savePolygonToolStripMenuItem";
            resources.ApplyResources(this.savePolygonToolStripMenuItem, "savePolygonToolStripMenuItem");
            this.savePolygonToolStripMenuItem.Click += new System.EventHandler(this.savePolygonToolStripMenuItem_Click);
            // 
            // loadPolygonToolStripMenuItem
            // 
            this.loadPolygonToolStripMenuItem.Name = "loadPolygonToolStripMenuItem";
            resources.ApplyResources(this.loadPolygonToolStripMenuItem, "loadPolygonToolStripMenuItem");
            this.loadPolygonToolStripMenuItem.Click += new System.EventHandler(this.loadPolygonToolStripMenuItem_Click);
            // 
            // fromSHPToolStripMenuItem
            // 
            this.fromSHPToolStripMenuItem.Name = "fromSHPToolStripMenuItem";
            resources.ApplyResources(this.fromSHPToolStripMenuItem, "fromSHPToolStripMenuItem");
            this.fromSHPToolStripMenuItem.Click += new System.EventHandler(this.fromSHPToolStripMenuItem_Click);
            // 
            // rallyPointsToolStripMenuItem
            // 
            this.rallyPointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setRallyPointToolStripMenuItem,
            this.getRallyPointsToolStripMenuItem,
            this.saveRallyPointsToolStripMenuItem,
            this.clearRallyPointsToolStripMenuItem,
            this.saveToFileToolStripMenuItem1,
            this.loadFromFileToolStripMenuItem1});
            this.rallyPointsToolStripMenuItem.Name = "rallyPointsToolStripMenuItem";
            resources.ApplyResources(this.rallyPointsToolStripMenuItem, "rallyPointsToolStripMenuItem");
            // 
            // setRallyPointToolStripMenuItem
            // 
            this.setRallyPointToolStripMenuItem.Name = "setRallyPointToolStripMenuItem";
            resources.ApplyResources(this.setRallyPointToolStripMenuItem, "setRallyPointToolStripMenuItem");
            this.setRallyPointToolStripMenuItem.Click += new System.EventHandler(this.setRallyPointToolStripMenuItem_Click);
            // 
            // getRallyPointsToolStripMenuItem
            // 
            this.getRallyPointsToolStripMenuItem.Name = "getRallyPointsToolStripMenuItem";
            resources.ApplyResources(this.getRallyPointsToolStripMenuItem, "getRallyPointsToolStripMenuItem");
            this.getRallyPointsToolStripMenuItem.Click += new System.EventHandler(this.getRallyPointsToolStripMenuItem_Click);
            // 
            // saveRallyPointsToolStripMenuItem
            // 
            this.saveRallyPointsToolStripMenuItem.Name = "saveRallyPointsToolStripMenuItem";
            resources.ApplyResources(this.saveRallyPointsToolStripMenuItem, "saveRallyPointsToolStripMenuItem");
            this.saveRallyPointsToolStripMenuItem.Click += new System.EventHandler(this.saveRallyPointsToolStripMenuItem_Click);
            // 
            // clearRallyPointsToolStripMenuItem
            // 
            this.clearRallyPointsToolStripMenuItem.Name = "clearRallyPointsToolStripMenuItem";
            resources.ApplyResources(this.clearRallyPointsToolStripMenuItem, "clearRallyPointsToolStripMenuItem");
            this.clearRallyPointsToolStripMenuItem.Click += new System.EventHandler(this.clearRallyPointsToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem1
            // 
            this.saveToFileToolStripMenuItem1.Name = "saveToFileToolStripMenuItem1";
            resources.ApplyResources(this.saveToFileToolStripMenuItem1, "saveToFileToolStripMenuItem1");
            this.saveToFileToolStripMenuItem1.Click += new System.EventHandler(this.saveToFileToolStripMenuItem1_Click);
            // 
            // loadFromFileToolStripMenuItem1
            // 
            this.loadFromFileToolStripMenuItem1.Name = "loadFromFileToolStripMenuItem1";
            resources.ApplyResources(this.loadFromFileToolStripMenuItem1, "loadFromFileToolStripMenuItem1");
            this.loadFromFileToolStripMenuItem1.Click += new System.EventHandler(this.loadFromFileToolStripMenuItem1_Click);
            // 
            // geoFenceToolStripMenuItem
            // 
            this.geoFenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator4,
            this.GeoFenceuploadToolStripMenuItem,
            this.GeoFencedownloadToolStripMenuItem,
            this.setReturnLocationToolStripMenuItem,
            this.loadFromFileToolStripMenuItem,
            this.saveToFileToolStripMenuItem});
            this.geoFenceToolStripMenuItem.Name = "geoFenceToolStripMenuItem";
            resources.ApplyResources(this.geoFenceToolStripMenuItem, "geoFenceToolStripMenuItem");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // GeoFenceuploadToolStripMenuItem
            // 
            this.GeoFenceuploadToolStripMenuItem.Name = "GeoFenceuploadToolStripMenuItem";
            resources.ApplyResources(this.GeoFenceuploadToolStripMenuItem, "GeoFenceuploadToolStripMenuItem");
            this.GeoFenceuploadToolStripMenuItem.Click += new System.EventHandler(this.GeoFenceuploadToolStripMenuItem_Click);
            // 
            // GeoFencedownloadToolStripMenuItem
            // 
            this.GeoFencedownloadToolStripMenuItem.Name = "GeoFencedownloadToolStripMenuItem";
            resources.ApplyResources(this.GeoFencedownloadToolStripMenuItem, "GeoFencedownloadToolStripMenuItem");
            this.GeoFencedownloadToolStripMenuItem.Click += new System.EventHandler(this.GeoFencedownloadToolStripMenuItem_Click);
            // 
            // setReturnLocationToolStripMenuItem
            // 
            this.setReturnLocationToolStripMenuItem.Name = "setReturnLocationToolStripMenuItem";
            resources.ApplyResources(this.setReturnLocationToolStripMenuItem, "setReturnLocationToolStripMenuItem");
            this.setReturnLocationToolStripMenuItem.Click += new System.EventHandler(this.setReturnLocationToolStripMenuItem_Click);
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            resources.ApplyResources(this.loadFromFileToolStripMenuItem, "loadFromFileToolStripMenuItem");
            this.loadFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadFromFileToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            resources.ApplyResources(this.saveToFileToolStripMenuItem, "saveToFileToolStripMenuItem");
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // autoWPToolStripMenuItem
            // 
            this.autoWPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createWpCircleToolStripMenuItem,
            this.areaToolStripMenuItem,
            this.createSplineCircleToolStripMenuItem});
            this.autoWPToolStripMenuItem.Name = "autoWPToolStripMenuItem";
            resources.ApplyResources(this.autoWPToolStripMenuItem, "autoWPToolStripMenuItem");
            // 
            // createWpCircleToolStripMenuItem
            // 
            this.createWpCircleToolStripMenuItem.Name = "createWpCircleToolStripMenuItem";
            resources.ApplyResources(this.createWpCircleToolStripMenuItem, "createWpCircleToolStripMenuItem");
            this.createWpCircleToolStripMenuItem.Click += new System.EventHandler(this.createWpCircleToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            resources.ApplyResources(this.areaToolStripMenuItem, "areaToolStripMenuItem");
            this.areaToolStripMenuItem.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // createSplineCircleToolStripMenuItem
            // 
            this.createSplineCircleToolStripMenuItem.Name = "createSplineCircleToolStripMenuItem";
            resources.ApplyResources(this.createSplineCircleToolStripMenuItem, "createSplineCircleToolStripMenuItem");
            this.createSplineCircleToolStripMenuItem.Click += new System.EventHandler(this.createSplineCircleToolStripMenuItem_Click);
            // 
            // mapToolToolStripMenuItem
            // 
            this.mapToolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMeasure,
            this.rotateMapToolStripMenuItem,
            this.zoomToToolStripMenuItem,
            this.prefetchToolStripMenuItem,
            this.prefetchWPPathToolStripMenuItem,
            this.kMLOverlayToolStripMenuItem,
            this.elevationGraphToolStripMenuItem,
            this.reverseWPsToolStripMenuItem});
            this.mapToolToolStripMenuItem.Name = "mapToolToolStripMenuItem";
            resources.ApplyResources(this.mapToolToolStripMenuItem, "mapToolToolStripMenuItem");
            // 
            // ContextMeasure
            // 
            this.ContextMeasure.Name = "ContextMeasure";
            resources.ApplyResources(this.ContextMeasure, "ContextMeasure");
            this.ContextMeasure.Click += new System.EventHandler(this.ContextMeasure_Click);
            // 
            // rotateMapToolStripMenuItem
            // 
            this.rotateMapToolStripMenuItem.Name = "rotateMapToolStripMenuItem";
            resources.ApplyResources(this.rotateMapToolStripMenuItem, "rotateMapToolStripMenuItem");
            this.rotateMapToolStripMenuItem.Click += new System.EventHandler(this.rotateMapToolStripMenuItem_Click);
            // 
            // zoomToToolStripMenuItem
            // 
            this.zoomToToolStripMenuItem.Name = "zoomToToolStripMenuItem";
            resources.ApplyResources(this.zoomToToolStripMenuItem, "zoomToToolStripMenuItem");
            this.zoomToToolStripMenuItem.Click += new System.EventHandler(this.zoomToToolStripMenuItem_Click);
            // 
            // prefetchToolStripMenuItem
            // 
            this.prefetchToolStripMenuItem.Name = "prefetchToolStripMenuItem";
            resources.ApplyResources(this.prefetchToolStripMenuItem, "prefetchToolStripMenuItem");
            this.prefetchToolStripMenuItem.Click += new System.EventHandler(this.prefetchToolStripMenuItem_Click);
            // 
            // prefetchWPPathToolStripMenuItem
            // 
            this.prefetchWPPathToolStripMenuItem.Name = "prefetchWPPathToolStripMenuItem";
            resources.ApplyResources(this.prefetchWPPathToolStripMenuItem, "prefetchWPPathToolStripMenuItem");
            this.prefetchWPPathToolStripMenuItem.Click += new System.EventHandler(this.prefetchWPPathToolStripMenuItem_Click);
            // 
            // kMLOverlayToolStripMenuItem
            // 
            this.kMLOverlayToolStripMenuItem.Name = "kMLOverlayToolStripMenuItem";
            resources.ApplyResources(this.kMLOverlayToolStripMenuItem, "kMLOverlayToolStripMenuItem");
            this.kMLOverlayToolStripMenuItem.Click += new System.EventHandler(this.kMLOverlayToolStripMenuItem_Click);
            // 
            // elevationGraphToolStripMenuItem
            // 
            this.elevationGraphToolStripMenuItem.Name = "elevationGraphToolStripMenuItem";
            resources.ApplyResources(this.elevationGraphToolStripMenuItem, "elevationGraphToolStripMenuItem");
            this.elevationGraphToolStripMenuItem.Click += new System.EventHandler(this.elevationGraphToolStripMenuItem_Click);
            // 
            // reverseWPsToolStripMenuItem
            // 
            this.reverseWPsToolStripMenuItem.Name = "reverseWPsToolStripMenuItem";
            resources.ApplyResources(this.reverseWPsToolStripMenuItem, "reverseWPsToolStripMenuItem");
            this.reverseWPsToolStripMenuItem.Click += new System.EventHandler(this.reverseWPsToolStripMenuItem_Click);
            // 
            // fileLoadSaveToolStripMenuItem
            // 
            this.fileLoadSaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadWPFileToolStripMenuItem,
            this.loadAndAppendToolStripMenuItem,
            this.saveWPFileToolStripMenuItem,
            this.loadKMLFileToolStripMenuItem,
            this.loadSHPFileToolStripMenuItem});
            this.fileLoadSaveToolStripMenuItem.Name = "fileLoadSaveToolStripMenuItem";
            resources.ApplyResources(this.fileLoadSaveToolStripMenuItem, "fileLoadSaveToolStripMenuItem");
            // 
            // loadWPFileToolStripMenuItem
            // 
            this.loadWPFileToolStripMenuItem.Name = "loadWPFileToolStripMenuItem";
            resources.ApplyResources(this.loadWPFileToolStripMenuItem, "loadWPFileToolStripMenuItem");
            this.loadWPFileToolStripMenuItem.Click += new System.EventHandler(this.loadWPFileToolStripMenuItem_Click);
            // 
            // loadAndAppendToolStripMenuItem
            // 
            this.loadAndAppendToolStripMenuItem.Name = "loadAndAppendToolStripMenuItem";
            resources.ApplyResources(this.loadAndAppendToolStripMenuItem, "loadAndAppendToolStripMenuItem");
            this.loadAndAppendToolStripMenuItem.Click += new System.EventHandler(this.loadAndAppendToolStripMenuItem_Click);
            // 
            // saveWPFileToolStripMenuItem
            // 
            this.saveWPFileToolStripMenuItem.Name = "saveWPFileToolStripMenuItem";
            resources.ApplyResources(this.saveWPFileToolStripMenuItem, "saveWPFileToolStripMenuItem");
            this.saveWPFileToolStripMenuItem.Click += new System.EventHandler(this.saveWPFileToolStripMenuItem_Click);
            // 
            // loadKMLFileToolStripMenuItem
            // 
            this.loadKMLFileToolStripMenuItem.Name = "loadKMLFileToolStripMenuItem";
            resources.ApplyResources(this.loadKMLFileToolStripMenuItem, "loadKMLFileToolStripMenuItem");
            this.loadKMLFileToolStripMenuItem.Click += new System.EventHandler(this.loadKMLFileToolStripMenuItem_Click);
            // 
            // loadSHPFileToolStripMenuItem
            // 
            this.loadSHPFileToolStripMenuItem.Name = "loadSHPFileToolStripMenuItem";
            resources.ApplyResources(this.loadSHPFileToolStripMenuItem, "loadSHPFileToolStripMenuItem");
            this.loadSHPFileToolStripMenuItem.Click += new System.EventHandler(this.loadSHPFileToolStripMenuItem_Click);
            // 
            // pOIToolStripMenuItem
            // 
            this.pOIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poiaddToolStripMenuItem,
            this.poideleteToolStripMenuItem,
            this.poieditToolStripMenuItem});
            this.pOIToolStripMenuItem.Name = "pOIToolStripMenuItem";
            resources.ApplyResources(this.pOIToolStripMenuItem, "pOIToolStripMenuItem");
            // 
            // poiaddToolStripMenuItem
            // 
            this.poiaddToolStripMenuItem.Name = "poiaddToolStripMenuItem";
            resources.ApplyResources(this.poiaddToolStripMenuItem, "poiaddToolStripMenuItem");
            this.poiaddToolStripMenuItem.Click += new System.EventHandler(this.poiaddToolStripMenuItem_Click);
            // 
            // poideleteToolStripMenuItem
            // 
            this.poideleteToolStripMenuItem.Name = "poideleteToolStripMenuItem";
            resources.ApplyResources(this.poideleteToolStripMenuItem, "poideleteToolStripMenuItem");
            this.poideleteToolStripMenuItem.Click += new System.EventHandler(this.poideleteToolStripMenuItem_Click);
            // 
            // poieditToolStripMenuItem
            // 
            this.poieditToolStripMenuItem.Name = "poieditToolStripMenuItem";
            resources.ApplyResources(this.poieditToolStripMenuItem, "poieditToolStripMenuItem");
            this.poieditToolStripMenuItem.Click += new System.EventHandler(this.poieditToolStripMenuItem_Click);
            // 
            // trackerHomeToolStripMenuItem
            // 
            this.trackerHomeToolStripMenuItem.Name = "trackerHomeToolStripMenuItem";
            resources.ApplyResources(this.trackerHomeToolStripMenuItem, "trackerHomeToolStripMenuItem");
            this.trackerHomeToolStripMenuItem.Click += new System.EventHandler(this.trackerHomeToolStripMenuItem_Click);
            // 
            // flyToHereToolStripMenuItem
            // 
            this.flyToHereToolStripMenuItem.Name = "flyToHereToolStripMenuItem";
            resources.ApplyResources(this.flyToHereToolStripMenuItem, "flyToHereToolStripMenuItem");
            // 
            // modifyAltToolStripMenuItem
            // 
            this.modifyAltToolStripMenuItem.Name = "modifyAltToolStripMenuItem";
            resources.ApplyResources(this.modifyAltToolStripMenuItem, "modifyAltToolStripMenuItem");
            this.modifyAltToolStripMenuItem.Click += new System.EventHandler(this.modifyAltToolStripMenuItem_Click);
            // 
            // enterUTMCoordToolStripMenuItem
            // 
            this.enterUTMCoordToolStripMenuItem.Name = "enterUTMCoordToolStripMenuItem";
            resources.ApplyResources(this.enterUTMCoordToolStripMenuItem, "enterUTMCoordToolStripMenuItem");
            this.enterUTMCoordToolStripMenuItem.Click += new System.EventHandler(this.enterUTMCoordToolStripMenuItem_Click);
            // 
            // switchDockingToolStripMenuItem
            // 
            this.switchDockingToolStripMenuItem.Name = "switchDockingToolStripMenuItem";
            resources.ApplyResources(this.switchDockingToolStripMenuItem, "switchDockingToolStripMenuItem");
            this.switchDockingToolStripMenuItem.Click += new System.EventHandler(this.switchDockingToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.NUM_repttime);
            this.groupBox3.Controls.Add(this.num_reptpwm);
            this.groupBox3.Controls.Add(this.NUM_reptservo);
            this.groupBox3.Controls.Add(this.rad_digicam);
            this.groupBox3.Controls.Add(this.rad_repeatservo);
            this.groupBox3.Controls.Add(this.rad_trigdist);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // NUM_repttime
            // 
            resources.ApplyResources(this.NUM_repttime, "NUM_repttime");
            this.NUM_repttime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NUM_repttime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUM_repttime.Name = "NUM_repttime";
            this.NUM_repttime.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // num_reptpwm
            // 
            resources.ApplyResources(this.num_reptpwm, "num_reptpwm");
            this.num_reptpwm.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.num_reptpwm.Name = "num_reptpwm";
            this.num_reptpwm.Value = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            // 
            // NUM_reptservo
            // 
            resources.ApplyResources(this.NUM_reptservo, "NUM_reptservo");
            this.NUM_reptservo.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NUM_reptservo.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUM_reptservo.Name = "NUM_reptservo";
            this.NUM_reptservo.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // rad_digicam
            // 
            resources.ApplyResources(this.rad_digicam, "rad_digicam");
            this.rad_digicam.Name = "rad_digicam";
            this.rad_digicam.Tag = "";
            this.rad_digicam.UseVisualStyleBackColor = true;
            // 
            // rad_repeatservo
            // 
            resources.ApplyResources(this.rad_repeatservo, "rad_repeatservo");
            this.rad_repeatservo.Name = "rad_repeatservo";
            this.rad_repeatservo.Tag = "";
            this.rad_repeatservo.UseVisualStyleBackColor = true;
            // 
            // rad_trigdist
            // 
            resources.ApplyResources(this.rad_trigdist, "rad_trigdist");
            this.rad_trigdist.Checked = true;
            this.rad_trigdist.Name = "rad_trigdist";
            this.rad_trigdist.TabStop = true;
            this.rad_trigdist.Tag = "";
            this.rad_trigdist.UseVisualStyleBackColor = true;
            // 
            // panelBASE
            // 
            this.panelBASE.Controls.Add(this.StatsPanel);
            this.panelBASE.Controls.Add(this.splitter2);
            this.panelBASE.Controls.Add(this.splitter1);
            this.panelBASE.Controls.Add(this.panelMap);
            this.panelBASE.Controls.Add(this.panelWaypoints);
            this.panelBASE.Controls.Add(this.panelAction);
            this.panelBASE.Controls.Add(this.label6);
            this.panelBASE.Controls.Add(this.panel6);
            resources.ApplyResources(this.panelBASE, "panelBASE");
            this.panelBASE.Name = "panelBASE";
            // 
            // StatsPanel
            // 
            this.StatsPanel.AssociatedSplitter = this.splitter1;
            this.StatsPanel.BackColor = System.Drawing.Color.Transparent;
            this.StatsPanel.CaptionFont = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.StatsPanel.CaptionHeight = 21;
            this.StatsPanel.ColorScheme = BSE.Windows.Forms.ColorScheme.Custom;
            this.StatsPanel.Controls.Add(this.flowLayoutPanel3);
            this.StatsPanel.CustomColors.BorderColor = System.Drawing.Color.Black;
            this.StatsPanel.CustomColors.CaptionCloseIcon = System.Drawing.Color.White;
            this.StatsPanel.CustomColors.CaptionExpandIcon = System.Drawing.Color.White;
            this.StatsPanel.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.StatsPanel.CustomColors.CaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(226)))), ((int)(((byte)(150)))));
            this.StatsPanel.CustomColors.CaptionGradientMiddle = System.Drawing.Color.Transparent;
            this.StatsPanel.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.Transparent;
            this.StatsPanel.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.Transparent;
            this.StatsPanel.CustomColors.CaptionText = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.StatsPanel.CustomColors.CollapsedCaptionText = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.StatsPanel.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.StatsPanel.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StatsPanel.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.StatsPanel, "StatsPanel");
            this.StatsPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StatsPanel.Image = null;
            this.StatsPanel.Name = "StatsPanel";
            this.StatsPanel.ShowExpandIcon = true;
            this.StatsPanel.ToolTipTextCloseIcon = null;
            this.StatsPanel.ToolTipTextExpandIconPanelCollapsed = null;
            this.StatsPanel.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.groupBox5);
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panel9);
            this.groupBox5.Controls.Add(this.panel8);
            this.groupBox5.Controls.Add(this.lbl_altitude);
            this.groupBox5.Controls.Add(this.lbl_photoevery);
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Controls.Add(this.lbl_flighttime);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.lbl_distbetweenlines);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.lbl_footprint);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.lbl_strips);
            this.groupBox5.Controls.Add(this.lbl_pictures);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.label34);
            this.groupBox5.Controls.Add(this.lbl_spacing);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.lbl_area);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label22);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.AssociatedSplitter = null;
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.CaptionFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.panel9.CaptionHeight = 27;
            this.panel9.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panel9.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panel9.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panel9.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel9.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panel9.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel9.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panel9.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panel9.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.panel9.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.panel9.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panel9.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel9.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panel9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel9.Image = null;
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            this.panel9.ToolTipTextCloseIcon = null;
            this.panel9.ToolTipTextExpandIconPanelCollapsed = null;
            this.panel9.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.myButton1);
            this.panel8.Controls.Add(this.myButton3);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // myButton1
            // 
            resources.ApplyResources(this.myButton1, "myButton1");
            this.myButton1.Name = "myButton1";
            this.myButton1.UseVisualStyleBackColor = true;
            // 
            // myButton3
            // 
            resources.ApplyResources(this.myButton3, "myButton3");
            this.myButton3.Name = "myButton3";
            this.myButton3.UseVisualStyleBackColor = true;
            // 
            // lbl_altitude
            // 
            resources.ApplyResources(this.lbl_altitude, "lbl_altitude");
            this.lbl_altitude.Name = "lbl_altitude";
            // 
            // lbl_photoevery
            // 
            resources.ApplyResources(this.lbl_photoevery, "lbl_photoevery");
            this.lbl_photoevery.Name = "lbl_photoevery";
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.Name = "label35";
            // 
            // lbl_flighttime
            // 
            resources.ApplyResources(this.lbl_flighttime, "lbl_flighttime");
            this.lbl_flighttime.Name = "lbl_flighttime";
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
            // 
            // lbl_distbetweenlines
            // 
            resources.ApplyResources(this.lbl_distbetweenlines, "lbl_distbetweenlines");
            this.lbl_distbetweenlines.Name = "lbl_distbetweenlines";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // lbl_footprint
            // 
            resources.ApplyResources(this.lbl_footprint, "lbl_footprint");
            this.lbl_footprint.Name = "lbl_footprint";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // lbl_strips
            // 
            resources.ApplyResources(this.lbl_strips, "lbl_strips");
            this.lbl_strips.Name = "lbl_strips";
            // 
            // lbl_pictures
            // 
            resources.ApplyResources(this.lbl_pictures, "lbl_pictures");
            this.lbl_pictures.Name = "lbl_pictures";
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.Name = "label34";
            // 
            // lbl_spacing
            // 
            resources.ApplyResources(this.lbl_spacing, "lbl_spacing");
            this.lbl_spacing.Name = "lbl_spacing";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // lbl_area
            // 
            resources.ApplyResources(this.lbl_area, "lbl_area");
            this.lbl_area.Name = "lbl_area";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // panelAction
            // 
            this.panelAction.AssociatedSplitter = this.splitter2;
            this.panelAction.BackColor = System.Drawing.Color.Transparent;
            this.panelAction.CaptionFont = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.panelAction.CaptionHeight = 21;
            this.panelAction.ColorScheme = BSE.Windows.Forms.ColorScheme.Custom;
            this.panelAction.Controls.Add(this.flowLayoutPanel1);
            this.panelAction.CustomColors.BorderColor = System.Drawing.Color.Black;
            this.panelAction.CustomColors.CaptionCloseIcon = System.Drawing.Color.White;
            this.panelAction.CustomColors.CaptionExpandIcon = System.Drawing.Color.White;
            this.panelAction.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.panelAction.CustomColors.CaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(226)))), ((int)(((byte)(150)))));
            this.panelAction.CustomColors.CaptionGradientMiddle = System.Drawing.Color.Transparent;
            this.panelAction.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.Transparent;
            this.panelAction.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.Transparent;
            this.panelAction.CustomColors.CaptionText = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.panelAction.CustomColors.CollapsedCaptionText = System.Drawing.Color.White;
            this.panelAction.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panelAction.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelAction.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.panelAction, "panelAction");
            this.panelAction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelAction.Image = null;
            this.panelAction.Name = "panelAction";
            this.panelAction.ShowExpandIcon = true;
            this.panelAction.ToolTipTextCloseIcon = null;
            this.panelAction.ToolTipTextExpandIconPanelCollapsed = null;
            this.panelAction.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.coords1);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BUT_Launch_Wizard);
            this.panel4.Controls.Add(this.BUT_startMission);
            this.panel4.Controls.Add(this.myButton2);
            this.panel4.Controls.Add(this.Survey_Grid);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // BUT_startMission
            // 
            resources.ApplyResources(this.BUT_startMission, "BUT_startMission");
            this.BUT_startMission.Name = "BUT_startMission";
            this.toolTip1.SetToolTip(this.BUT_startMission, resources.GetString("BUT_startMission.ToolTip"));
            this.BUT_startMission.UseVisualStyleBackColor = true;
            this.BUT_startMission.Click += new System.EventHandler(this.BUT_startMission_Click);
            // 
            // myButton2
            // 
            resources.ApplyResources(this.myButton2, "myButton2");
            this.myButton2.Name = "myButton2";
            this.toolTip1.SetToolTip(this.myButton2, resources.GetString("myButton2.ToolTip"));
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // Survey_Grid
            // 
            resources.ApplyResources(this.Survey_Grid, "Survey_Grid");
            this.Survey_Grid.Name = "Survey_Grid";
            this.Survey_Grid.UseVisualStyleBackColor = true;
            this.Survey_Grid.Click += new System.EventHandler(this.Survey_Grid_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chk_grid);
            this.panel3.Controls.Add(this.lbl_status);
            this.panel3.Controls.Add(this.comboBoxMapType);
            this.panel3.Controls.Add(this.lnk_kml);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // chk_grid
            // 
            resources.ApplyResources(this.chk_grid, "chk_grid");
            this.chk_grid.Name = "chk_grid";
            this.chk_grid.UseVisualStyleBackColor = true;
            this.chk_grid.CheckedChanged += new System.EventHandler(this.chk_grid_CheckedChanged);
            // 
            // lbl_status
            // 
            resources.ApplyResources(this.lbl_status, "lbl_status");
            this.lbl_status.Name = "lbl_status";
            // 
            // comboBoxMapType
            // 
            this.comboBoxMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMapType.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxMapType, "comboBoxMapType");
            this.comboBoxMapType.Name = "comboBoxMapType";
            this.toolTip1.SetToolTip(this.comboBoxMapType, resources.GetString("comboBoxMapType.ToolTip"));
            // 
            // lnk_kml
            // 
            resources.ApplyResources(this.lnk_kml, "lnk_kml");
            this.lnk_kml.Name = "lnk_kml";
            this.lnk_kml.TabStop = true;
            this.lnk_kml.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_kml_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_wpfile);
            this.panel2.Controls.Add(this.BUT_loadwpfile);
            this.panel2.Controls.Add(this.BUT_saveWPFile);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lbl_wpfile
            // 
            resources.ApplyResources(this.lbl_wpfile, "lbl_wpfile");
            this.lbl_wpfile.Name = "lbl_wpfile";
            // 
            // BUT_loadwpfile
            // 
            resources.ApplyResources(this.BUT_loadwpfile, "BUT_loadwpfile");
            this.BUT_loadwpfile.Name = "BUT_loadwpfile";
            this.BUT_loadwpfile.UseVisualStyleBackColor = true;
            this.BUT_loadwpfile.Click += new System.EventHandler(this.BUT_loadwpfile_Click);
            // 
            // BUT_saveWPFile
            // 
            resources.ApplyResources(this.BUT_saveWPFile, "BUT_saveWPFile");
            this.BUT_saveWPFile.Name = "BUT_saveWPFile";
            this.BUT_saveWPFile.UseVisualStyleBackColor = true;
            this.BUT_saveWPFile.Click += new System.EventHandler(this.BUT_saveWPFile_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BUT_write);
            this.panel5.Controls.Add(this.BUT_read);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // BUT_write
            // 
            resources.ApplyResources(this.BUT_write, "BUT_write");
            this.BUT_write.Name = "BUT_write";
            this.BUT_write.UseVisualStyleBackColor = true;
            this.BUT_write.Click += new System.EventHandler(this.BUT_write_Click);
            // 
            // BUT_read
            // 
            resources.ApplyResources(this.BUT_read, "BUT_read");
            this.BUT_read.Name = "BUT_read";
            this.BUT_read.UseVisualStyleBackColor = true;
            this.BUT_read.Click += new System.EventHandler(this.BUT_read_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.TXT_homealt);
            this.panel1.Controls.Add(this.TXT_homelng);
            this.panel1.Controls.Add(this.TXT_homelat);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.TabStop = true;
            this.label4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label4_LinkClicked);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // TXT_homealt
            // 
            resources.ApplyResources(this.TXT_homealt, "TXT_homealt");
            this.TXT_homealt.Name = "TXT_homealt";
            this.TXT_homealt.TextChanged += new System.EventHandler(this.TXT_homealt_TextChanged);
            // 
            // TXT_homelng
            // 
            resources.ApplyResources(this.TXT_homelng, "TXT_homelng");
            this.TXT_homelng.Name = "TXT_homelng";
            this.TXT_homelng.TextChanged += new System.EventHandler(this.TXT_homelng_TextChanged);
            // 
            // TXT_homelat
            // 
            resources.ApplyResources(this.TXT_homelat, "TXT_homelat");
            this.TXT_homelat.Name = "TXT_homelat";
            this.TXT_homelat.TextChanged += new System.EventHandler(this.TXT_homelat_TextChanged);
            this.TXT_homelat.Enter += new System.EventHandler(this.TXT_homelat_Enter);
            // 
            // coords1
            // 
            this.coords1.Alt = 0D;
            this.coords1.Lat = 0D;
            this.coords1.Lng = 0D;
            resources.ApplyResources(this.coords1, "coords1");
            this.coords1.Name = "coords1";
            this.coords1.Vertical = true;
            // 
            // panel6
            // 
            this.panel6.AssociatedSplitter = this.splitter2;
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.CaptionFont = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.panel6.CaptionHeight = 21;
            this.panel6.ColorScheme = BSE.Windows.Forms.ColorScheme.Custom;
            this.panel6.Controls.Add(this.flowLayoutPanel2);
            this.panel6.CustomColors.BorderColor = System.Drawing.Color.Black;
            this.panel6.CustomColors.CaptionCloseIcon = System.Drawing.Color.White;
            this.panel6.CustomColors.CaptionExpandIcon = System.Drawing.Color.White;
            this.panel6.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.panel6.CustomColors.CaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(226)))), ((int)(((byte)(150)))));
            this.panel6.CustomColors.CaptionGradientMiddle = System.Drawing.Color.Transparent;
            this.panel6.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.Transparent;
            this.panel6.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.Transparent;
            this.panel6.CustomColors.CaptionText = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.panel6.CustomColors.CollapsedCaptionText = System.Drawing.Color.White;
            this.panel6.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panel6.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel6.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Image = null;
            this.panel6.Name = "panel6";
            this.panel6.ShowExpandIcon = true;
            this.panel6.ToolTipTextCloseIcon = null;
            this.panel6.ToolTipTextExpandIconPanelCollapsed = null;
            this.panel6.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel7);
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tabControl1);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSimple);
            this.tabControl1.Controls.Add(this.tabCamera);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabSimple
            // 
            this.tabSimple.Controls.Add(this.groupBox6);
            this.tabSimple.Controls.Add(this.groupBox4);
            resources.ApplyResources(this.tabSimple, "tabSimple");
            this.tabSimple.Name = "tabSimple";
            this.tabSimple.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.TXT_overlap);
            this.groupBox6.Controls.Add(this.Decline);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.BUT_Accept);
            this.groupBox6.Controls.Add(this.label36);
            this.groupBox6.Controls.Add(this.label45);
            this.groupBox6.Controls.Add(this.CHK_toandland_RTL);
            this.groupBox6.Controls.Add(this.label44);
            this.groupBox6.Controls.Add(this.CHK_toandland);
            this.groupBox6.Controls.Add(this.label43);
            this.groupBox6.Controls.Add(this.TBAR_overlap);
            this.groupBox6.Controls.Add(this.label37);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.TBAR_zoom);
            this.groupBox6.Controls.Add(this.TXT_cmpixel);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // TXT_overlap
            // 
            this.TXT_overlap.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.TXT_overlap, "TXT_overlap");
            this.TXT_overlap.Name = "TXT_overlap";
            // 
            // Decline
            // 
            resources.ApplyResources(this.Decline, "Decline");
            this.Decline.Name = "Decline";
            this.Decline.UseVisualStyleBackColor = true;
            this.Decline.Click += new System.EventHandler(this.Decline_Click);
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // BUT_Accept
            // 
            resources.ApplyResources(this.BUT_Accept, "BUT_Accept");
            this.BUT_Accept.Name = "BUT_Accept";
            this.BUT_Accept.UseVisualStyleBackColor = true;
            this.BUT_Accept.Click += new System.EventHandler(this.BUT_Accept_Click);
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.Name = "label36";
            // 
            // label45
            // 
            resources.ApplyResources(this.label45, "label45");
            this.label45.Name = "label45";
            // 
            // CHK_toandland_RTL
            // 
            resources.ApplyResources(this.CHK_toandland_RTL, "CHK_toandland_RTL");
            this.CHK_toandland_RTL.Checked = true;
            this.CHK_toandland_RTL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_toandland_RTL.Name = "CHK_toandland_RTL";
            this.CHK_toandland_RTL.UseVisualStyleBackColor = true;
            // 
            // label44
            // 
            resources.ApplyResources(this.label44, "label44");
            this.label44.Name = "label44";
            // 
            // CHK_toandland
            // 
            resources.ApplyResources(this.CHK_toandland, "CHK_toandland");
            this.CHK_toandland.Checked = true;
            this.CHK_toandland.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_toandland.Name = "CHK_toandland";
            this.CHK_toandland.UseVisualStyleBackColor = true;
            // 
            // label43
            // 
            resources.ApplyResources(this.label43, "label43");
            this.label43.Name = "label43";
            // 
            // TBAR_overlap
            // 
            resources.ApplyResources(this.TBAR_overlap, "TBAR_overlap");
            this.TBAR_overlap.LargeChange = 20;
            this.TBAR_overlap.Maximum = 80;
            this.TBAR_overlap.Name = "TBAR_overlap";
            this.TBAR_overlap.TickFrequency = 5;
            this.TBAR_overlap.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TBAR_overlap.Value = 30;
            this.TBAR_overlap.Scroll += new System.EventHandler(this.TBAR_overlap_Scroll);
            // 
            // label37
            // 
            resources.ApplyResources(this.label37, "label37");
            this.label37.Name = "label37";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // TBAR_zoom
            // 
            resources.ApplyResources(this.TBAR_zoom, "TBAR_zoom");
            this.TBAR_zoom.Maximum = 500;
            this.TBAR_zoom.Minimum = 50;
            this.TBAR_zoom.Name = "TBAR_zoom";
            this.TBAR_zoom.SmallChange = 10;
            this.TBAR_zoom.TickFrequency = 5;
            this.TBAR_zoom.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TBAR_zoom.Value = 100;
            this.TBAR_zoom.Scroll += new System.EventHandler(this.domainUpDown1_ValueChanged);
            // 
            // TXT_cmpixel
            // 
            this.TXT_cmpixel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.TXT_cmpixel, "TXT_cmpixel");
            this.TXT_cmpixel.Name = "TXT_cmpixel";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CHK_footprints);
            this.groupBox4.Controls.Add(this.CHK_internals);
            this.groupBox4.Controls.Add(this.CHK_grid1);
            this.groupBox4.Controls.Add(this.CHK_markers);
            this.groupBox4.Controls.Add(this.CHK_boundary);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // CHK_footprints
            // 
            resources.ApplyResources(this.CHK_footprints, "CHK_footprints");
            this.CHK_footprints.Name = "CHK_footprints";
            this.CHK_footprints.UseVisualStyleBackColor = true;
            this.CHK_footprints.CheckedChanged += new System.EventHandler(this.domainUpDown1_ValueChanged);
            // 
            // CHK_internals
            // 
            resources.ApplyResources(this.CHK_internals, "CHK_internals");
            this.CHK_internals.Name = "CHK_internals";
            this.CHK_internals.UseVisualStyleBackColor = true;
            this.CHK_internals.CheckedChanged += new System.EventHandler(this.domainUpDown1_ValueChanged);
            // 
            // CHK_grid1
            // 
            resources.ApplyResources(this.CHK_grid1, "CHK_grid1");
            this.CHK_grid1.Checked = true;
            this.CHK_grid1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_grid1.Name = "CHK_grid1";
            this.CHK_grid1.UseVisualStyleBackColor = true;
            this.CHK_grid1.CheckedChanged += new System.EventHandler(this.domainUpDown1_ValueChanged);
            // 
            // CHK_markers
            // 
            resources.ApplyResources(this.CHK_markers, "CHK_markers");
            this.CHK_markers.Checked = true;
            this.CHK_markers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_markers.Name = "CHK_markers";
            this.CHK_markers.UseVisualStyleBackColor = true;
            this.CHK_markers.CheckedChanged += new System.EventHandler(this.domainUpDown1_ValueChanged);
            // 
            // CHK_boundary
            // 
            resources.ApplyResources(this.CHK_boundary, "CHK_boundary");
            this.CHK_boundary.Checked = true;
            this.CHK_boundary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_boundary.Name = "CHK_boundary";
            this.CHK_boundary.UseVisualStyleBackColor = true;
            this.CHK_boundary.CheckedChanged += new System.EventHandler(this.domainUpDown1_ValueChanged);
            // 
            // tabCamera
            // 
            this.tabCamera.Controls.Add(this.groupBox8);
            this.tabCamera.Controls.Add(this.groupBox3);
            this.tabCamera.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabCamera, "tabCamera");
            this.tabCamera.Name = "tabCamera";
            this.tabCamera.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.NUM_UpDownFlySpeed);
            this.groupBox8.Controls.Add(this.TXT_max_flight_time);
            this.groupBox8.Controls.Add(this.TXT_max_dive_angle);
            this.groupBox8.Controls.Add(this.TXT_max_climb_angle);
            this.groupBox8.Controls.Add(this.TXT_turn_radius);
            this.groupBox8.Controls.Add(this.TXT_max_alt);
            this.groupBox8.Controls.Add(this.TXT_min_alt);
            this.groupBox8.Controls.Add(this.label42);
            this.groupBox8.Controls.Add(this.label41);
            this.groupBox8.Controls.Add(this.label40);
            this.groupBox8.Controls.Add(this.label39);
            this.groupBox8.Controls.Add(this.label38);
            this.groupBox8.Controls.Add(this.label29);
            this.groupBox8.Controls.Add(this.label21);
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            // 
            // NUM_UpDownFlySpeed
            // 
            resources.ApplyResources(this.NUM_UpDownFlySpeed, "NUM_UpDownFlySpeed");
            this.NUM_UpDownFlySpeed.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.NUM_UpDownFlySpeed.Name = "NUM_UpDownFlySpeed";
            this.NUM_UpDownFlySpeed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUM_UpDownFlySpeed.ValueChanged += new System.EventHandler(this.domainUpDown1_ValueChanged);
            // 
            // TXT_max_flight_time
            // 
            resources.ApplyResources(this.TXT_max_flight_time, "TXT_max_flight_time");
            this.TXT_max_flight_time.Name = "TXT_max_flight_time";
            // 
            // TXT_max_dive_angle
            // 
            resources.ApplyResources(this.TXT_max_dive_angle, "TXT_max_dive_angle");
            this.TXT_max_dive_angle.Name = "TXT_max_dive_angle";
            // 
            // TXT_max_climb_angle
            // 
            resources.ApplyResources(this.TXT_max_climb_angle, "TXT_max_climb_angle");
            this.TXT_max_climb_angle.Name = "TXT_max_climb_angle";
            // 
            // TXT_turn_radius
            // 
            resources.ApplyResources(this.TXT_turn_radius, "TXT_turn_radius");
            this.TXT_turn_radius.Name = "TXT_turn_radius";
            this.TXT_turn_radius.TextChanged += new System.EventHandler(this.domainUpDown1_ValueChanged);
            // 
            // TXT_max_alt
            // 
            resources.ApplyResources(this.TXT_max_alt, "TXT_max_alt");
            this.TXT_max_alt.Name = "TXT_max_alt";
            this.TXT_max_alt.TextChanged += new System.EventHandler(this.TXT_max_alt_TextChanged);
            // 
            // TXT_min_alt
            // 
            resources.ApplyResources(this.TXT_min_alt, "TXT_min_alt");
            this.TXT_min_alt.Name = "TXT_min_alt";
            this.TXT_min_alt.TextChanged += new System.EventHandler(this.TXT_min_alt_TextChanged);
            // 
            // label42
            // 
            resources.ApplyResources(this.label42, "label42");
            this.label42.Name = "label42";
            // 
            // label41
            // 
            resources.ApplyResources(this.label41, "label41");
            this.label41.Name = "label41";
            // 
            // label40
            // 
            resources.ApplyResources(this.label40, "label40");
            this.label40.Name = "label40";
            // 
            // label39
            // 
            resources.ApplyResources(this.label39, "label39");
            this.label39.Name = "label39";
            // 
            // label38
            // 
            resources.ApplyResources(this.label38, "label38");
            this.label38.Name = "label38";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.myLabel1);
            this.groupBox2.Controls.Add(this.RadioLandspace);
            this.groupBox2.Controls.Add(this.RadioPortrait);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TXT_sensheight);
            this.groupBox2.Controls.Add(this.TXT_senswidth);
            this.groupBox2.Controls.Add(this.TXT_imgheight);
            this.groupBox2.Controls.Add(this.TXT_imgwidth);
            this.groupBox2.Controls.Add(this.NUM_focallength);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // myLabel1
            // 
            resources.ApplyResources(this.myLabel1, "myLabel1");
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.resize = false;
            // 
            // RadioLandspace
            // 
            resources.ApplyResources(this.RadioLandspace, "RadioLandspace");
            this.RadioLandspace.Name = "RadioLandspace";
            this.RadioLandspace.UseVisualStyleBackColor = true;
            this.RadioLandspace.CheckedChanged += new System.EventHandler(this.domainUpDown1_ValueChanged);
            // 
            // RadioPortrait
            // 
            resources.ApplyResources(this.RadioPortrait, "RadioPortrait");
            this.RadioPortrait.Checked = true;
            this.RadioPortrait.Name = "RadioPortrait";
            this.RadioPortrait.TabStop = true;
            this.RadioPortrait.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // TXT_sensheight
            // 
            resources.ApplyResources(this.TXT_sensheight, "TXT_sensheight");
            this.TXT_sensheight.Name = "TXT_sensheight";
            this.TXT_sensheight.TextChanged += new System.EventHandler(this.NUM_ValueChanged);
            // 
            // TXT_senswidth
            // 
            resources.ApplyResources(this.TXT_senswidth, "TXT_senswidth");
            this.TXT_senswidth.Name = "TXT_senswidth";
            this.TXT_senswidth.TextChanged += new System.EventHandler(this.NUM_ValueChanged);
            // 
            // TXT_imgheight
            // 
            resources.ApplyResources(this.TXT_imgheight, "TXT_imgheight");
            this.TXT_imgheight.Name = "TXT_imgheight";
            this.TXT_imgheight.TextChanged += new System.EventHandler(this.NUM_ValueChanged);
            // 
            // TXT_imgwidth
            // 
            resources.ApplyResources(this.TXT_imgwidth, "TXT_imgwidth");
            this.TXT_imgwidth.Name = "TXT_imgwidth";
            this.TXT_imgwidth.TextChanged += new System.EventHandler(this.NUM_ValueChanged);
            // 
            // NUM_focallength
            // 
            this.NUM_focallength.DecimalPlaces = 1;
            this.NUM_focallength.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            resources.ApplyResources(this.NUM_focallength, "NUM_focallength");
            this.NUM_focallength.Maximum = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.NUM_focallength.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.NUM_focallength.Name = "NUM_focallength";
            this.NUM_focallength.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NUM_focallength.ValueChanged += new System.EventHandler(this.domainUpDown1_ValueChanged);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // CHK_usespeed
            // 
            resources.ApplyResources(this.CHK_usespeed, "CHK_usespeed");
            this.CHK_usespeed.Name = "CHK_usespeed";
            this.CHK_usespeed.UseVisualStyleBackColor = true;
            // 
            // BUT_samplephoto
            // 
            resources.ApplyResources(this.BUT_samplephoto, "BUT_samplephoto");
            this.BUT_samplephoto.Name = "BUT_samplephoto";
            this.BUT_samplephoto.UseVisualStyleBackColor = true;
            // 
            // BUT_save
            // 
            resources.ApplyResources(this.BUT_save, "BUT_save");
            this.BUT_save.Name = "BUT_save";
            this.BUT_save.UseVisualStyleBackColor = true;
            this.BUT_save.Click += new System.EventHandler(this.BUT_save_Click);
            // 
            // CHK_advanced
            // 
            resources.ApplyResources(this.CHK_advanced, "CHK_advanced");
            this.CHK_advanced.Checked = true;
            this.CHK_advanced.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_advanced.Name = "CHK_advanced";
            this.CHK_advanced.UseVisualStyleBackColor = true;
            this.CHK_advanced.CheckedChanged += new System.EventHandler(this.CHK_advanced_CheckedChanged);
            // 
            // CMB_camera
            // 
            this.CMB_camera.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_camera, "CMB_camera");
            this.CMB_camera.Name = "CMB_camera";
            this.CMB_camera.SelectedIndexChanged += new System.EventHandler(this.CMB_camera_SelectedIndexChanged);
            // 
            // tabGrid
            // 
            this.tabGrid.Controls.Add(this.groupBox_copter);
            resources.ApplyResources(this.tabGrid, "tabGrid");
            this.tabGrid.Name = "tabGrid";
            this.tabGrid.UseVisualStyleBackColor = true;
            // 
            // groupBox_copter
            // 
            this.groupBox_copter.Controls.Add(this.label15);
            this.groupBox_copter.Controls.Add(this.CHK_copter_headinghold);
            this.groupBox_copter.Controls.Add(this.TXT_headinghold);
            this.groupBox_copter.Controls.Add(this.CHK_copter_headingholdlock);
            this.groupBox_copter.Controls.Add(this.NUM_copter_delay);
            this.groupBox_copter.Controls.Add(this.BUT_headingholdplus);
            this.groupBox_copter.Controls.Add(this.BUT_headingholdminus);
            resources.ApplyResources(this.groupBox_copter, "groupBox_copter");
            this.groupBox_copter.Name = "groupBox_copter";
            this.groupBox_copter.TabStop = false;
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // CHK_copter_headinghold
            // 
            resources.ApplyResources(this.CHK_copter_headinghold, "CHK_copter_headinghold");
            this.CHK_copter_headinghold.Name = "CHK_copter_headinghold";
            this.CHK_copter_headinghold.UseVisualStyleBackColor = true;
            // 
            // TXT_headinghold
            // 
            resources.ApplyResources(this.TXT_headinghold, "TXT_headinghold");
            this.TXT_headinghold.Name = "TXT_headinghold";
            this.TXT_headinghold.ReadOnly = true;
            // 
            // CHK_copter_headingholdlock
            // 
            resources.ApplyResources(this.CHK_copter_headingholdlock, "CHK_copter_headingholdlock");
            this.CHK_copter_headingholdlock.Name = "CHK_copter_headingholdlock";
            this.CHK_copter_headingholdlock.UseVisualStyleBackColor = true;
            // 
            // NUM_copter_delay
            // 
            this.NUM_copter_delay.DecimalPlaces = 1;
            this.NUM_copter_delay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            resources.ApplyResources(this.NUM_copter_delay, "NUM_copter_delay");
            this.NUM_copter_delay.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUM_copter_delay.Name = "NUM_copter_delay";
            // 
            // BUT_headingholdplus
            // 
            resources.ApplyResources(this.BUT_headingholdplus, "BUT_headingholdplus");
            this.BUT_headingholdplus.Name = "BUT_headingholdplus";
            this.BUT_headingholdplus.UseVisualStyleBackColor = true;
            // 
            // BUT_headingholdminus
            // 
            resources.ApplyResources(this.BUT_headingholdminus, "BUT_headingholdminus");
            this.BUT_headingholdminus.Name = "BUT_headingholdminus";
            this.BUT_headingholdminus.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CHK_camdirection
            // 
            resources.ApplyResources(this.CHK_camdirection, "CHK_camdirection");
            this.CHK_camdirection.Checked = true;
            this.CHK_camdirection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_camdirection.Name = "CHK_camdirection";
            this.CHK_camdirection.UseVisualStyleBackColor = true;
            // 
            // BUT_Launch_Wizard
            // 
            resources.ApplyResources(this.BUT_Launch_Wizard, "BUT_Launch_Wizard");
            this.BUT_Launch_Wizard.Name = "BUT_Launch_Wizard";
            this.BUT_Launch_Wizard.UseVisualStyleBackColor = true;
            this.BUT_Launch_Wizard.Click += new System.EventHandler(this.BUT_Launch_Wizard_Click);
            // 
            // FlightPlanner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelBASE);
            resources.ApplyResources(this, "$this");
            this.Name = "FlightPlanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightPlanner_FormClosing);
            this.Load += new System.EventHandler(this.Planner_Load);
            this.Resize += new System.EventHandler(this.Planner_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Commands)).EndInit();
            this.panelWaypoints.ResumeLayout(false);
            this.panelWaypoints.PerformLayout();
            this.panelMap.ResumeLayout(false);
            this.panelMap.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BUT_Rect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BUT_removePoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUT_Polygon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUT_GreenZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUT_removePolygon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUT_RedZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUT_Waypoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_repttime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_reptpwm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_reptservo)).EndInit();
            this.panelBASE.ResumeLayout(false);
            this.StatsPanel.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panelAction.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabSimple.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBAR_overlap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAR_zoom)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabCamera.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_UpDownFlySpeed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_focallength)).EndInit();
            this.tabGrid.ResumeLayout(false);
            this.groupBox_copter.ResumeLayout(false);
            this.groupBox_copter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_copter_delay)).EndInit();
            this.ResumeLayout(false);

         }


         #endregion

         private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
         private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
         private System.Windows.Forms.Label label6;
         private System.Windows.Forms.DataGridView Commands;
         private System.Windows.Forms.CheckBox CHK_verifyheight;
         private Controls.MyButton BUT_Add;
         private System.Windows.Forms.TextBox TXT_WPRad;
         private System.Windows.Forms.TextBox TXT_DefaultAlt;
         private System.Windows.Forms.Label LBL_WPRad;
         private System.Windows.Forms.Label LBL_defalutalt;
         private System.Windows.Forms.TextBox TXT_loiterrad;
         private System.Windows.Forms.Label label5;
         private BSE.Windows.Forms.Panel panelWaypoints;
         private System.Windows.Forms.Panel panelMap;
         private Controls.myGMAP MainMap;
         private System.Windows.Forms.Label label11;
         private System.Windows.Forms.Label lbl_distance;
         private System.Windows.Forms.Label lbl_prevdist;
         private BSE.Windows.Forms.Splitter splitter1;
         private System.Windows.Forms.Panel panelBASE;
         private System.Windows.Forms.Label lbl_homedist;
         private System.Windows.Forms.ToolTip toolTip1;
         private System.Windows.Forms.ToolStripMenuItem clearMissionToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem addPolygonPointToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem clearPolygonToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem loiterToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem loiterForeverToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem loitertimeToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem loitercirclesToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem jumpToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem jumpstartToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem jumpwPToolStripMenuItem;
         private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
         private System.Windows.Forms.ToolStripMenuItem deleteWPToolStripMenuItem;
         private System.Windows.Forms.Timer timer1;
         private System.Windows.Forms.ToolStripMenuItem geoFenceToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem GeoFencedownloadToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem setReturnLocationToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
         private System.Windows.Forms.ToolStripMenuItem GeoFenceuploadToolStripMenuItem;
         private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
         private System.Windows.Forms.ToolStripMenuItem setROIToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem autoWPToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem createWpCircleToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem mapToolToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem ContextMeasure;
         private System.Windows.Forms.ToolStripMenuItem rotateMapToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem zoomToToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem prefetchToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem kMLOverlayToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem elevationGraphToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem rTLToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem landToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem takeoffToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem fileLoadSaveToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem loadWPFileToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem saveWPFileToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem trackerHomeToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem flyToHereToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem reverseWPsToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem loadAndAppendToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem savePolygonToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem loadPolygonToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
         public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
         private System.Windows.Forms.ToolStripMenuItem insertWpToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem rallyPointsToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem getRallyPointsToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem saveRallyPointsToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem setRallyPointToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem clearRallyPointsToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem loadKMLFileToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem modifyAltToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem1;
         private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem1;
         private System.Windows.Forms.ToolStripMenuItem prefetchWPPathToolStripMenuItem;
         private System.Windows.Forms.Label label17;
         private System.Windows.Forms.TextBox TXT_altwarn;
         private System.Windows.Forms.ToolStripMenuItem pOIToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem poiaddToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem poideleteToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem poieditToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem enterUTMCoordToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem loadSHPFileToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem switchDockingToolStripMenuItem;
         private BSE.Windows.Forms.Splitter splitter2;
         private System.Windows.Forms.ToolStripMenuItem insertSplineWPToolStripMenuItem;
         private System.Windows.Forms.CheckBox CHK_splinedefault;
         private System.Windows.Forms.ToolStripMenuItem createSplineCircleToolStripMenuItem;
         private System.Windows.Forms.ComboBox CMB_altmode;
         private System.Windows.Forms.ToolStripMenuItem fromSHPToolStripMenuItem;
         private System.Windows.Forms.DataGridViewComboBoxColumn Command;
         private System.Windows.Forms.DataGridViewTextBoxColumn Param1;
         private System.Windows.Forms.DataGridViewTextBoxColumn Param2;
         private System.Windows.Forms.DataGridViewTextBoxColumn Param3;
         private System.Windows.Forms.DataGridViewTextBoxColumn Param4;
         private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
         private System.Windows.Forms.DataGridViewTextBoxColumn Lon;
         private System.Windows.Forms.DataGridViewTextBoxColumn Alt;
         private System.Windows.Forms.DataGridViewButtonColumn Delete;
         private System.Windows.Forms.DataGridViewImageColumn Up;
         private System.Windows.Forms.DataGridViewImageColumn Down;
         private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
         private System.Windows.Forms.DataGridViewTextBoxColumn Dist;
         private System.Windows.Forms.DataGridViewTextBoxColumn AZ;
         private BSE.Windows.Forms.Panel panelAction;
         private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
         private System.Windows.Forms.Panel panel4;
         private System.Windows.Forms.Panel panel3;
         private System.Windows.Forms.CheckBox chk_grid;
         private System.Windows.Forms.Label lbl_status;
         private System.Windows.Forms.ComboBox comboBoxMapType;
         private System.Windows.Forms.LinkLabel lnk_kml;
         private System.Windows.Forms.Panel panel2;
         private System.Windows.Forms.Label lbl_wpfile;
         private Controls.MyButton BUT_loadwpfile;
         private Controls.MyButton BUT_saveWPFile;
         private System.Windows.Forms.Panel panel5;
         private Controls.MyButton BUT_write;
         private Controls.MyButton BUT_read;
         private System.Windows.Forms.Panel panel1;
         private System.Windows.Forms.LinkLabel label4;
         private System.Windows.Forms.Label label3;
         private System.Windows.Forms.Label label2;
         private System.Windows.Forms.Label Label1;
         private System.Windows.Forms.TextBox TXT_homealt;
         private System.Windows.Forms.TextBox TXT_homelng;
         private System.Windows.Forms.TextBox TXT_homelat;
         private Controls.Coords coords1;
         private Controls.MyTrackBar trackBar1;
         private BSE.Windows.Forms.Panel panel6;
         private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
         private Controls.MyButton Survey_Grid;
         private System.Windows.Forms.Panel panel7;
         private Controls.MyButton BUT_Accept;
         private System.Windows.Forms.TabControl tabControl1;
         private System.Windows.Forms.TabPage tabSimple;
         private System.Windows.Forms.GroupBox groupBox6;
         private System.Windows.Forms.Label label32;
         private System.Windows.Forms.Label label36;
         private System.Windows.Forms.Label label45;
         private System.Windows.Forms.CheckBox CHK_toandland_RTL;
         private System.Windows.Forms.Label label44;
         private System.Windows.Forms.CheckBox CHK_toandland;
         private System.Windows.Forms.Label label43;
         private System.Windows.Forms.TrackBar TBAR_overlap;
         private System.Windows.Forms.ComboBox CMB_camera;
         private System.Windows.Forms.Label label37;
         private System.Windows.Forms.Label label12;
         private System.Windows.Forms.TrackBar TBAR_zoom;
         private System.Windows.Forms.Label TXT_cmpixel;
         private System.Windows.Forms.GroupBox groupBox4;
         private System.Windows.Forms.CheckBox CHK_advanced;
         private System.Windows.Forms.CheckBox CHK_footprints;
         private System.Windows.Forms.CheckBox CHK_internals;
         private System.Windows.Forms.CheckBox CHK_grid1;
         private System.Windows.Forms.CheckBox CHK_markers;
         private System.Windows.Forms.CheckBox CHK_boundary;
         private System.Windows.Forms.TabPage tabCamera;
         private System.Windows.Forms.GroupBox groupBox8;
         private System.Windows.Forms.CheckBox CHK_usespeed;
         private System.Windows.Forms.NumericUpDown NUM_UpDownFlySpeed;
         private System.Windows.Forms.TextBox TXT_max_flight_time;
         private System.Windows.Forms.TextBox TXT_max_dive_angle;
         private System.Windows.Forms.TextBox TXT_max_climb_angle;
         private System.Windows.Forms.TextBox TXT_turn_radius;
         private System.Windows.Forms.TextBox TXT_max_alt;
         private System.Windows.Forms.TextBox TXT_min_alt;
         private System.Windows.Forms.Label label42;
         private System.Windows.Forms.Label label41;
         private System.Windows.Forms.Label label40;
         private System.Windows.Forms.Label label39;
         private System.Windows.Forms.Label label38;
         private System.Windows.Forms.Label label29;
         private System.Windows.Forms.Label label21;
         private System.Windows.Forms.GroupBox groupBox3;
         private System.Windows.Forms.Label label18;
         private System.Windows.Forms.Label label7;
         private System.Windows.Forms.Label label16;
         private System.Windows.Forms.NumericUpDown NUM_repttime;
         private System.Windows.Forms.NumericUpDown num_reptpwm;
         private System.Windows.Forms.NumericUpDown NUM_reptservo;
         private System.Windows.Forms.RadioButton rad_digicam;
         private System.Windows.Forms.RadioButton rad_repeatservo;
         private System.Windows.Forms.RadioButton rad_trigdist;
         private System.Windows.Forms.GroupBox groupBox2;
         private System.Windows.Forms.Label label14;
         private System.Windows.Forms.Label label9;
         private Controls.MyButton BUT_samplephoto;
         private System.Windows.Forms.TextBox TXT_sensheight;
         private System.Windows.Forms.TextBox TXT_senswidth;
         private System.Windows.Forms.TextBox TXT_imgheight;
         private System.Windows.Forms.TextBox TXT_imgwidth;
         private System.Windows.Forms.NumericUpDown NUM_focallength;
         private System.Windows.Forms.Label label10;
         private System.Windows.Forms.Label label13;
         private System.Windows.Forms.Label label8;
         private Controls.MyButton BUT_save;
         private System.Windows.Forms.TabPage tabGrid;
         private System.Windows.Forms.GroupBox groupBox_copter;
         private System.Windows.Forms.Label label15;
         private System.Windows.Forms.CheckBox CHK_copter_headinghold;
         private System.Windows.Forms.TextBox TXT_headinghold;
         private System.Windows.Forms.CheckBox CHK_copter_headingholdlock;
         private System.Windows.Forms.NumericUpDown NUM_copter_delay;
         private System.Windows.Forms.Button BUT_headingholdplus;
         private System.Windows.Forms.Button BUT_headingholdminus;
         private Controls.MyButton Decline;
         private System.Windows.Forms.Label TXT_overlap;
         private System.Windows.Forms.CheckBox CHK_camdirection;
         private System.Windows.Forms.RadioButton RadioPortrait;
         private System.Windows.Forms.RadioButton RadioLandspace;
         private Controls.MyLabel myLabel1;
         private BSE.Windows.Forms.Panel StatsPanel;
         private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
         private System.Windows.Forms.GroupBox groupBox5;
         private System.Windows.Forms.Label lbl_altitude;
         private System.Windows.Forms.Label lbl_photoevery;
         private System.Windows.Forms.Label label35;
         private System.Windows.Forms.Label lbl_flighttime;
         private System.Windows.Forms.Label label31;
         private System.Windows.Forms.Label lbl_distbetweenlines;
         private System.Windows.Forms.Label label19;
         private System.Windows.Forms.Label label25;
         private System.Windows.Forms.Label lbl_footprint;
         private System.Windows.Forms.Label label30;
         private System.Windows.Forms.Label lbl_strips;
         private System.Windows.Forms.Label lbl_pictures;
         private System.Windows.Forms.Label label33;
         private System.Windows.Forms.Label label34;
         private System.Windows.Forms.Label lbl_spacing;
         private System.Windows.Forms.Label label27;
         private System.Windows.Forms.Label label20;
         private System.Windows.Forms.Label lbl_area;
         private System.Windows.Forms.Label label23;
         private System.Windows.Forms.Label label22;
         private Controls.MyButton myButton2;
         private System.Windows.Forms.PictureBox BUT_Rect;
         private System.Windows.Forms.PictureBox pictureBox8;
         private System.Windows.Forms.GroupBox groupBox1;
         private System.Windows.Forms.PictureBox BUT_removePoint;
         private System.Windows.Forms.PictureBox BUT_Polygon;
         private System.Windows.Forms.PictureBox BUT_GreenZone;
         private System.Windows.Forms.PictureBox BUT_removePolygon;
         private System.Windows.Forms.PictureBox BUT_RedZone;
         private System.Windows.Forms.PictureBox BUT_Waypoints;
         private System.Windows.Forms.GroupBox groupBox7;
         private BSE.Windows.Forms.Panel panel9;
         private System.Windows.Forms.Panel panel8;
         private Controls.MyButton myButton1;
         private Controls.MyButton myButton3;
         private Controls.MyButton BUT_startMission;
         public Controls.MyButton BUT_Launch_Wizard;
     }
 }
