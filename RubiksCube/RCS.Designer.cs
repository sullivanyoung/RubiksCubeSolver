
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxRubiksCube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMotions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCross)).BeginInit();
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
            this.lblInstructions.Text = "This is where your instructions will load...";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInstructions.Visible = false;
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
            // RCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 598);
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
            this.ResumeLayout(false);

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
    }
}

