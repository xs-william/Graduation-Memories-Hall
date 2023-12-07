using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny;
using Sunny.UI;

namespace Forms
{
    public partial class Introduce : UIForm
    {
        public Introduce()
        {
            InitializeComponent();
        }

        private void uiLinkLabel1_Click(object sender, EventArgs e)
        {
            uiLinkLabel1.LinkVisited = true;
            Process.Start("IExplore", "https://gitee.com/CodeLover-Xiao");
        }

        private void uiLinkLabel2_Click(object sender, EventArgs e)
        {
            uiLinkLabel2.LinkVisited = true;
            Process.Start("IExplore", "https://gitee.com/hhazj-X");
        }
    }
}
