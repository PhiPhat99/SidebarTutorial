using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidebarTutorial
{
    public partial class Form1 : Form
    {
        DashboardForm dashboard;
        Submenu1Form submenu1;

        public Form1()
        {
            InitializeComponent();
        }

        // ตัวแปรสำหรับการขยายเมนู
        bool MenuExpand = false;

        // การเปลี่ยนแปลงเมนู (ขยายและยุบ)
        private void MenuTransition_Tick(object sender, EventArgs e)
        {
            if (MenuExpand == false) // ขยายเมนู
            {
                MenuContainer.Height += 10;
                if (MenuContainer.Height >= 167)
                {
                    MenuTransition.Stop();
                    MenuExpand = true;
                }
            }
            else // ยุบเมนู
            {
                MenuContainer.Height -= 10;
                if (MenuContainer.Height <= 54)
                {
                    MenuTransition.Stop();
                    MenuExpand = false;
                }
            }
        }

        // เริ่มการเปลี่ยนแปลงเมนู
        private void MenuBtn_Click(object sender, EventArgs e)
        {
            MenuTransition.Start();
        }

        // ตัวแปรสำหรับการขยาย sidebar
        bool SidebarExpand = true;

        // การเปลี่ยนแปลง sidebar (ขยายและยุบ)
        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (SidebarExpand) // ยุบ sidebar
            {
                Sidebar.Width -= 5;
                if (Sidebar.Width <= 45)
                {
                    SidebarTransition.Stop();
                    SidebarExpand = false;

                    // อัปเดตความกว้างของ panel ได้ที่นี่ตามต้องการ
                    DashboardPnl.Width = Sidebar.Width;
                    AboutPnl.Width = Sidebar.Width;
                    SettingsPnl.Width = Sidebar.Width;
                    ExitPnl.Width = Sidebar.Width;
                    MenuContainer.Width = Sidebar.Width;
                }
            }
            else // ขยาย sidebar
            {
                Sidebar.Width += 5;
                if (Sidebar.Width >= 240) // เงื่อนไขที่ถูกต้องเพื่อให้ sidebar ขยายได้เต็มที่
                {
                    SidebarTransition.Stop();
                    SidebarExpand = true;

                    // อัปเดตความกว้างของ panel ได้ที่นี่ตามต้องการ
                    DashboardPnl.Width = Sidebar.Width;
                    AboutPnl.Width = Sidebar.Width;
                    SettingsPnl.Width = Sidebar.Width;
                    ExitPnl.Width = Sidebar.Width;
                    MenuContainer.Width = Sidebar.Width;
                }
            }
        }

        // เริ่มการเปลี่ยนแปลงของ sidebar
        private void HamBtn_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new DashboardForm();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void Submenu1Btn_Click(object sender, EventArgs e)
        {
            if (submenu1 == null)
            {
                submenu1 = new Submenu1Form();
                submenu1.FormClosed += Submenu1_FormClosed;
                submenu1.MdiParent = this;
                submenu1.Show();
            }
            else
            {
                submenu1.Activate();
            }
        }

        private void Submenu1_FormClosed(object sender, FormClosedEventArgs e)
        {
            submenu1 = null;
        }
    }
}
