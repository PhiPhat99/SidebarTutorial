namespace SidebarTutorial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.HamBtn = new System.Windows.Forms.PictureBox();
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.DashboardPnl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ExitPnl = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.AboutPnl = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.SettingsPnl = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.MenuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Submenu1Btn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Submenu2Btn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.MenuTransition = new System.Windows.Forms.Timer(this.components);
            this.SidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HamBtn)).BeginInit();
            this.Sidebar.SuspendLayout();
            this.DashboardPnl.SuspendLayout();
            this.ExitPnl.SuspendLayout();
            this.AboutPnl.SuspendLayout();
            this.SettingsPnl.SuspendLayout();
            this.MenuContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.HamBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "UI IDEAS   |   MODERN SIDEBAR TUTORIAL";
            // 
            // HamBtn
            // 
            this.HamBtn.Image = ((System.Drawing.Image)(resources.GetObject("HamBtn.Image")));
            this.HamBtn.Location = new System.Drawing.Point(5, 5);
            this.HamBtn.Name = "HamBtn";
            this.HamBtn.Size = new System.Drawing.Size(40, 40);
            this.HamBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HamBtn.TabIndex = 1;
            this.HamBtn.TabStop = false;
            this.HamBtn.Click += new System.EventHandler(this.HamBtn_Click);
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Sidebar.Controls.Add(this.DashboardPnl);
            this.Sidebar.Controls.Add(this.MenuContainer);
            this.Sidebar.Controls.Add(this.SettingsPnl);
            this.Sidebar.Controls.Add(this.AboutPnl);
            this.Sidebar.Controls.Add(this.ExitPnl);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Sidebar.Location = new System.Drawing.Point(0, 50);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Sidebar.Size = new System.Drawing.Size(240, 505);
            this.Sidebar.TabIndex = 1;
            this.Sidebar.WrapContents = false;
            // 
            // DashboardPnl
            // 
            this.DashboardPnl.Controls.Add(this.button1);
            this.DashboardPnl.Location = new System.Drawing.Point(3, 33);
            this.DashboardPnl.Name = "DashboardPnl";
            this.DashboardPnl.Size = new System.Drawing.Size(237, 54);
            this.DashboardPnl.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-18, -26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 102);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitPnl
            // 
            this.ExitPnl.Controls.Add(this.button4);
            this.ExitPnl.Location = new System.Drawing.Point(3, 384);
            this.ExitPnl.Name = "ExitPnl";
            this.ExitPnl.Size = new System.Drawing.Size(237, 54);
            this.ExitPnl.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(-18, -26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(267, 102);
            this.button4.TabIndex = 2;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // AboutPnl
            // 
            this.AboutPnl.Controls.Add(this.button5);
            this.AboutPnl.Location = new System.Drawing.Point(3, 324);
            this.AboutPnl.Name = "AboutPnl";
            this.AboutPnl.Size = new System.Drawing.Size(237, 54);
            this.AboutPnl.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(-18, -26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(267, 102);
            this.button5.TabIndex = 2;
            this.button5.Text = "About";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // SettingsPnl
            // 
            this.SettingsPnl.Controls.Add(this.button2);
            this.SettingsPnl.Location = new System.Drawing.Point(3, 264);
            this.SettingsPnl.Name = "SettingsPnl";
            this.SettingsPnl.Size = new System.Drawing.Size(237, 54);
            this.SettingsPnl.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(-18, -26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 102);
            this.button2.TabIndex = 2;
            this.button2.Text = "Settings";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // MenuContainer
            // 
            this.MenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.MenuContainer.Controls.Add(this.panel4);
            this.MenuContainer.Controls.Add(this.panel7);
            this.MenuContainer.Controls.Add(this.panel9);
            this.MenuContainer.Location = new System.Drawing.Point(0, 90);
            this.MenuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(237, 171);
            this.MenuContainer.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.MenuBtn);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 54);
            this.panel4.TabIndex = 5;
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.MenuBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.ForeColor = System.Drawing.Color.White;
            this.MenuBtn.Location = new System.Drawing.Point(-18, -26);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(267, 102);
            this.MenuBtn.TabIndex = 2;
            this.MenuBtn.Text = "Menu";
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.button6);
            this.panel7.Location = new System.Drawing.Point(0, 54);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(237, 54);
            this.panel7.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.Submenu1Btn);
            this.panel8.Location = new System.Drawing.Point(8, 8);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(237, 54);
            this.panel8.TabIndex = 7;
            // 
            // Submenu1Btn
            // 
            this.Submenu1Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.Submenu1Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submenu1Btn.ForeColor = System.Drawing.Color.White;
            this.Submenu1Btn.Location = new System.Drawing.Point(-18, -33);
            this.Submenu1Btn.Name = "Submenu1Btn";
            this.Submenu1Btn.Size = new System.Drawing.Size(267, 102);
            this.Submenu1Btn.TabIndex = 2;
            this.Submenu1Btn.Text = "Submenu 1";
            this.Submenu1Btn.UseVisualStyleBackColor = false;
            this.Submenu1Btn.Click += new System.EventHandler(this.Submenu1Btn_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(-18, -26);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(267, 102);
            this.button6.TabIndex = 2;
            this.button6.Text = "Measurement technique";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.button9);
            this.panel9.Location = new System.Drawing.Point(0, 108);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(237, 54);
            this.panel9.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.Submenu2Btn);
            this.panel10.Location = new System.Drawing.Point(8, 8);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(237, 54);
            this.panel10.TabIndex = 7;
            // 
            // Submenu2Btn
            // 
            this.Submenu2Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.Submenu2Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submenu2Btn.ForeColor = System.Drawing.Color.White;
            this.Submenu2Btn.Location = new System.Drawing.Point(-18, -33);
            this.Submenu2Btn.Name = "Submenu2Btn";
            this.Submenu2Btn.Size = new System.Drawing.Size(267, 102);
            this.Submenu2Btn.TabIndex = 2;
            this.Submenu2Btn.Text = "Submenu 2";
            this.Submenu2Btn.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(-18, -26);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(267, 102);
            this.button9.TabIndex = 2;
            this.button9.Text = "Measurement technique";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // MenuTransition
            // 
            this.MenuTransition.Interval = 10;
            this.MenuTransition.Tick += new System.EventHandler(this.MenuTransition_Tick);
            // 
            // SidebarTransition
            // 
            this.SidebarTransition.Interval = 10;
            this.SidebarTransition.Tick += new System.EventHandler(this.SidebarTransition_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HamBtn)).EndInit();
            this.Sidebar.ResumeLayout(false);
            this.DashboardPnl.ResumeLayout(false);
            this.ExitPnl.ResumeLayout(false);
            this.AboutPnl.ResumeLayout(false);
            this.SettingsPnl.ResumeLayout(false);
            this.MenuContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox HamBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel DashboardPnl;
        private System.Windows.Forms.Panel SettingsPnl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel ExitPnl;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel MenuContainer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel AboutPnl;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button Submenu1Btn;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button Submenu2Btn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Timer MenuTransition;
        private System.Windows.Forms.Timer SidebarTransition;
    }
}

