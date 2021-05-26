using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class fLoading : Form
    {
        public fLoading()
        {
            InitializeComponent();
        }
        DateTime TimeClose;
        void CloseForm()
        {
            TimeClose = DateTime.Now.AddMinutes(2980);
        }
        private void fLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
            mdaVideo.URL = @"D:\CKC\STUDY\Lập Trình Windows\loadingvideo.mp4";
            mdaVideo.Ctlcontrols.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timer1.Interval >=3400)
            {
                timer1.Stop();
                this.Close();
            }    
        }

        private void mdaVideo_Enter(object sender, EventArgs e)
        {

        }
    }
}
