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
                    lblInstructions.Text = "Below are some of the basic movements you will be seeing throughout this tutorial:";
                    pbxMotions.Visible = true;
                    btnPrevious.Visible = true;
                    step++;
                    break;
                case 3:
                    lblInstructions.Text = "In order to complete the Rubik's Cube, we will be following the Step-By-Step solution shown below:";
                    pbxMotions.Visible = false;
                    pbxSolution.Visible = true;
                    step++;
                    break;
                case 4:
                    lblInstructions.Text = "The first step to completing any Rubik's Cube is to create the Cross " +
                        "\n This can be done with any side for starting off, but for this tutorial we will be using the white side" +
                        "\n Below are examples of a good cross vs a bad cross as you want to match the colors in the middle on each side";
                    pbxSolution.Visible = false;
                    pbxCross.Visible = true;
                    step++;
                    break;
                case 5:
                    step++;
                    break;
                case 6:
                    step++;
                    break;
                case 7:
                    step++;
                    break;


            }
        }

        private void lblInstructions_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

            switch (step)
            {
                case 3:
                    lblInstructions.Text = "To get started, it is recommended you learn basic Rubik's Cube Terminology.";
                    pbxMotions.Visible = false;
                    btnPrevious.Visible = false;
                    step--;
                    break;
                case 4:
                    lblInstructions.Text = "Below are some of the basic movements you will be seeing throughout this tutorial:";
                    pbxMotions.Visible = true;
                    step--;
                    break;
                case 5:
                    lblInstructions.Text = "In order to complete the Rubik's Cube, we will be following the Step-By-Step Solution Below:";
                    pbxMotions.Visible = false;
                    pbxSolution.Visible = true;
                    step--;
                    break;
                case 6:
                    step--;
                    break;
            }
        }
    }
}
