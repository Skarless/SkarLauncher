using SkarLauncher.Utils;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SkarLauncher
{
    public partial class skarLauncherForm : Form
    {
        // Fields
        private int borderSize = 2;
        private Size formSize;
        private Panel currentPanel;

        public skarLauncherForm()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(34, 34, 34);
            this.homePanel.Visible = true;
            currentPanel = this.homePanel;

            foreach(Installation install in Program.getConfig().GetInstallations())
            {
                this.installBar.Controls.Add(SkarUtils.createButton(install));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void topBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void topBar_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void topBar_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                            {
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            }
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                            {
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            }
                            else //Resize diagonally to the right
                            {
                                m.Result = (IntPtr)HTTOPRIGHT;
                            }
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                            {
                                m.Result = (IntPtr)HTLEFT;
                            }
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                            {
                                m.Result = (IntPtr)HTRIGHT;
                            }
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                            {
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            }
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                            {
                                m.Result = (IntPtr)HTBOTTOM;
                            }
                            else //Resize diagonally to the right
                            {
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                            }
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                {
                    formSize = this.ClientSize;
                }

                if (wParam == SC_RESTORE)// Restored form(Before)
                {
                    this.Size = formSize;
                }
            }
            base.WndProc(ref m);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void addInstallation_Click(object sender, EventArgs e)
        {
            if (currentPanel != this.addInstallPanel)
            {
                currentPanel.Hide();
                currentPanel = this.addInstallPanel;
                this.addInstallPanel.Show();
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            if (currentPanel != this.homePanel)
            {
                currentPanel.Hide();
                currentPanel = this.homePanel;
                this.homePanel.Show();
            }
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            if (addInstall_colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color color = addInstall_colorDialog.Color;
                this.addInstall_colorButton.OverrideDefault.Back.Color1 = color;
                this.addInstall_colorButton.OverrideDefault.Back.Color2 = color;
                this.addInstall_colorButton.StateCommon.Back.Color1 = color;
                this.addInstall_colorButton.StateCommon.Back.Color2 = color;
            }
        }

        private void addInstall_createButton_Click(object sender, EventArgs e)
        {
            string profileName = addInstall_profileName.Text;
            string profilePath = addInstall_installPath.Text;

            if (profileName.Replace(" ", "").Equals(""))
            {
                MessageBox.Show("Please provide a profile name!", "Invalid Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(profilePath + "\\FortniteGame\\Binaries\\Win64")
                || !File.Exists(profilePath + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe")
                || !File.Exists(profilePath + "\\FortniteGame\\Binaries\\Win64\\FortniteLauncher.exe"))
            {
                MessageBox.Show("Please provide a valid Fortnite installation path!", "Invalid Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach(Installation install in Program.getConfig().GetInstallations())
            {
                if (install.name.Equals(profileName))
                {
                    MessageBox.Show("This name is already taken!", "Invalid Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Program.getConfig().createProfile(profilePath, profileName, this.addInstall_colorDialog.Color, this.addInstall_injectJaguar.Checked,
                this.addInstall_injectYosemite.Checked, this.addInstall_injectClient.Checked, this.addInstall_injectMemoryFix.Checked, this.addInstall_injectConsole.Checked,
                this.addInstall_useHarmony.Checked, this.addInstall_useLawin.Checked, this.addInstall_noMCP.Checked);
        }

        private void gamePanel_headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
