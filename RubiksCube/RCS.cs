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
        public int step = 0;

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
            step++; 

            switch (step)
            {
                case 1:
                    lblInstructions.Text = "To get started, it is recommended you learn basic Rubik's Cube Terminology.";
                    pbxDone.Visible = false;
                    lblStepCount.Text = Convert.ToString(step);                 
                    break;
                case 2:
                    lblInstructions.Text = "Below are some of the basic movements you will be seeing throughout this tutorial:" +
                        "\n The i's will sometimes be replaced with apostrophes (') to recognize counterclockwise";
                    pbxMotions.Visible = true;
                    btnPrevious.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 3:
                    lblInstructions.Text = "In order to complete the Rubik's Cube, we will be following the Step-By-Step Solution below:";
                    pbxMotions.Visible = false;
                    pbxSolution.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 4:
                    lblInstructions.Text = "The first step to completing any Rubik's Cube is to create the Cross!" +
                        "\n This can be done with any side for starting off, but for this tutorial we will be using the white side." +
                        "\n Below are examples of a good cross vs. a bad cross as you want to match the colors in the middle on each side!";
                    pbxSolution.Visible = false;
                    pbxCross.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 5:
                    lblInstructions.Text = "The next major step is to fill in the top corners to complete your first side!" +
                        "\n This can be done with the following movements with the Rubik's Cube facing toward you if you are having trouble." +
                        "\n If you are still struggling, make sure the white square you are trying to move is in the actual panes you are moving in these motions." +
                        "\n Remember that the side must match the colors in the middle otherwise it will not match up later on in the tutorial!" +
                        "\n Repeat motion as many times as necessary.";
                    pbxCross.Visible = false;
                    pbxSide1Movements.Visible = true;
                    pbxSide1Correct.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 6:
                    lblInstructions.Text = "The next major step is to create the second layers on top of the layer that is one color connected to your filled in side." +
                        "\n We will be doing something similar to what is listed below:";
                    pbxSide1Correct.Visible = false;
                    pbxSide1Movements.Visible = false;
                    pbxSecondLayer.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 7:
                    lblInstructions.Text = "In order to move those tiles to the correct position, you can follow the movements listed below." +
                        "\n If some of the corresponding tiles you require to move into those spots are already there but backwards, you can also do this motion to help move them.";
                    pbxSecondLayer.Visible = false;
                    pbxSecondLayerMotions.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 8:
                    lblInstructions.Text = "If some of the tiles you are trying to move need to go the opposite direction from the prior step, " +
                        "hopefully this diagram can help you move them in the right direction" +
                        "\n Remember that if an edge piece is orienting the wrong way then just redo the algorithm to move it back in order to replace it the right direction." +
                        "\n If you run into an issue where you need to go left instead of right, just press the previous button to see the prior movement.";
                    pbxSecondLayerMotions.Visible = false;
                    pbxSecondLayerRight.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 9:
                    lblInstructions.Text = "The next major step is creating the yellow cross on the opposite site from the completed white side." +
                        "\n You can have three possible patters on the yellow side. " +
                        "\n You can use this algorithm to go from one state to the next";
                    pbxSecondLayerRight.Visible = false;
                    pbxMakeYellowCross.Visible = true;
                    pbxOrientYellowCross.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 10:
                    lblInstructions.Text = "After making the yellow cross on the top side of the cube you need to finish the yellow side." +
                        "\n You can do so by completing the algorithm below:" +
                        "\n You may have to do this multiple times in order to get the tiles in the right orientation.";
                    pbxMakeYellowCross.Visible = false;
                    pbxOrientYellowCross.Visible = false;
                    pbxFinishYellowSide.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 11:
                    lblInstructions.Text = "Now we are on to solving the final layer!" +
                        "\n Hold the Rubik's Cube with the completed yellow side facing up." +
                        "\n If the corners' colors match the coresponding side colors on each side you are good to proceed to the next step." +
                        "\n If they are not, follow the alogrithm listed below to move the corners in the right location.";
                    pbxFinishYellowSide.Visible = false;
                    pbxFinalCorners.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 12:
                    lblInstructions.Text = "THE FINAL STEP!" +
                        "\n You can just repeat the alogrithm below and eventually the cube will be complete! If not, try to trace your steps back to a step looks like your cube.";
                    pbxFinalCorners.Visible = false;
                    pbxFinish.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 13:
                    lblInstructions.Text = "CONGRATULATIONS, YOU FINSIHED THE RUBIK'S CUBE!";
                    pbxFinish.Visible = false;
                    pbxDone.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    btnNext.Visible = false;
                    btnRestart.Visible = true;
                    break;
            }
        }

        private void lblInstructions_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            step--;

            switch (step)
            {
                case 1:
                    lblInstructions.Text = "To get started, it is recommended you learn basic Rubik's Cube Terminology.";
                    pbxMotions.Visible = false;
                    btnPrevious.Visible = false;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 2:
                    lblInstructions.Text = "Below are some of the basic movements you will be seeing throughout this tutorial:" +
                        "\n The i's will sometimes be replaced with apostrophes (') to recognize counterclockwise";
                    pbxMotions.Visible = true;
                    pbxSolution.Visible = false;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 3:
                    lblInstructions.Text = "In order to complete the Rubik's Cube, we will be following the Step-By-Step Solution below:";
                    pbxCross.Visible = false;
                    pbxSolution.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 4:
                    lblInstructions.Text = "The first step to completing any Rubik's Cube is to create the Cross!" +
                        "\n This can be done with any side for starting off, but for this tutorial we will be using the white side." +
                        "\n Below are examples of a good cross vs. a bad cross as you want to match the colors in the middle on each side!";
                    pbxSide1Movements.Visible = false;
                    pbxCross.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 5:
                    lblInstructions.Text = "The next major step is to fill in the top corners to complete your first side!" +
                        "\n This can be done with the following movements with the Rubik's Cube facing toward you if you are having trouble." +
                        "\n If you are still struggling, make sure the white square you are trying to move is in the actual panes you are moving in these motions." +
                        "\n Remember that the side must match the colors in the middle otherwise it will not match up later on in the tutorial!" +
                        "\n Repeat motion as many times as necessary.";
                    pbxSecondLayer.Visible = false;
                    pbxSide1Movements.Visible = true;
                    pbxSide1Correct.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 6:
                    lblInstructions.Text = "The next major step is to create the second layers on top of the layer that is one color connected to your filled in side." +
                        "\n We will be doing something similar to what is listed below:";
                    pbxSecondLayerMotions.Visible = false;
                    pbxSecondLayer.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 7:
                    lblInstructions.Text = "In order to move those tiles to the correct position, you can follow the movements listed below." +
                        "\n If some of the corresponding tiles you require to move into those spots are already there but backwards, you can also do this motion to help move them.";
                    pbxSecondLayerRight.Visible = false;
                    pbxSecondLayerMotions.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 8:
                    lblInstructions.Text = "If some of the tiles you are trying to move need to go the opposite direction from the prior step, " +
                        "hopefully this diagram can help you move them in the right direction" +
                        "\n Remember that if an edge piece is orienting the wrong way then just redo the algorithm to move it back in order to replace it the right direction." +
                        "\n If you run into an issue where you need to go left instead of right, just press the previous button to see the prior movement.";
                    pbxMakeYellowCross.Visible = false;
                    pbxOrientYellowCross.Visible = false;
                    pbxSecondLayerRight.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 9:
                    lblInstructions.Text = "The next major step is creating the yellow cross on the opposite site from the completed white side." +
                        "\n You can have three possible patters on the yellow side. " +
                        "\n You can use this algorithm to go from one state to the next";
                    pbxFinishYellowSide.Visible = false;
                    pbxMakeYellowCross.Visible = true;
                    pbxOrientYellowCross.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 10:
                    lblInstructions.Text = "After making the yellow cross on the top side of the cube you need to finish the yellow side." +
                        "\n You can do so by completing the algorithm below:" +
                        "\n You may have to do this multiple times in order to get the tiles in the right orientation.";
                    pbxFinalCorners.Visible = false;
                    pbxFinishYellowSide.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 11:
                    lblInstructions.Text = "Now we are on to solving the final layer!" +
                        "\n Hold the Rubik's Cube with the completed yellow side facing up." +
                        "\n If the corners' colors match the coresponding side colors on each side you are good to proceed to the next step." +
                        "\n If they are not, follow the alogrithm listed below to move the corners in the right location.";
                    pbxFinish.Visible = false;
                    pbxFinalCorners.Visible = true;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
                case 12:
                    lblInstructions.Text = "THE FINAL STEP!" +
                        "\n You can just repeat the alogrithm below and eventually the cube will be complete! If not, try to trace your steps back to a step looks like your cube.";
                    pbxDone.Visible = false;
                    pbxFinish.Visible = true;
                    btnNext.Visible = true;
                    btnRestart.Visible = false;
                    lblStepCount.Text = Convert.ToString(step);
                    break;
            }


        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            step = 0;
            btnBegin.Visible = true;
            pbxRubiksCube.Visible = true;
            pbxDone.Visible = false;
            btnPrevious.Visible = false;
            btnRestart.Visible = false;
            lblStepCount.Text = "";
            lblInstructions.Text = "";
        }
    }
}
