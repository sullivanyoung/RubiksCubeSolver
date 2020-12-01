
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxRubiksCube)).BeginInit();
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
            // 
            // RCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 598);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.pbxRubiksCube);
            this.Controls.Add(this.lblInstructions);
            this.Name = "RCS";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RCS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRubiksCube)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxRubiksCube;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
    }
}

