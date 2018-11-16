namespace Lab01_DHMT
{
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.selectShape_icon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rotate_lb = new System.Windows.Forms.Label();
            this.Scale_lb = new System.Windows.Forms.Label();
            this.selectShapeLb = new System.Windows.Forms.Label();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.openGLControl = new SharpGL.OpenGLControl();
            this.pnlSize = new System.Windows.Forms.Panel();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.time_icon = new System.Windows.Forms.PictureBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.pnlColors = new System.Windows.Forms.Panel();
            this.pictureColor = new System.Windows.Forms.PictureBox();
            this.lbColors = new System.Windows.Forms.Label();
            this.pnlShape = new System.Windows.Forms.Panel();
            this.polygon_icon = new System.Windows.Forms.PictureBox();
            this.hexagol_icon = new System.Windows.Forms.PictureBox();
            this.rectangle_icon = new System.Windows.Forms.PictureBox();
            this.pentagol_icon = new System.Windows.Forms.PictureBox();
            this.triangle_icon = new System.Windows.Forms.PictureBox();
            this.circle_icon = new System.Windows.Forms.PictureBox();
            this.ellipse_icon = new System.Windows.Forms.PictureBox();
            this.line_icon = new System.Windows.Forms.PictureBox();
            this.lbShape = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.groupName = new System.Windows.Forms.Label();
            this.ptbGroupImage = new System.Windows.Forms.PictureBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolTipLine = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCircle = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEllipse = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRectangle = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTriangle = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPentagon = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHexagon = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSize = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipColor = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipImageGroup = new System.Windows.Forms.ToolTip(this.components);
            this.selectShapett = new System.Windows.Forms.ToolTip(this.components);
            this.licencse = new System.Windows.Forms.ToolTip(this.components);
            this.Polygol = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectShape_icon)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.pnlSize.SuspendLayout();
            this.pnlTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.time_icon)).BeginInit();
            this.pnlColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureColor)).BeginInit();
            this.pnlShape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polygon_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hexagol_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pentagol_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangle_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipse_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_icon)).BeginInit();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGroupImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMain.Controls.Add(this.selectShape_icon);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.pnlDraw);
            this.pnlMain.Controls.Add(this.pnlSize);
            this.pnlMain.Controls.Add(this.pnlTime);
            this.pnlMain.Controls.Add(this.pnlColors);
            this.pnlMain.Controls.Add(this.pnlShape);
            this.pnlMain.Controls.Add(this.pnlControl);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1245, 426);
            this.pnlMain.TabIndex = 0;
            // 
            // selectShape_icon
            // 
            this.selectShape_icon.Image = ((System.Drawing.Image)(resources.GetObject("selectShape_icon.Image")));
            this.selectShape_icon.Location = new System.Drawing.Point(1152, 2);
            this.selectShape_icon.Name = "selectShape_icon";
            this.selectShape_icon.Size = new System.Drawing.Size(86, 83);
            this.selectShape_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectShape_icon.TabIndex = 0;
            this.selectShape_icon.TabStop = false;
            this.licencse.SetToolTip(this.selectShape_icon, "Nope \'s license: Hồng Thanh Hoài, Trần Mạnh Thắng, Huỳnh Hoàng Huy, Huỳnh Minh Hu" +
        "ấn, Võ Nhật Vinh");
            this.selectShapett.SetToolTip(this.selectShape_icon, "Select Shape");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Rotate_lb);
            this.panel1.Controls.Add(this.Scale_lb);
            this.panel1.Controls.Add(this.selectShapeLb);
            this.panel1.Location = new System.Drawing.Point(552, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 79);
            this.panel1.TabIndex = 6;
            // 
            // Rotate_lb
            // 
            this.Rotate_lb.AutoEllipsis = true;
            this.Rotate_lb.AutoSize = true;
            this.Rotate_lb.BackColor = System.Drawing.Color.Cornsilk;
            this.Rotate_lb.Font = new System.Drawing.Font("VNI-Free", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rotate_lb.Location = new System.Drawing.Point(75, 39);
            this.Rotate_lb.Name = "Rotate_lb";
            this.Rotate_lb.Size = new System.Drawing.Size(65, 36);
            this.Rotate_lb.TabIndex = 3;
            this.Rotate_lb.Text = "Rotate";
            // 
            // Scale_lb
            // 
            this.Scale_lb.AutoSize = true;
            this.Scale_lb.BackColor = System.Drawing.Color.FloralWhite;
            this.Scale_lb.Font = new System.Drawing.Font("VNI-Free", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scale_lb.Location = new System.Drawing.Point(13, 39);
            this.Scale_lb.Name = "Scale_lb";
            this.Scale_lb.Size = new System.Drawing.Size(56, 36);
            this.Scale_lb.TabIndex = 2;
            this.Scale_lb.Text = "Scale";
            this.Scale_lb.Click += new System.EventHandler(this.Scale_lb_Click);
            // 
            // selectShapeLb
            // 
            this.selectShapeLb.AutoSize = true;
            this.selectShapeLb.BackColor = System.Drawing.Color.Linen;
            this.selectShapeLb.Font = new System.Drawing.Font("VNI-Free", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectShapeLb.Location = new System.Drawing.Point(2, 0);
            this.selectShapeLb.Name = "selectShapeLb";
            this.selectShapeLb.Size = new System.Drawing.Size(155, 36);
            this.selectShapeLb.TabIndex = 1;
            this.selectShapeLb.Text = "Select - Translate";
            this.selectShapeLb.Click += new System.EventHandler(this.selectShapeLb_Click);
            // 
            // pnlDraw
            // 
            this.pnlDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDraw.Controls.Add(this.openGLControl);
            this.pnlDraw.Location = new System.Drawing.Point(4, 94);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(1234, 325);
            this.pnlDraw.TabIndex = 5;
            // 
            // openGLControl
            // 
            this.openGLControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGLControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.openGLControl.DrawFPS = false;
            this.openGLControl.Location = new System.Drawing.Point(0, 0);
            this.openGLControl.Margin = new System.Windows.Forms.Padding(4);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(1234, 324);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            this.openGLControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseDown);
            this.openGLControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseMove);
            this.openGLControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseUp);
            // 
            // pnlSize
            // 
            this.pnlSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSize.Controls.Add(this.tbSize);
            this.pnlSize.Controls.Add(this.lbSize);
            this.pnlSize.Location = new System.Drawing.Point(710, 2);
            this.pnlSize.Name = "pnlSize";
            this.pnlSize.Size = new System.Drawing.Size(55, 79);
            this.pnlSize.TabIndex = 2;
            // 
            // tbSize
            // 
            this.tbSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSize.Font = new System.Drawing.Font("VNI-Free", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSize.Location = new System.Drawing.Point(4, 4);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(44, 43);
            this.tbSize.TabIndex = 1;
            this.tbSize.Text = "1";
            this.toolTipSize.SetToolTip(this.tbSize, "Fill size shape here");
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("VNI-Free", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbSize.Location = new System.Drawing.Point(3, 41);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(45, 36);
            this.lbSize.TabIndex = 0;
            this.lbSize.Text = "Size";
            // 
            // pnlTime
            // 
            this.pnlTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTime.Controls.Add(this.tbTime);
            this.pnlTime.Controls.Add(this.time_icon);
            this.pnlTime.Controls.Add(this.lbTime);
            this.pnlTime.Location = new System.Drawing.Point(956, 3);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(190, 80);
            this.pnlTime.TabIndex = 4;
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(75, 11);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(100, 20);
            this.tbTime.TabIndex = 3;
            // 
            // time_icon
            // 
            this.time_icon.BackColor = System.Drawing.Color.White;
            this.time_icon.Image = ((System.Drawing.Image)(resources.GetObject("time_icon.Image")));
            this.time_icon.Location = new System.Drawing.Point(0, 0);
            this.time_icon.Name = "time_icon";
            this.time_icon.Size = new System.Drawing.Size(69, 58);
            this.time_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.time_icon.TabIndex = 2;
            this.time_icon.TabStop = false;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("VNI-Free", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(96, 35);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(50, 36);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "Time";
            // 
            // pnlColors
            // 
            this.pnlColors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColors.Controls.Add(this.pictureColor);
            this.pnlColors.Controls.Add(this.lbColors);
            this.pnlColors.Location = new System.Drawing.Point(771, 3);
            this.pnlColors.Name = "pnlColors";
            this.pnlColors.Size = new System.Drawing.Size(179, 81);
            this.pnlColors.TabIndex = 3;
            // 
            // pictureColor
            // 
            this.pictureColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureColor.Image = ((System.Drawing.Image)(resources.GetObject("pictureColor.Image")));
            this.pictureColor.Location = new System.Drawing.Point(61, -1);
            this.pictureColor.Name = "pictureColor";
            this.pictureColor.Size = new System.Drawing.Size(114, 72);
            this.pictureColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureColor.TabIndex = 1;
            this.pictureColor.TabStop = false;
            this.toolTipColor.SetToolTip(this.pictureColor, "Choose color here");
            this.pictureColor.Click += new System.EventHandler(this.pictureColor_Click);
            // 
            // lbColors
            // 
            this.lbColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbColors.AutoSize = true;
            this.lbColors.Font = new System.Drawing.Font("VNI-Free", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColors.Location = new System.Drawing.Point(3, 13);
            this.lbColors.Name = "lbColors";
            this.lbColors.Size = new System.Drawing.Size(64, 36);
            this.lbColors.TabIndex = 0;
            this.lbColors.Text = "Colors";
            // 
            // pnlShape
            // 
            this.pnlShape.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlShape.Controls.Add(this.polygon_icon);
            this.pnlShape.Controls.Add(this.hexagol_icon);
            this.pnlShape.Controls.Add(this.rectangle_icon);
            this.pnlShape.Controls.Add(this.pentagol_icon);
            this.pnlShape.Controls.Add(this.triangle_icon);
            this.pnlShape.Controls.Add(this.circle_icon);
            this.pnlShape.Controls.Add(this.ellipse_icon);
            this.pnlShape.Controls.Add(this.line_icon);
            this.pnlShape.Controls.Add(this.lbShape);
            this.pnlShape.Location = new System.Drawing.Point(108, 3);
            this.pnlShape.Name = "pnlShape";
            this.pnlShape.Size = new System.Drawing.Size(442, 79);
            this.pnlShape.TabIndex = 1;
            // 
            // polygon_icon
            // 
            this.polygon_icon.Image = global::Lab01_DHMT.Properties.Resources.polygon;
            this.polygon_icon.Location = new System.Drawing.Point(392, 0);
            this.polygon_icon.Name = "polygon_icon";
            this.polygon_icon.Size = new System.Drawing.Size(43, 46);
            this.polygon_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.polygon_icon.TabIndex = 10;
            this.polygon_icon.TabStop = false;
            this.Polygol.SetToolTip(this.polygon_icon, "Draw polygol");
            this.polygon_icon.Click += new System.EventHandler(this.polygon_icon_Click);
            // 
            // hexagol_icon
            // 
            this.hexagol_icon.Image = ((System.Drawing.Image)(resources.GetObject("hexagol_icon.Image")));
            this.hexagol_icon.Location = new System.Drawing.Point(336, 0);
            this.hexagol_icon.Name = "hexagol_icon";
            this.hexagol_icon.Size = new System.Drawing.Size(49, 49);
            this.hexagol_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hexagol_icon.TabIndex = 9;
            this.hexagol_icon.TabStop = false;
            this.toolTipHexagon.SetToolTip(this.hexagol_icon, "Draw Hexagon");
            this.hexagol_icon.Click += new System.EventHandler(this.hexagol_icon_Click);
            // 
            // rectangle_icon
            // 
            this.rectangle_icon.Image = ((System.Drawing.Image)(resources.GetObject("rectangle_icon.Image")));
            this.rectangle_icon.Location = new System.Drawing.Point(172, 4);
            this.rectangle_icon.Name = "rectangle_icon";
            this.rectangle_icon.Size = new System.Drawing.Size(51, 42);
            this.rectangle_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rectangle_icon.TabIndex = 8;
            this.rectangle_icon.TabStop = false;
            this.toolTipRectangle.SetToolTip(this.rectangle_icon, "Draw Rectangle");
            this.rectangle_icon.Click += new System.EventHandler(this.rectangle_icon_Click);
            // 
            // pentagol_icon
            // 
            this.pentagol_icon.Image = ((System.Drawing.Image)(resources.GetObject("pentagol_icon.Image")));
            this.pentagol_icon.Location = new System.Drawing.Point(281, 0);
            this.pentagol_icon.Name = "pentagol_icon";
            this.pentagol_icon.Size = new System.Drawing.Size(49, 49);
            this.pentagol_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pentagol_icon.TabIndex = 5;
            this.pentagol_icon.TabStop = false;
            this.toolTipPentagon.SetToolTip(this.pentagol_icon, "Draw Pentagon");
            this.pentagol_icon.Click += new System.EventHandler(this.pentagol_icon_Click);
            // 
            // triangle_icon
            // 
            this.triangle_icon.Image = ((System.Drawing.Image)(resources.GetObject("triangle_icon.Image")));
            this.triangle_icon.Location = new System.Drawing.Point(229, 3);
            this.triangle_icon.Name = "triangle_icon";
            this.triangle_icon.Size = new System.Drawing.Size(46, 43);
            this.triangle_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.triangle_icon.TabIndex = 4;
            this.triangle_icon.TabStop = false;
            this.toolTipTriangle.SetToolTip(this.triangle_icon, "Draw Triangle");
            this.triangle_icon.Click += new System.EventHandler(this.triangle_icon_Click);
            // 
            // circle_icon
            // 
            this.circle_icon.BackColor = System.Drawing.Color.Transparent;
            this.circle_icon.Image = ((System.Drawing.Image)(resources.GetObject("circle_icon.Image")));
            this.circle_icon.Location = new System.Drawing.Point(57, 0);
            this.circle_icon.Name = "circle_icon";
            this.circle_icon.Size = new System.Drawing.Size(54, 49);
            this.circle_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circle_icon.TabIndex = 3;
            this.circle_icon.TabStop = false;
            this.toolTipCircle.SetToolTip(this.circle_icon, "Draw Circle");
            this.circle_icon.Click += new System.EventHandler(this.circle_Click);
            // 
            // ellipse_icon
            // 
            this.ellipse_icon.Image = ((System.Drawing.Image)(resources.GetObject("ellipse_icon.Image")));
            this.ellipse_icon.Location = new System.Drawing.Point(117, 0);
            this.ellipse_icon.Name = "ellipse_icon";
            this.ellipse_icon.Size = new System.Drawing.Size(49, 49);
            this.ellipse_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ellipse_icon.TabIndex = 2;
            this.ellipse_icon.TabStop = false;
            this.toolTipEllipse.SetToolTip(this.ellipse_icon, "Draw Ellipse");
            this.ellipse_icon.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // line_icon
            // 
            this.line_icon.Image = ((System.Drawing.Image)(resources.GetObject("line_icon.Image")));
            this.line_icon.Location = new System.Drawing.Point(0, 0);
            this.line_icon.Name = "line_icon";
            this.line_icon.Size = new System.Drawing.Size(51, 49);
            this.line_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.line_icon.TabIndex = 1;
            this.line_icon.TabStop = false;
            this.toolTipLine.SetToolTip(this.line_icon, "Draw Line");
            this.line_icon.Click += new System.EventHandler(this.line_Click);
            // 
            // lbShape
            // 
            this.lbShape.AutoSize = true;
            this.lbShape.Font = new System.Drawing.Font("VNI-Free", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShape.Location = new System.Drawing.Point(172, 45);
            this.lbShape.Name = "lbShape";
            this.lbShape.Size = new System.Drawing.Size(67, 36);
            this.lbShape.TabIndex = 0;
            this.lbShape.Text = "Shapes";
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlControl.Controls.Add(this.groupName);
            this.pnlControl.Controls.Add(this.ptbGroupImage);
            this.pnlControl.Location = new System.Drawing.Point(4, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(365, 84);
            this.pnlControl.TabIndex = 0;
            // 
            // groupName
            // 
            this.groupName.AutoSize = true;
            this.groupName.BackColor = System.Drawing.Color.Red;
            this.groupName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.groupName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupName.Font = new System.Drawing.Font("VNI-Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupName.Location = new System.Drawing.Point(18, 54);
            this.groupName.MaximumSize = new System.Drawing.Size(100, 100);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(54, 30);
            this.groupName.TabIndex = 0;
            this.groupName.Text = "NOPE";
            // 
            // ptbGroupImage
            // 
            this.ptbGroupImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbGroupImage.Image = ((System.Drawing.Image)(resources.GetObject("ptbGroupImage.Image")));
            this.ptbGroupImage.Location = new System.Drawing.Point(0, 1);
            this.ptbGroupImage.Name = "ptbGroupImage";
            this.ptbGroupImage.Size = new System.Drawing.Size(97, 74);
            this.ptbGroupImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbGroupImage.TabIndex = 1;
            this.ptbGroupImage.TabStop = false;
            this.toolTipImageGroup.SetToolTip(this.ptbGroupImage, "We are NOPE: Vinh, Hoài, Huấn, Huy, Thắng");
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // toolTipHexagon
            // 
            this.toolTipHexagon.ToolTipTitle = "Draw hexagon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1269, 450);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NOPE PAINT";
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectShape_icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDraw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.pnlSize.ResumeLayout(false);
            this.pnlSize.PerformLayout();
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.time_icon)).EndInit();
            this.pnlColors.ResumeLayout(false);
            this.pnlColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureColor)).EndInit();
            this.pnlShape.ResumeLayout(false);
            this.pnlShape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polygon_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hexagol_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pentagol_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangle_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipse_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_icon)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGroupImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Panel pnlColors;
        private System.Windows.Forms.Panel pnlSize;
        private System.Windows.Forms.Panel pnlShape;
        private System.Windows.Forms.Label groupName;
        public System.Windows.Forms.Panel pnlDraw;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbColors;
        private System.Windows.Forms.Label lbShape;
        private System.Windows.Forms.PictureBox pentagol_icon;
        private System.Windows.Forms.PictureBox triangle_icon;
        private System.Windows.Forms.PictureBox circle_icon;
        private System.Windows.Forms.PictureBox ellipse_icon;
        private System.Windows.Forms.PictureBox rectangle_icon;
        private System.Windows.Forms.PictureBox time_icon;
        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.PictureBox ptbGroupImage;
        private System.Windows.Forms.PictureBox pictureColor;
        private System.Windows.Forms.PictureBox line_icon;
        private System.Windows.Forms.PictureBox hexagol_icon;
        private System.Windows.Forms.ToolTip toolTipLine;
        private System.Windows.Forms.ToolTip toolTipEllipse;
        private System.Windows.Forms.ToolTip toolTipRectangle;
        private System.Windows.Forms.ToolTip toolTipCircle;
        private System.Windows.Forms.ToolTip toolTipPentagon;
        private System.Windows.Forms.ToolTip toolTipHexagon;
        private System.Windows.Forms.ToolTip toolTipTriangle;
        private System.Windows.Forms.ToolTip toolTipSize;
        private System.Windows.Forms.ToolTip toolTipColor;
        private System.Windows.Forms.ToolTip toolTipImageGroup;
        private System.Windows.Forms.PictureBox polygon_icon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox selectShape_icon;
        private System.Windows.Forms.ToolTip selectShapett;
        private System.Windows.Forms.Label selectShapeLb;
        private System.Windows.Forms.ToolTip licencse;
        private System.Windows.Forms.ToolTip Polygol;
        private System.Windows.Forms.Label Rotate_lb;
        private System.Windows.Forms.Label Scale_lb;
    }
}
