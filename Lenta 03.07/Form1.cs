using Microsoft.Win32;
using System.Reflection;
using System.Drawing;

namespace Lenta_03._07
{
    public partial class Form1 : Form
    {
        private LabelControl _labelControl;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            

            SñreenLock();
            GetInstalledSoftware();
        }

        private void SñreenLock()
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey myAppKey = registry.OpenSubKey(@"Control Panel\Desktop");
            myAppKey.GetValue("WallPaper");
            this.BackgroundImage = Image.FromFile(myAppKey.GetValue("WallPaper").ToString());

        }

        private void GetInstalledSoftware()
        {
            int posX = 0;
            int posY = 0;
            string Software = null;
            string SoftwareKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(SoftwareKey))
            {
                foreach (string skName in rk.GetSubKeyNames())
                {
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        try
                        {
                            if (!(sk.GetValue("DisplayName") == null))
                            {
                                if (sk.GetValue("InstallLocation") == null)
                                    Software += sk.GetValue("DisplayName") + " - Install path not known\n";
                                else
                                {
                                    _labelControl = new LabelControl();
                                    _labelControl.Location = new Point(posX, posY);
                                    _labelControl.labelName.Text = sk.GetValue("DisplayName").ToString();
                                    Software = (string)sk.GetValue("DisplayIcon");
                                    Icon icon = Icon.ExtractAssociatedIcon(Software);
                                    Image image = icon.ToBitmap();
                                    _labelControl.labelPicture.Image = image;
                                    this.Controls.Add(_labelControl);
                                    posX += 70;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            
                        }
                    }
                }
            }
        }
    }
}