﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TS_Post_Database_Inserter
{
    public partial class MEC : Form
    {
        public MEC()
        {
            InitializeComponent();
            string master = "Master Folder has changed";
            label1.Text = master;
        }

        private void ConBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
