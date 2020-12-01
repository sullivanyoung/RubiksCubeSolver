
namespace RubiksCube
{
    partial class RCS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RCS));
            this.pbxRubiksCube = new System.Windows.Forms.PictureBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pbxMotions = new System.Windows.Forms.PictureBox();
            this.pbxSolution = new System.Windows.Forms.PictureBox();
            this.pbxCross = new System.Windows.Forms.PictureBox();
            this.pbxSide1Movements = new System.Windows.Forms.PictureBox();
            this.pbxSide1Correct = new System.Windows.Forms.PictureBox();
            this.pbxSecondLayer = new System.Windows.Forms.PictureBox();
            this.pbxSecondLayerMotions = new System.Windows.Forms.PictureBox();
            this.pbxSecondLayerRight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRubiksCube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMotions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSide1Movements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSide1Correct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSecondLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSecondLayerMotions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSecondLayerRight)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxRubiksCube
            // 
            this.pbxRubiksCube.Image = ((System.Drawing.Image)(resources.GetObject("pbxRubiksCube.Image")));
            this.pbxRubiksCube.InitialImage = null;
            this.pbxRubiksCube.Location = new System.Drawing.Point(296, 59);
            this.pbxRubiksCube.Name = "pbxRubiksCube";
            this.pbxRubiksCube.Size = new System.Drawing.Size(418, 425);
            this.pbxRubiksCube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxRubiksCube.TabIndex = 0;
            this.pbxRubiksCube.TabStop = false;
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(883, 540);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(113, 46);
            this.btnBegin.TabIndex = 1;
            this.btnBegin.Text = "Begin";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInstructions.Location = new System.Drawing.Point(0, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(1008, 598);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Welcome to the Rubik\'s Cube Solver!";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInstructions.Click += new System.EventHandler(this.lblInstructions_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(12, 540);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(113, 46);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(131, 540);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(113, 46);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Visible = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // pbxMotions
            // 
            this.pbxMotions.Image = ((System.Drawing.Image)(resources.GetObject("pbxMotions.Image")));
            this.pbxMotions.Location = new System.Drawing.Point(296, 59);
            this.pbxMotions.Name = "pbxMotions";
            this.pbxMotions.Size = new System.Drawing.Size(418, 425);
            this.pbxMotions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMotions.TabIndex = 5;
            this.pbxMotions.TabStop = false;
            this.pbxMotions.Visible = false;
            // 
            // pbxSolution
            // 
            this.pbxSolution.Image = ((System.Drawing.Image)(resources.GetObject("pbxSolution.Image")));
            this.pbxSolution.Location = new System.Drawing.Point(49, 50);
            this.pbxSolution.Name = "pbxSolution";
            this.pbxSolution.Size = new System.Drawing.Size(898, 447);
            this.pbxSolution.TabIndex = 6;
            this.pbxSolution.TabStop = false;
            this.pbxSolution.Visible = false;
            // 
            // pbxCross
            // 
            this.pbxCross.Image = ((System.Drawing.Image)(resources.GetObject("pbxCross.Image")));
            this.pbxCross.Location = new System.Drawing.Point(264, 148);
            this.pbxCross.Name = "pbxCross";
            this.pbxCross.Size = new System.Drawing.Size(480, 239);
            this.pbxCross.TabIndex = 7;
            this.pbxCross.TabStop = false;
            this.pbxCross.Visible = false;
            // 
            // pbxSide1Movements
            // 
            this.pbxSide1Movements.Image = ((System.Drawing.Image)(resources.GetObject("pbxSide1Movements.Image")));
            this.pbxSide1Movements.Location = new System.Drawing.Point(264, 116);
            this.pbxSide1Movements.Name = "pbxSide1Movements";
            this.pbxSide1Movements.Size = new System.Drawing.Size(480, 239);
            this.pbxSide1Movements.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxSide1Movements.TabIndex = 8;
            this.pbxSide1Movements.TabStop = false;
            this.pbxSide1Movements.Visible = false;
            // 
            // pbxSide1Correct
            // 
            this.pbxSide1Correct.Image = ((System.Drawing.Image)(resources.GetObject("pbxSide1Correct.Image")));
            this.pbxSide1Correct.Location = new System.Drawing.Point(264, 132);
            this.pbxSide1Correct.Name = "pbxSide1Correct";
            this.pbxSide1Correct.Size = new System.Drawing.Size(480, 239);
            this.pbxSide1Correct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxSide1Correct.TabIndex = 9;
            this.pbxSide1Correct.TabStop = false;
            this.pbxSide1Correct.Visible = false;
            // 
            // pbxSecondLayer
            // 
            this.pbxSecondLayer.Image = ((System.Drawing.Image)(resources.GetObject("pbxSecondLayer.Image")));
            this.pbxSecondLayer.Location = new System.Drawing.Point(290, 50);
            this.pbxSecondLayer.Name = "pbxSecondLayer";
            this.pbxSecondLayer.Size = new System.Drawing.Size(454, 453);
            this.pbxSecondLayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxSecondLayer.TabIndex = 10;
            this.pbxSecondLayer.TabStop = false;
            this.pbxSecondLayer.Visible = false;
            // 
            // pbxSecondLayerMotions
            // 
            this.pbxSecondLayerMotions.Image = ((System.Drawing.Image)(resources.GetObject("pbxSecondLayerMotions.Image")));
            this.pbxSecondLayerMotions.Location = new System.Drawing.Point(221, 156);
            this.pbxSecondLayerMotions.Name = "pbxSecondLayerMotions";
            this.pbxSecondLayerMotions.Size = new System.Drawing.Size(600, 215);
            this.pbxSecondLayerMotions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxSecondLayerMotions.TabIndex = 11;
            this.pbxSecondLayerMotions.TabStop = false;
            this.pbxSecondLayerMotions.Visible = false;
            // 
            // pbxSecondLayerRight
            // 
            this.pbxSecondLayerRight.Image = ((System.Drawing.Image)(resources.GetObject("pbxSecondLayerRight.Image")));
            this.pbxSecondLayerRight.Location = new System.Drawing.Point(181, 83);
            this.pbxSecondLayerRight.Name = "pbxSecondLayerRight";
            this.pbxSecondLayerRight.Size = new System.Drawing.Size(640, 368);
            this.pbxSecondLayerRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxSecondLayerRight.TabIndex = 12;
            this.pbxSecondLayerRight.TabStop = false;
            this.pbxSecondLayerRight.Visible = false;
            // 
            // RCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 598);
            this.Controls.Add(this.pbxSecondLayerRight);
            this.Controls.Add(this.pbxSecondLayerMotions);
            this.Controls.Add(this.pbxSecondLayer);
            this.Controls.Add(this.pbxSide1Correct);
            this.Controls.Add(this.pbxSide1Movements);
            this.Controls.Add(this.pbxCross);
            this.Controls.Add(this.pbxSolution);
            this.Controls.Add(this.pbxMotions);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.pbxRubiksCube);
            this.Controls.Add(this.lblInstructions);
            this.Name = "RCS";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RCS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRubiksCube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMotions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSide1Movements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSide1Correct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSecondLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSecondLayerMotions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSecondLayerRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxRubiksCube;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.PictureBox pbxMotions;
        private System.Windows.Forms.PictureBox pbxSolution;
        private System.Windows.Forms.PictureBox pbxCross;
        private System.Windows.Forms.PictureBox pbxSide1Movements;
        private System.Windows.Forms.PictureBox pbxSide1Correct;
        private System.Windows.Forms.PictureBox pbxSecondLayer;
        private System.Windows.Forms.PictureBox pbxSecondLayerMotions;
        private System.Windows.Forms.PictureBox pbxSecondLayerRight;
    }
}

