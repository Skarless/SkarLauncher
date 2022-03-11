using System.Drawing;
using System.Drawing.Drawing2D;

namespace SkarLauncher
{
    partial class skarLauncherForm
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
            this.topBar = new System.Windows.Forms.Panel();
            this.favicon = new System.Windows.Forms.Label();
            this.topBar_Minimize = new System.Windows.Forms.Button();
            this.topBar_Maximize = new System.Windows.Forms.Button();
            this.topBar_Close = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.addInstallPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.addInstall_colorButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.addInstall_noMCP = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.addInstall_injectMemoryFix = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.addInstall_injectConsole = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.addInstall_injectClient = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.addInstall_injectYosemite = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.addInstall_injectJaguar = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.addInstall_useLawin = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.addInstall_useHarmony = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.addInstall_createButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.addInstall_installPath_label = new System.Windows.Forms.Label();
            this.addInstall_installPath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.addInstall_profileName_label = new System.Windows.Forms.Label();
            this.addInstall_profileName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.addInstall_headerLabel = new System.Windows.Forms.Label();
            this.homePanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.installBar = new System.Windows.Forms.FlowLayoutPanel();
            this.homeButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.addInstallation = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.addInstall_colorDialog = new System.Windows.Forms.ColorDialog();
            this.topBar.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addInstallPanel)).BeginInit();
            this.addInstallPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePanel)).BeginInit();
            this.homePanel.SuspendLayout();
            this.sideBarPanel.SuspendLayout();
            this.installBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.topBar.Controls.Add(this.favicon);
            this.topBar.Controls.Add(this.topBar_Minimize);
            this.topBar.Controls.Add(this.topBar_Maximize);
            this.topBar.Controls.Add(this.topBar_Close);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(1197, 28);
            this.topBar.TabIndex = 1;
            this.topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseDown);
            // 
            // favicon
            // 
            this.favicon.AutoSize = true;
            this.favicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.favicon.Image = global::SkarLauncher.Properties.Resources.logo_x20;
            this.favicon.Location = new System.Drawing.Point(20, 7);
            this.favicon.Name = "favicon";
            this.favicon.Size = new System.Drawing.Size(25, 13);
            this.favicon.TabIndex = 1;
            this.favicon.Text = "      ";
            // 
            // topBar_Minimize
            // 
            this.topBar_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.topBar_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.topBar_Minimize.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.topBar_Minimize.FlatAppearance.BorderSize = 0;
            this.topBar_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topBar_Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.topBar_Minimize.Image = global::SkarLauncher.Properties.Resources.icons8_subtract_16;
            this.topBar_Minimize.Location = new System.Drawing.Point(1062, 0);
            this.topBar_Minimize.Name = "topBar_Minimize";
            this.topBar_Minimize.Size = new System.Drawing.Size(45, 28);
            this.topBar_Minimize.TabIndex = 5;
            this.topBar_Minimize.TabStop = false;
            this.topBar_Minimize.UseVisualStyleBackColor = false;
            this.topBar_Minimize.Click += new System.EventHandler(this.topBar_Minimize_Click);
            // 
            // topBar_Maximize
            // 
            this.topBar_Maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.topBar_Maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.topBar_Maximize.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.topBar_Maximize.FlatAppearance.BorderSize = 0;
            this.topBar_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topBar_Maximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.topBar_Maximize.Image = global::SkarLauncher.Properties.Resources.icons8_maximize_button_16;
            this.topBar_Maximize.Location = new System.Drawing.Point(1107, 0);
            this.topBar_Maximize.Name = "topBar_Maximize";
            this.topBar_Maximize.Size = new System.Drawing.Size(45, 28);
            this.topBar_Maximize.TabIndex = 4;
            this.topBar_Maximize.TabStop = false;
            this.topBar_Maximize.UseVisualStyleBackColor = false;
            this.topBar_Maximize.Click += new System.EventHandler(this.topBar_Maximize_Click);
            // 
            // topBar_Close
            // 
            this.topBar_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.topBar_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.topBar_Close.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.topBar_Close.FlatAppearance.BorderSize = 0;
            this.topBar_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topBar_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.topBar_Close.Image = global::SkarLauncher.Properties.Resources.icons8_close_16;
            this.topBar_Close.Location = new System.Drawing.Point(1152, 0);
            this.topBar_Close.Name = "topBar_Close";
            this.topBar_Close.Size = new System.Drawing.Size(45, 28);
            this.topBar_Close.TabIndex = 3;
            this.topBar_Close.TabStop = false;
            this.topBar_Close.UseVisualStyleBackColor = false;
            this.topBar_Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mainPanel.Controls.Add(this.addInstallPanel);
            this.mainPanel.Controls.Add(this.homePanel);
            this.mainPanel.Controls.Add(this.sideBarPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 28);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1197, 560);
            this.mainPanel.TabIndex = 2;
            // 
            // addInstallPanel
            // 
            this.addInstallPanel.Controls.Add(this.addInstall_colorButton);
            this.addInstallPanel.Controls.Add(this.addInstall_noMCP);
            this.addInstallPanel.Controls.Add(this.addInstall_injectMemoryFix);
            this.addInstallPanel.Controls.Add(this.addInstall_injectConsole);
            this.addInstallPanel.Controls.Add(this.addInstall_injectClient);
            this.addInstallPanel.Controls.Add(this.addInstall_injectYosemite);
            this.addInstallPanel.Controls.Add(this.addInstall_injectJaguar);
            this.addInstallPanel.Controls.Add(this.addInstall_useLawin);
            this.addInstallPanel.Controls.Add(this.addInstall_useHarmony);
            this.addInstallPanel.Controls.Add(this.addInstall_createButton);
            this.addInstallPanel.Controls.Add(this.addInstall_installPath_label);
            this.addInstallPanel.Controls.Add(this.addInstall_installPath);
            this.addInstallPanel.Controls.Add(this.addInstall_profileName_label);
            this.addInstallPanel.Controls.Add(this.addInstall_profileName);
            this.addInstallPanel.Controls.Add(this.addInstall_headerLabel);
            this.addInstallPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addInstallPanel.Location = new System.Drawing.Point(66, 0);
            this.addInstallPanel.Name = "addInstallPanel";
            this.addInstallPanel.Padding = new System.Windows.Forms.Padding(10, 40, 10, 0);
            this.addInstallPanel.Size = new System.Drawing.Size(1131, 560);
            this.addInstallPanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.addInstallPanel.StateCommon.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.addInstallPanel.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.addInstallPanel.StateCommon.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.addInstallPanel.TabIndex = 2;
            // 
            // addInstall_colorButton
            // 
            this.addInstall_colorButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb;
            this.addInstall_colorButton.Location = new System.Drawing.Point(32, 473);
            this.addInstall_colorButton.Name = "addInstall_colorButton";
            this.addInstall_colorButton.OverrideDefault.Back.Color1 = System.Drawing.Color.Silver;
            this.addInstall_colorButton.OverrideDefault.Back.Color2 = System.Drawing.Color.Silver;
            this.addInstall_colorButton.OverrideDefault.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.addInstall_colorButton.OverrideDefault.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.addInstall_colorButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.addInstall_colorButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Black;
            this.addInstall_colorButton.OverrideDefault.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.addInstall_colorButton.OverrideDefault.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.addInstall_colorButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addInstall_colorButton.OverrideDefault.Border.Rounding = 5;
            this.addInstall_colorButton.OverrideDefault.Border.Width = 3;
            this.addInstall_colorButton.OverrideDefault.Content.LongText.Color1 = System.Drawing.Color.White;
            this.addInstall_colorButton.OverrideDefault.Content.LongText.Color2 = System.Drawing.Color.White;
            this.addInstall_colorButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.addInstall_colorButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.addInstall_colorButton.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstall_colorButton.Size = new System.Drawing.Size(211, 47);
            this.addInstall_colorButton.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.addInstall_colorButton.StateCommon.Back.Color2 = System.Drawing.Color.Silver;
            this.addInstall_colorButton.StateCommon.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.addInstall_colorButton.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.addInstall_colorButton.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.addInstall_colorButton.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.addInstall_colorButton.StateCommon.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.addInstall_colorButton.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.addInstall_colorButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addInstall_colorButton.StateCommon.Border.Rounding = 5;
            this.addInstall_colorButton.StateCommon.Border.Width = 3;
            this.addInstall_colorButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.addInstall_colorButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.addInstall_colorButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstall_colorButton.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.addInstall_colorButton.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.addInstall_colorButton.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstall_colorButton.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.addInstall_colorButton.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.addInstall_colorButton.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.addInstall_colorButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addInstall_colorButton.StateTracking.Border.Rounding = 5;
            this.addInstall_colorButton.StateTracking.Border.Width = 3;
            this.addInstall_colorButton.TabIndex = 18;
            this.addInstall_colorButton.Values.Text = "Choose Color";
            this.addInstall_colorButton.Click += new System.EventHandler(this.kryptonButton1_Click_1);
            // 
            // addInstall_noMCP
            // 
            this.addInstall_noMCP.Location = new System.Drawing.Point(32, 439);
            this.addInstall_noMCP.Name = "addInstall_noMCP";
            this.addInstall_noMCP.Size = new System.Drawing.Size(101, 19);
            this.addInstall_noMCP.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.addInstall_noMCP.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.addInstall_noMCP.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstall_noMCP.TabIndex = 17;
            this.addInstall_noMCP.Values.Text = "Disable MCP";
            // 
            // addInstall_injectMemoryFix
            // 
            this.addInstall_injectMemoryFix.Location = new System.Drawing.Point(32, 347);
            this.addInstall_injectMemoryFix.Name = "addInstall_injectMemoryFix";
            this.addInstall_injectMemoryFix.Size = new System.Drawing.Size(166, 19);
            this.addInstall_injectMemoryFix.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.addInstall_injectMemoryFix.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.addInstall_injectMemoryFix.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstall_injectMemoryFix.TabIndex = 16;
            this.addInstall_injectMemoryFix.Values.Text = "Inject: Memory Leak Fix";
            // 
            // addInstall_injectConsole
            // 
            this.addInstall_injectConsole.Checked = true;
            this.addInstall_injectConsole.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addInstall_injectConsole.Location = new System.Drawing.Point(32, 322);
            this.addInstall_injectConsole.Name = "addInstall_injectConsole";
            this.addInstall_injectConsole.Size = new System.Drawing.Size(191, 19);
            this.addInstall_injectConsole.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.addInstall_injectConsole.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.addInstall_injectConsole.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstall_injectConsole.TabIndex = 15;
            this.addInstall_injectConsole.Values.Text = "Inject: FN-Shipping Console";
            // 
            // addInstall_injectClient
            // 
            this.addInstall_injectClient.Location = new System.Drawing.Point(32, 297);
            this.addInstall_injectClient.Name = "addInstall_injectClient";
            this.addInstall_injectClient.Size = new System.Drawing.Size(152, 19);
            this.addInstall_injectClient.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.addInstall_injectClient.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.addInstall_injectClient.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstall_injectClient.TabIndex = 14;
            this.addInstall_injectClient.Values.Text = "Inject: Rift Multiplayer";
            // 
            // addInstall_injectYosemite
            // 
            this.addInstall_injectYosemite.Checked = true;
            this.addInstall_injectYosemite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addInstall_injectYosemite.Location = new System.Drawing.Point(32, 272);
            this.addInstall_injectYosemite.Name = "addInstall_injectYosemite";
            this.addInstall_injectYosemite.Size = new System.Drawing.Size(119, 19);
            this.addInstall_injectYosemite.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.addInstall_injectYosemite.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.addInstall_injectYosemite.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstall_injectYosemite.TabIndex = 13;
            this.addInstall_injectYosemite.Values.Text = "Inject: Yosemite";
            // 
            // addInstall_injectJaguar
            // 
            this.addInstall_injectJaguar.Checked = true;
            this.addInstall_injectJaguar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addInstall_injectJaguar.Location = new System.Drawing.Point(32, 247);
            this.addInstall_injectJaguar.Name = "addInstall_injectJaguar";
            this.addInstall_injectJaguar.Size = new System.Drawing.Size(104, 19);
            this.addInstall_injectJaguar.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.addInstall_injectJaguar.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.addInstall_injectJaguar.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstall_injectJaguar.TabIndex = 12;
            this.addInstall_injectJaguar.Values.Text = "Inject: Jaguar";
            // 
            // addInstall_useLawin
            // 
            this.addInstall_useLawin.Checked = true;
            this.addInstall_useLawin.Location = new System.Drawing.Point(32, 414);
            this.addInstall_useLawin.Name = "addInstall_useLawin";
            this.addInstall_useLawin.Size = new System.Drawing.Size(119, 19);
            this.addInstall_useLawin.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.addInstall_useLawin.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.addInstall_useLawin.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstall_useLawin.TabIndex = 11;
            this.addInstall_useLawin.Values.Text = "Use Lawin MCP";
            // 
            // addInstall_useHarmony
            // 
            this.addInstall_useHarmony.Location = new System.Drawing.Point(32, 389);
            this.addInstall_useHarmony.Name = "addInstall_useHarmony";
            this.addInstall_useHarmony.Size = new System.Drawing.Size(138, 19);
            this.addInstall_useHarmony.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.addInstall_useHarmony.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.addInstall_useHarmony.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstall_useHarmony.TabIndex = 10;
            this.addInstall_useHarmony.Values.Text = "Use Harmony MCP";
            // 
            // addInstall_createButton
            // 
            this.addInstall_createButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb;
            this.addInstall_createButton.Location = new System.Drawing.Point(393, 473);
            this.addInstall_createButton.Name = "addInstall_createButton";
            this.addInstall_createButton.OverrideDefault.Back.Color1 = System.Drawing.Color.Silver;
            this.addInstall_createButton.OverrideDefault.Back.Color2 = System.Drawing.Color.Silver;
            this.addInstall_createButton.OverrideDefault.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.addInstall_createButton.OverrideDefault.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.addInstall_createButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.addInstall_createButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Black;
            this.addInstall_createButton.OverrideDefault.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.addInstall_createButton.OverrideDefault.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.addInstall_createButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addInstall_createButton.OverrideDefault.Border.Rounding = 5;
            this.addInstall_createButton.OverrideDefault.Border.Width = 3;
            this.addInstall_createButton.OverrideDefault.Content.LongText.Color1 = System.Drawing.Color.White;
            this.addInstall_createButton.OverrideDefault.Content.LongText.Color2 = System.Drawing.Color.White;
            this.addInstall_createButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.addInstall_createButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.addInstall_createButton.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstall_createButton.Size = new System.Drawing.Size(130, 47);
            this.addInstall_createButton.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.addInstall_createButton.StateCommon.Back.Color2 = System.Drawing.Color.Silver;
            this.addInstall_createButton.StateCommon.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.addInstall_createButton.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.addInstall_createButton.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.addInstall_createButton.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.addInstall_createButton.StateCommon.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.addInstall_createButton.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.addInstall_createButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addInstall_createButton.StateCommon.Border.Rounding = 5;
            this.addInstall_createButton.StateCommon.Border.Width = 3;
            this.addInstall_createButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.addInstall_createButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.addInstall_createButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstall_createButton.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.addInstall_createButton.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.addInstall_createButton.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstall_createButton.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.addInstall_createButton.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.addInstall_createButton.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.addInstall_createButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addInstall_createButton.StateTracking.Border.Rounding = 5;
            this.addInstall_createButton.StateTracking.Border.Width = 3;
            this.addInstall_createButton.TabIndex = 2;
            this.addInstall_createButton.Values.Text = "Create";
            this.addInstall_createButton.Click += new System.EventHandler(this.addInstall_createButton_Click);
            // 
            // addInstall_installPath_label
            // 
            this.addInstall_installPath_label.AutoSize = true;
            this.addInstall_installPath_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstall_installPath_label.ForeColor = System.Drawing.Color.White;
            this.addInstall_installPath_label.Location = new System.Drawing.Point(34, 183);
            this.addInstall_installPath_label.Name = "addInstall_installPath_label";
            this.addInstall_installPath_label.Size = new System.Drawing.Size(150, 16);
            this.addInstall_installPath_label.TabIndex = 4;
            this.addInstall_installPath_label.Text = "Fortnite Installation Path:";
            // 
            // addInstall_installPath
            // 
            this.addInstall_installPath.Location = new System.Drawing.Point(32, 202);
            this.addInstall_installPath.Name = "addInstall_installPath";
            this.addInstall_installPath.Size = new System.Drawing.Size(491, 29);
            this.addInstall_installPath.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.addInstall_installPath.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.addInstall_installPath.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.addInstall_installPath.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.addInstall_installPath.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addInstall_installPath.StateCommon.Border.Rounding = 5;
            this.addInstall_installPath.StateCommon.Border.Width = 2;
            this.addInstall_installPath.TabIndex = 3;
            // 
            // addInstall_profileName_label
            // 
            this.addInstall_profileName_label.AutoSize = true;
            this.addInstall_profileName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstall_profileName_label.ForeColor = System.Drawing.Color.White;
            this.addInstall_profileName_label.Location = new System.Drawing.Point(34, 117);
            this.addInstall_profileName_label.Name = "addInstall_profileName_label";
            this.addInstall_profileName_label.Size = new System.Drawing.Size(88, 16);
            this.addInstall_profileName_label.TabIndex = 2;
            this.addInstall_profileName_label.Text = "Profile Name:";
            // 
            // addInstall_profileName
            // 
            this.addInstall_profileName.Location = new System.Drawing.Point(32, 136);
            this.addInstall_profileName.Name = "addInstall_profileName";
            this.addInstall_profileName.Size = new System.Drawing.Size(491, 29);
            this.addInstall_profileName.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.addInstall_profileName.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.addInstall_profileName.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.addInstall_profileName.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.addInstall_profileName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addInstall_profileName.StateCommon.Border.Rounding = 5;
            this.addInstall_profileName.StateCommon.Border.Width = 2;
            this.addInstall_profileName.TabIndex = 1;
            // 
            // addInstall_headerLabel
            // 
            this.addInstall_headerLabel.AutoSize = true;
            this.addInstall_headerLabel.Font = new System.Drawing.Font("League Spartan", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstall_headerLabel.ForeColor = System.Drawing.Color.White;
            this.addInstall_headerLabel.Location = new System.Drawing.Point(24, 40);
            this.addInstall_headerLabel.Name = "addInstall_headerLabel";
            this.addInstall_headerLabel.Size = new System.Drawing.Size(282, 44);
            this.addInstall_headerLabel.TabIndex = 0;
            this.addInstall_headerLabel.Text = "Create Profile:";
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.textBox4);
            this.homePanel.Controls.Add(this.textBox3);
            this.homePanel.Controls.Add(this.textBox2);
            this.homePanel.Controls.Add(this.textBox1);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(66, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Padding = new System.Windows.Forms.Padding(10, 40, 10, 0);
            this.homePanel.Size = new System.Drawing.Size(1131, 560);
            this.homePanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.homePanel.StateCommon.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.homePanel.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.homePanel.StateCommon.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.homePanel.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox4.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Thistle;
            this.textBox4.Location = new System.Drawing.Point(10, 163);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(1111, 33);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "To begin, create a profile and link your Fortnite installation!";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Silver;
            this.textBox3.Location = new System.Drawing.Point(10, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(1111, 33);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "                                                                        ";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Font = new System.Drawing.Font("League Spartan", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.textBox2.Location = new System.Drawing.Point(10, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(1111, 60);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Skar Launcher";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("League Spartan", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(10, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1111, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Welcome to";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.sideBarPanel.Controls.Add(this.installBar);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(66, 560);
            this.sideBarPanel.TabIndex = 0;
            // 
            // installBar
            // 
            this.installBar.AutoScroll = true;
            this.installBar.Controls.Add(this.homeButton);
            this.installBar.Controls.Add(this.addInstallation);
            this.installBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installBar.Location = new System.Drawing.Point(0, 0);
            this.installBar.Margin = new System.Windows.Forms.Padding(0);
            this.installBar.Name = "installBar";
            this.installBar.Padding = new System.Windows.Forms.Padding(6);
            this.installBar.Size = new System.Drawing.Size(66, 560);
            this.installBar.TabIndex = 0;
            // 
            // homeButton
            // 
            this.homeButton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb;
            this.homeButton.Location = new System.Drawing.Point(9, 9);
            this.homeButton.Name = "homeButton";
            this.homeButton.OverrideDefault.Back.Color1 = System.Drawing.Color.DimGray;
            this.homeButton.OverrideDefault.Back.Color2 = System.Drawing.Color.DimGray;
            this.homeButton.OverrideDefault.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.homeButton.OverrideDefault.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.homeButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.homeButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Black;
            this.homeButton.OverrideDefault.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.homeButton.OverrideDefault.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.homeButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.homeButton.OverrideDefault.Border.Rounding = 5;
            this.homeButton.OverrideDefault.Border.Width = 3;
            this.homeButton.Size = new System.Drawing.Size(47, 47);
            this.homeButton.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
            this.homeButton.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
            this.homeButton.StateCommon.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.homeButton.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.homeButton.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.homeButton.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.homeButton.StateCommon.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.homeButton.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.homeButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.homeButton.StateCommon.Border.Rounding = 5;
            this.homeButton.StateCommon.Border.Width = 3;
            this.homeButton.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.homeButton.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.homeButton.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.homeButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.homeButton.StateTracking.Border.Rounding = 5;
            this.homeButton.StateTracking.Border.Width = 3;
            this.homeButton.TabIndex = 1;
            this.homeButton.Values.Image = global::SkarLauncher.Properties.Resources.home_x32;
            this.homeButton.Values.Text = "";
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // addInstallation
            // 
            this.addInstallation.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb;
            this.addInstallation.Location = new System.Drawing.Point(9, 62);
            this.addInstallation.Name = "addInstallation";
            this.addInstallation.OverrideDefault.Back.Color1 = System.Drawing.Color.DimGray;
            this.addInstallation.OverrideDefault.Back.Color2 = System.Drawing.Color.DimGray;
            this.addInstallation.OverrideDefault.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.addInstallation.OverrideDefault.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.addInstallation.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.addInstallation.OverrideDefault.Border.Color2 = System.Drawing.Color.Black;
            this.addInstallation.OverrideDefault.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.addInstallation.OverrideDefault.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.addInstallation.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addInstallation.OverrideDefault.Border.Rounding = 5;
            this.addInstallation.OverrideDefault.Border.Width = 3;
            this.addInstallation.Size = new System.Drawing.Size(47, 47);
            this.addInstallation.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
            this.addInstallation.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
            this.addInstallation.StateCommon.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.addInstallation.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.addInstallation.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.addInstallation.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.addInstallation.StateCommon.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.addInstallation.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.addInstallation.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addInstallation.StateCommon.Border.Rounding = 5;
            this.addInstallation.StateCommon.Border.Width = 3;
            this.addInstallation.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.addInstallation.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.addInstallation.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.addInstallation.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addInstallation.StateTracking.Border.Rounding = 5;
            this.addInstallation.StateTracking.Border.Width = 3;
            this.addInstallation.TabIndex = 0;
            this.addInstallation.Values.Image = global::SkarLauncher.Properties.Resources.add_x32;
            this.addInstallation.Values.Text = "";
            this.addInstallation.Click += new System.EventHandler(this.addInstallation_Click);
            // 
            // skarLauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1197, 588);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topBar);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "skarLauncherForm";
            this.Text = "SkarLauncher";
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addInstallPanel)).EndInit();
            this.addInstallPanel.ResumeLayout(false);
            this.addInstallPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePanel)).EndInit();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.sideBarPanel.ResumeLayout(false);
            this.installBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Button topBar_Close;
        private System.Windows.Forms.Button topBar_Minimize;
        private System.Windows.Forms.Button topBar_Maximize;
        private System.Windows.Forms.Label favicon;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel homePanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.FlowLayoutPanel installBar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton homeButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addInstallation;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel addInstallPanel;
        private System.Windows.Forms.Label addInstall_headerLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox addInstall_profileName;
        private System.Windows.Forms.Label addInstall_profileName_label;
        private System.Windows.Forms.Label addInstall_installPath_label;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox addInstall_installPath;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton addInstall_useHarmony;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton addInstall_useLawin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addInstall_createButton;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox addInstall_injectJaguar;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox addInstall_injectMemoryFix;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox addInstall_injectConsole;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox addInstall_injectClient;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox addInstall_injectYosemite;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton addInstall_noMCP;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addInstall_colorButton;
        private System.Windows.Forms.ColorDialog addInstall_colorDialog;
    }
}

