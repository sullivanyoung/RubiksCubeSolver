using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubiksCube
{
    public partial class RCS : Form
    {
        public int step = 1;

        public RCS()
        {
            InitializeComponent();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            pbxRubiksCube.Visible = false;
            btnBegin.Visible = false;
            btnNext.Visible = true;
            btnPrevious.Visible = true;
            lblInstructions.Visible = true;
        }

        private void RCS_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (step)
            {
                case 1:
                    lblInstructions.Text = "To get started, it is recommended you learn basic Rubik's Cube Terminology.";
                    step++;
                    break;
                case 2:
                    lblInstructions.Text = "F: front, R: right, U: up, L: left, D: down \n Clockwise Rotations \n Counterclockwise rotatons are market with an apostrophe (')";
                    
                    step++;
                    break;
            }
        }

        private void lblInstructions_Click(object sender, EventArgs e)
        {

        }
    }
}
