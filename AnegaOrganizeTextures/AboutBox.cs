using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

namespace AnegaOrganizeTextures
{
    public partial class AboutBox : Form
    {
        string version = "1.1";
        string versionDate = "2019-11-11";

        public AboutBox()
        {
            InitializeComponent();
            labelVersion.Text = string.Format("Version: {0}", version);
            labelDate.Text = string.Format("Date: {0}", versionDate);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
