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
            lblInstructions.Text = "This is where your instructions will load...";
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
                    lblInstructions.Text = "Below are some of the basic movements you will be seeing throughout this tutorial:" +
                        "\n The i's will sometimes be replaced with apostrophes (') to recognize counterclockwise";
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
                    lblInstructions.Text = "The first step to completing any Rubik's Cube is to create the Cross!" +
                        "\n This can be done with any side for starting off, but for this tutorial we will be using the white side." +
                        "\n Below are examples of a good cross vs. a bad cross as you want to match the colors in the middle on each side!";
                    pbxSolution.Visible = false;
                    pbxCross.Visible = true;
                    step++;
                    break;
                case 5:
                    lblInstructions.Text = "The next major step is to fill in the top corners to complete your first side!" +
                        "\n This can be done with the following movements with the Rubik's Cube facing toward you if you are having trouble." +
                        "\n If you are still struggling, make sure the white square you are trying to move is in the actual panes you are moving in these motions.";
                    pbxCross.Visible = false;
                    pbxSide1Movements.Visible = true;
                    step++;
                    break;
                case 6:
                    lblInstructions.Text = "Remember that the side must match the colors in the middle otherwise it will not match up later on in the tutorial!";
                    pbxSide1Movements.Visible = false;
                    pbxSide1Correct.Visible = true;
                    step++;
                    break;
                case 7:
                    lblInstructions.Text = "The next major step is to create the second layers on top of the layer that is one color connected to your filled in side." +
                        "\n We will be doing something similar to what is listed below:";
                    pbxSide1Correct.Visible = false;
                    pbxSecondLayer.Visible = true;
                    step++;
                    break;
                case 8:
                    lblInstructions.Text = "In order to move those tiles to the correct position, you can follow the movements listed below." +
                        "\n If some of the corresponding tiles you require to move into those spots are already there but backwards, you can also do this motion to help move them.";
                    pbxSecondLayer.Visible = false;
                    pbxSecondLayerMotions.Visible = true;
                    step++;
                    break;
                case 9:
                    lblInstructions.Text = "If some of the tiles you are trying to move need to go the opposite direction from the prior step, " +
                        "hopefully this diagram can help you move them in the right direction" +
                        "\n Remember that if an edge piece is orienting the wrong way then just redo the algorithm to move it back in order to replace it the right direction." +
                        "\n If you run into an issue where you need to go left instead of right, just press the previous button to see the prior movement.";
                    pbxSecondLayerMotions.Visible = false;
                    pbxSecondLayerRight.Visible = true;
                    step++;
                    break;
                case 11:
                    step++;
                    break;
                case 12:
                    step++;
                    break;
                case 13:
                    step++;
                    break;
                case 14:
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
                    pbxCross.Visible = false;
                    pbxSolution.Visible = true;
                    step--;
                    break;
                case 6:
                    lblInstructions.Text = "The first step to completing any Rubik's Cube is to create the Cross " +
                        "\n This can be done with any side for starting off, but for this tutorial we will be using the white side" +
                        "\n Below are examples of a good cross vs a bad cross as you want to match the colors in the middle on each side";
                    pbxSolution.Visible = false;
                    pbxCross.Visible = true;
                    step--;
                    break;
                case 7:
                    break;
            }
        }
    }
}
