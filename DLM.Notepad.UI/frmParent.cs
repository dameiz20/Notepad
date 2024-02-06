﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLM.Notepad.UI
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void mnuAddChild_Click(object sender, EventArgs e)
        {
            try
            {
                frmChild child = new frmChild();
                child.MdiParent = this;
                child.Show();
            }
            catch (Exception ex)
            {

                lblStatus.Text = ex.Message;
            }
        }

        private void mnuFileTileHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuFileCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren) child.Close();
        }

        private void mnuFileTileCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuFileAddMany_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <25; i++)
            {
                Random generator = new Random();
                int red, blue, green;

                frmChild child = new frmChild();
                child.MdiParent = this;
                red = generator.Next(256);
                blue = generator.Next(256);
                green = generator.Next(256);

                child.BackColor = Color.FromArgb(red, blue, green);
                child.Show();
            }
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
