namespace StajWeatherProje
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.locationText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Hava4 = new System.Windows.Forms.PictureBox();
            this.Gün4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Hava3 = new System.Windows.Forms.PictureBox();
            this.Gün3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Hava2 = new System.Windows.Forms.PictureBox();
            this.Gün2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Açık1 = new System.Windows.Forms.PictureBox();
            this.firstDeg = new System.Windows.Forms.Label();
            this.Hava1 = new System.Windows.Forms.PictureBox();
            this.Gün1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bulutlu1 = new System.Windows.Forms.PictureBox();
            this.yağmurlu1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hava4)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hava3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hava2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Açık1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hava1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulutlu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yağmurlu1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LocationLabel);
            this.panel1.Controls.Add(this.datelabel);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.locationText);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 501);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LocationLabel
            // 
            this.LocationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
            this.LocationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.LocationLabel.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LocationLabel.Location = new System.Drawing.Point(57, 138);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(175, 37);
            this.LocationLabel.TabIndex = 8;
            this.LocationLabel.Text = "Kırklareli";
            this.LocationLabel.Click += new System.EventHandler(this.LocationLabel_Click);
            // 
            // datelabel
            // 
            this.datelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
            this.datelabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.datelabel.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.datelabel.Location = new System.Drawing.Point(539, 288);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(261, 34);
            this.datelabel.TabIndex = 7;
            this.datelabel.Text = "Salı, 20/08";
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
            this.timeLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.timeLabel.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.timeLabel.Location = new System.Drawing.Point(533, 244);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(267, 34);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "10:00 Am";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(219, 23);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // locationText
            // 
            this.locationText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.locationText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationText.Location = new System.Drawing.Point(24, 30);
            this.locationText.Name = "locationText";
            this.locationText.Size = new System.Drawing.Size(198, 20);
            this.locationText.TabIndex = 2;
            this.locationText.Text = "Kırklareli";
            this.locationText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 132);
            this.panel2.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
            this.panel6.Controls.Add(this.yağmurlu1);
            this.panel6.Controls.Add(this.bulutlu1);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.Hava4);
            this.panel6.Controls.Add(this.Gün4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(600, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 132);
            this.panel6.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(57, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 34);
            this.label7.TabIndex = 2;
            this.label7.Text = "27.49 C";
            // 
            // Hava4
            // 
            this.Hava4.Image = ((System.Drawing.Image)(resources.GetObject("Hava4.Image")));
            this.Hava4.Location = new System.Drawing.Point(50, 32);
            this.Hava4.Name = "Hava4";
            this.Hava4.Size = new System.Drawing.Size(100, 50);
            this.Hava4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hava4.TabIndex = 1;
            this.Hava4.TabStop = false;
            this.Hava4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Gün4
            // 
            this.Gün4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
            this.Gün4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gün4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gün4.ForeColor = System.Drawing.Color.White;
            this.Gün4.Location = new System.Drawing.Point(0, 0);
            this.Gün4.Name = "Gün4";
            this.Gün4.Size = new System.Drawing.Size(200, 29);
            this.Gün4.TabIndex = 0;
            this.Gün4.Text = "Perşembe";
            this.Gün4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Gün4.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.Hava3);
            this.panel5.Controls.Add(this.Gün3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(400, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 132);
            this.panel5.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(57, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 34);
            this.label5.TabIndex = 2;
            this.label5.Text = "36.73 C";
            // 
            // Hava3
            // 
            this.Hava3.Image = ((System.Drawing.Image)(resources.GetObject("Hava3.Image")));
            this.Hava3.Location = new System.Drawing.Point(50, 32);
            this.Hava3.Name = "Hava3";
            this.Hava3.Size = new System.Drawing.Size(100, 50);
            this.Hava3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hava3.TabIndex = 1;
            this.Hava3.TabStop = false;
            // 
            // Gün3
            // 
            this.Gün3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
            this.Gün3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gün3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gün3.ForeColor = System.Drawing.Color.White;
            this.Gün3.Location = new System.Drawing.Point(0, 0);
            this.Gün3.Name = "Gün3";
            this.Gün3.Size = new System.Drawing.Size(200, 29);
            this.Gün3.TabIndex = 0;
            this.Gün3.Text = "Çarşamba";
            this.Gün3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Gün3.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.Hava2);
            this.panel4.Controls.Add(this.Gün2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 132);
            this.panel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(57, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "34.18 C";
            // 
            // Hava2
            // 
            this.Hava2.Image = ((System.Drawing.Image)(resources.GetObject("Hava2.Image")));
            this.Hava2.Location = new System.Drawing.Point(50, 32);
            this.Hava2.Name = "Hava2";
            this.Hava2.Size = new System.Drawing.Size(100, 50);
            this.Hava2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hava2.TabIndex = 1;
            this.Hava2.TabStop = false;
            // 
            // Gün2
            // 
            this.Gün2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
            this.Gün2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gün2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gün2.ForeColor = System.Drawing.Color.White;
            this.Gün2.Location = new System.Drawing.Point(0, 0);
            this.Gün2.Name = "Gün2";
            this.Gün2.Size = new System.Drawing.Size(200, 29);
            this.Gün2.TabIndex = 0;
            this.Gün2.Text = "Salı";
            this.Gün2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Gün2.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
            this.panel3.Controls.Add(this.Açık1);
            this.panel3.Controls.Add(this.firstDeg);
            this.panel3.Controls.Add(this.Hava1);
            this.panel3.Controls.Add(this.Gün1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 132);
            this.panel3.TabIndex = 0;
            // 
            // Açık1
            // 
            this.Açık1.Image = ((System.Drawing.Image)(resources.GetObject("Açık1.Image")));
            this.Açık1.Location = new System.Drawing.Point(50, 32);
            this.Açık1.Name = "Açık1";
            this.Açık1.Size = new System.Drawing.Size(100, 50);
            this.Açık1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Açık1.TabIndex = 10;
            this.Açık1.TabStop = false;
            // 
            // firstDeg
            // 
            this.firstDeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firstDeg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.firstDeg.Location = new System.Drawing.Point(57, 89);
            this.firstDeg.Name = "firstDeg";
            this.firstDeg.Size = new System.Drawing.Size(137, 34);
            this.firstDeg.TabIndex = 2;
            this.firstDeg.Text = "25 C";
            // 
            // Hava1
            // 
            this.Hava1.Image = ((System.Drawing.Image)(resources.GetObject("Hava1.Image")));
            this.Hava1.Location = new System.Drawing.Point(50, 32);
            this.Hava1.Name = "Hava1";
            this.Hava1.Size = new System.Drawing.Size(100, 50);
            this.Hava1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hava1.TabIndex = 1;
            this.Hava1.TabStop = false;
            this.Hava1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Gün1
            // 
            this.Gün1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
            this.Gün1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gün1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gün1.ForeColor = System.Drawing.Color.White;
            this.Gün1.Location = new System.Drawing.Point(0, 0);
            this.Gün1.Name = "Gün1";
            this.Gün1.Size = new System.Drawing.Size(200, 29);
            this.Gün1.TabIndex = 0;
            this.Gün1.Text = "Pazartesi";
            this.Gün1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Gün1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 20;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(748, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(50, 50);
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = false;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = false;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = this.panel1;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bulutlu1
            // 
            this.bulutlu1.Image = ((System.Drawing.Image)(resources.GetObject("bulutlu1.Image")));
            this.bulutlu1.Location = new System.Drawing.Point(50, 32);
            this.bulutlu1.Name = "bulutlu1";
            this.bulutlu1.Size = new System.Drawing.Size(100, 50);
            this.bulutlu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bulutlu1.TabIndex = 3;
            this.bulutlu1.TabStop = false;
            // 
            // yağmurlu1
            // 
            this.yağmurlu1.Image = ((System.Drawing.Image)(resources.GetObject("yağmurlu1.Image")));
            this.yağmurlu1.Location = new System.Drawing.Point(50, 32);
            this.yağmurlu1.Name = "yağmurlu1";
            this.yağmurlu1.Size = new System.Drawing.Size(100, 50);
            this.yağmurlu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yağmurlu1.TabIndex = 4;
            this.yağmurlu1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(798, 501);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StajWeather";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Hava4)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Hava3)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Hava2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Açık1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hava1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulutlu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yağmurlu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Gün1;
        private System.Windows.Forms.PictureBox Hava1;
        private System.Windows.Forms.Label firstDeg;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox Hava4;
        private System.Windows.Forms.Label Gün4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Hava3;
        private System.Windows.Forms.Label Gün3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Hava2;
        private System.Windows.Forms.Label Gün2;
        private System.Windows.Forms.TextBox locationText;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Açık1;
        private System.Windows.Forms.PictureBox bulutlu1;
        private System.Windows.Forms.PictureBox yağmurlu1;
    }
}

