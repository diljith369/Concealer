using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcealerNew
{
    public partial class ConcealerSplash : Form
    {
        public ConcealerSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(2);
            if (progressBar.Value == 100)
            {
                splashtimer.Stop();
                this.Close();
            }
        }

        private void ConcealerSplash_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath shape = new System.Drawing.Drawing2D.GraphicsPath();
            shape.AddEllipse(0, 0, this.Height, this.Height);
            this.Region = new System.Drawing.Region(shape);
        }
    }
}
