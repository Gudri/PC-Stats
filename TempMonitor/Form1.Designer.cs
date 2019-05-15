namespace TempMonitor
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Meni = new System.Windows.Forms.Panel();
            this.xuiCustomGroupbox2 = new XanderUI.XUICustomGroupbox();
            this.xuiRadio3 = new XanderUI.XUIRadio();
            this.xuiRadio4 = new XanderUI.XUIRadio();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.xuiRadio2 = new XanderUI.XUIRadio();
            this.xuiRadio1 = new XanderUI.XUIRadio();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Prikazivanje = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ramUsage = new XanderUI.XUIFlatProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cpuUsage = new XanderUI.XUIFlatProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Sakrivanje = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.RAM = new System.Diagnostics.PerformanceCounter();
            this.label7 = new System.Windows.Forms.Label();
            this.Meni.SuspendLayout();
            this.xuiCustomGroupbox2.SuspendLayout();
            this.xuiCustomGroupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            this.SuspendLayout();
            // 
            // Meni
            // 
            this.Meni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Meni.Controls.Add(this.xuiCustomGroupbox2);
            this.Meni.Controls.Add(this.xuiCustomGroupbox1);
            this.Meni.Controls.Add(this.label2);
            this.Meni.Controls.Add(this.bunifuFlatButton2);
            this.Meni.Controls.Add(this.pictureBox1);
            this.Sakrivanje.SetDecoration(this.Meni, BunifuAnimatorNS.DecorationType.None);
            this.Prikazivanje.SetDecoration(this.Meni, BunifuAnimatorNS.DecorationType.None);
            this.Meni.Dock = System.Windows.Forms.DockStyle.Left;
            this.Meni.Location = new System.Drawing.Point(0, 0);
            this.Meni.Name = "Meni";
            this.Meni.Size = new System.Drawing.Size(301, 768);
            this.Meni.TabIndex = 1;
            this.Meni.Visible = false;
            // 
            // xuiCustomGroupbox2
            // 
            this.xuiCustomGroupbox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(161)))), ((int)(((byte)(190)))));
            this.xuiCustomGroupbox2.BorderWidth = 1;
            this.xuiCustomGroupbox2.Controls.Add(this.xuiRadio3);
            this.xuiCustomGroupbox2.Controls.Add(this.xuiRadio4);
            this.Sakrivanje.SetDecoration(this.xuiCustomGroupbox2, BunifuAnimatorNS.DecorationType.None);
            this.Prikazivanje.SetDecoration(this.xuiCustomGroupbox2, BunifuAnimatorNS.DecorationType.None);
            this.xuiCustomGroupbox2.Font = new System.Drawing.Font("SIEMENS_GOST Type A", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiCustomGroupbox2.Location = new System.Drawing.Point(81, 286);
            this.xuiCustomGroupbox2.Name = "xuiCustomGroupbox2";
            this.xuiCustomGroupbox2.ShowText = true;
            this.xuiCustomGroupbox2.Size = new System.Drawing.Size(81, 65);
            this.xuiCustomGroupbox2.TabIndex = 7;
            this.xuiCustomGroupbox2.TabStop = false;
            this.xuiCustomGroupbox2.Text = "Unit";
            this.xuiCustomGroupbox2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(161)))), ((int)(((byte)(190)))));
            // 
            // xuiRadio3
            // 
            this.xuiRadio3.Checked = false;
            this.Sakrivanje.SetDecoration(this.xuiRadio3, BunifuAnimatorNS.DecorationType.None);
            this.Prikazivanje.SetDecoration(this.xuiRadio3, BunifuAnimatorNS.DecorationType.None);
            this.xuiRadio3.Font = new System.Drawing.Font("SIEMENS_GOST Type A", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiRadio3.ForeColor = System.Drawing.Color.White;
            this.xuiRadio3.Location = new System.Drawing.Point(6, 41);
            this.xuiRadio3.Name = "xuiRadio3";
            this.xuiRadio3.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(161)))), ((int)(((byte)(190)))));
            this.xuiRadio3.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiRadio3.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio3.Size = new System.Drawing.Size(69, 15);
            this.xuiRadio3.TabIndex = 5;
            this.xuiRadio3.Text = "Farenheit";
            // 
            // xuiRadio4
            // 
            this.xuiRadio4.Checked = false;
            this.Sakrivanje.SetDecoration(this.xuiRadio4, BunifuAnimatorNS.DecorationType.None);
            this.Prikazivanje.SetDecoration(this.xuiRadio4, BunifuAnimatorNS.DecorationType.None);
            this.xuiRadio4.Font = new System.Drawing.Font("SIEMENS_GOST Type A", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiRadio4.ForeColor = System.Drawing.Color.White;
            this.xuiRadio4.Location = new System.Drawing.Point(6, 19);
            this.xuiRadio4.Name = "xuiRadio4";
            this.xuiRadio4.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(161)))), ((int)(((byte)(190)))));
            this.xuiRadio4.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiRadio4.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio4.Size = new System.Drawing.Size(64, 15);
            this.xuiRadio4.TabIndex = 4;
            this.xuiRadio4.Text = "Celsius";
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(161)))), ((int)(((byte)(190)))));
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.xuiRadio2);
            this.xuiCustomGroupbox1.Controls.Add(this.xuiRadio1);
            this.Sakrivanje.SetDecoration(this.xuiCustomGroupbox1, BunifuAnimatorNS.DecorationType.None);
            this.Prikazivanje.SetDecoration(this.xuiCustomGroupbox1, BunifuAnimatorNS.DecorationType.None);
            this.xuiCustomGroupbox1.Font = new System.Drawing.Font("SIEMENS_GOST Type A", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(12, 286);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(63, 65);
            this.xuiCustomGroupbox1.TabIndex = 6;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "Theme";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(161)))), ((int)(((byte)(190)))));
            // 
            // xuiRadio2
            // 
            this.xuiRadio2.Checked = false;
            this.Sakrivanje.SetDecoration(this.xuiRadio2, BunifuAnimatorNS.DecorationType.None);
            this.Prikazivanje.SetDecoration(this.xuiRadio2, BunifuAnimatorNS.DecorationType.None);
            this.xuiRadio2.Font = new System.Drawing.Font("SIEMENS_GOST Type A", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiRadio2.ForeColor = System.Drawing.Color.White;
            this.xuiRadio2.Location = new System.Drawing.Point(6, 41);
            this.xuiRadio2.Name = "xuiRadio2";
            this.xuiRadio2.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(161)))), ((int)(((byte)(190)))));
            this.xuiRadio2.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiRadio2.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio2.Size = new System.Drawing.Size(47, 15);
            this.xuiRadio2.TabIndex = 5;
            this.xuiRadio2.Text = "Light";
            this.xuiRadio2.Click += new System.EventHandler(this.SetThemeLight);
            // 
            // xuiRadio1
            // 
            this.xuiRadio1.Checked = true;
            this.Sakrivanje.SetDecoration(this.xuiRadio1, BunifuAnimatorNS.DecorationType.None);
            this.Prikazivanje.SetDecoration(this.xuiRadio1, BunifuAnimatorNS.DecorationType.None);
            this.xuiRadio1.Font = new System.Drawing.Font("SIEMENS_GOST Type A", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiRadio1.ForeColor = System.Drawing.Color.White;
            this.xuiRadio1.Location = new System.Drawing.Point(6, 19);
            this.xuiRadio1.Name = "xuiRadio1";
            this.xuiRadio1.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(161)))), ((int)(((byte)(190)))));
            this.xuiRadio1.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiRadio1.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuiRadio1.Size = new System.Drawing.Size(47, 15);
            this.xuiRadio1.TabIndex = 4;
            this.xuiRadio1.Text = "Dark";
            this.xuiRadio1.Click += new System.EventHandler(this.SetThemeDark);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.Prikazivanje.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.Sakrivanje.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("SIEMENS_GOST Type A", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(89, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Settings";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(190)))), ((int)(((byte)(166)))));
            this.bunifuFlatButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(161)))), ((int)(((byte)(190)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "About";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Prikazivanje.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.Sakrivanje.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("SIEMENS_GOST Type A", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::PCStats.Properties.Resources.btn_about;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(50, 703);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(161)))), ((int)(((byte)(190)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(171)))), ((int)(((byte)(190)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(200, 53);
            this.bunifuFlatButton2.TabIndex = 2;
            this.bunifuFlatButton2.Text = "About";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("SIEMENS_GOST Type A", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PCStats.Properties.Resources.logo_dark;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Prikazivanje.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.Sakrivanje.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(29, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Prikazivanje
            // 
            this.Prikazivanje.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.Prikazivanje.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.Prikazivanje.DefaultAnimation = animation2;
            this.Prikazivanje.Interval = 1;
            this.Prikazivanje.TimeStep = 0.01F;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(190)))), ((int)(((byte)(166)))));
            this.panel3.Controls.Add(this.bunifuImageButton2);
            this.panel3.Controls.Add(this.bunifuImageButton1);
            this.panel3.Controls.Add(this.label1);
            this.Sakrivanje.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.Prikazivanje.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(301, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1065, 72);
            this.panel3.TabIndex = 0;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sakrivanje.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.Prikazivanje.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = global::PCStats.Properties.Resources.btn_settings;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(17, 5);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(64, 64);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.BunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sakrivanje.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.Prikazivanje.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = global::PCStats.Properties.Resources.btn_close;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(989, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(64, 64);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Prikazivanje.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.Sakrivanje.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("SIEMENS_GOST Type A", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1065, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "PC Stats";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.Prikazivanje.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.Sakrivanje.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("SIEMENS_GOST Type A", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label5.Location = new System.Drawing.Point(596, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 40);
            this.label5.TabIndex = 18;
            this.label5.Text = "50%";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.Prikazivanje.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.Sakrivanje.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("SIEMENS_GOST Type A", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(384, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 40);
            this.label6.TabIndex = 17;
            this.label6.Text = "RAM Usage :";
            // 
            // ramUsage
            // 
            this.ramUsage.BarStyle = XanderUI.XUIFlatProgressBar.Style.Material;
            this.ramUsage.BorderColor = System.Drawing.Color.Black;
            this.ramUsage.CompleteColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.Sakrivanje.SetDecoration(this.ramUsage, BunifuAnimatorNS.DecorationType.None);
            this.Prikazivanje.SetDecoration(this.ramUsage, BunifuAnimatorNS.DecorationType.None);
            this.ramUsage.InocmpletedColor = System.Drawing.Color.White;
            this.ramUsage.Location = new System.Drawing.Point(391, 118);
            this.ramUsage.MaxValue = 100;
            this.ramUsage.Name = "ramUsage";
            this.ramUsage.ShowBorder = true;
            this.ramUsage.Size = new System.Drawing.Size(300, 17);
            this.ramUsage.TabIndex = 16;
            this.ramUsage.Text = "xuiFlatProgressBar1";
            this.ramUsage.Value = 50;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.Prikazivanje.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.Sakrivanje.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("SIEMENS_GOST Type A", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(241, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 40);
            this.label4.TabIndex = 15;
            this.label4.Text = "50%";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.Prikazivanje.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.Sakrivanje.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("SIEMENS_GOST Type A", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 40);
            this.label3.TabIndex = 14;
            this.label3.Text = "CPU Usage :";
            // 
            // cpuUsage
            // 
            this.cpuUsage.BarStyle = XanderUI.XUIFlatProgressBar.Style.Material;
            this.cpuUsage.BorderColor = System.Drawing.Color.Black;
            this.cpuUsage.CompleteColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.Sakrivanje.SetDecoration(this.cpuUsage, BunifuAnimatorNS.DecorationType.None);
            this.Prikazivanje.SetDecoration(this.cpuUsage, BunifuAnimatorNS.DecorationType.None);
            this.cpuUsage.InocmpletedColor = System.Drawing.Color.White;
            this.cpuUsage.Location = new System.Drawing.Point(36, 118);
            this.cpuUsage.MaxValue = 100;
            this.cpuUsage.Name = "cpuUsage";
            this.cpuUsage.ShowBorder = true;
            this.cpuUsage.Size = new System.Drawing.Size(300, 17);
            this.cpuUsage.TabIndex = 13;
            this.cpuUsage.Text = "xuiFlatProgressBar1";
            this.cpuUsage.Value = 50;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cpuUsage);
            this.panel2.Controls.Add(this.ramUsage);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.Sakrivanje.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.Prikazivanje.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 768);
            this.panel2.TabIndex = 19;
            // 
            // Sakrivanje
            // 
            this.Sakrivanje.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.Sakrivanje.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Sakrivanje.DefaultAnimation = animation1;
            this.Sakrivanje.Interval = 1;
            this.Sakrivanje.TimeStep = 0.01F;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.label1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label2;
            this.bunifuDragControl2.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // CPU
            // 
            this.CPU.CategoryName = "Processor";
            this.CPU.CounterName = "% Processor Time";
            this.CPU.InstanceName = "_Total";
            // 
            // RAM
            // 
            this.RAM.CategoryName = "Memory";
            this.RAM.CounterName = "% Committed Bytes in Use";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.Prikazivanje.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.Sakrivanje.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("SIEMENS_GOST Type A", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label7.Location = new System.Drawing.Point(903, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 40);
            this.label7.TabIndex = 19;
            this.label7.Text = "50%";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Meni);
            this.Controls.Add(this.panel2);
            this.Sakrivanje.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Prikazivanje.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Meni.ResumeLayout(false);
            this.Meni.PerformLayout();
            this.xuiCustomGroupbox2.ResumeLayout(false);
            this.xuiCustomGroupbox2.PerformLayout();
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Meni;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BunifuAnimatorNS.BunifuTransition Prikazivanje;
        private BunifuAnimatorNS.BunifuTransition Sakrivanje;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private XanderUI.XUIRadio xuiRadio2;
        private XanderUI.XUIRadio xuiRadio1;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox2;
        private XanderUI.XUIRadio xuiRadio3;
        private XanderUI.XUIRadio xuiRadio4;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter CPU;
        private System.Diagnostics.PerformanceCounter RAM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private XanderUI.XUIFlatProgressBar ramUsage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private XanderUI.XUIFlatProgressBar cpuUsage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}

