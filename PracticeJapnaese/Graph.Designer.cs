
using PracticeJapnaese.Properties;

namespace JapanesePractice
{
    partial class Graph
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
            this.graph_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.graph_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // graph_picture
            // 
            this.graph_picture.Image = Resources.graph;
            this.graph_picture.Location = new System.Drawing.Point(0, 0);
            this.graph_picture.Name = "graph_picture";
            this.graph_picture.Size = new System.Drawing.Size(695, 487);
            this.graph_picture.TabIndex = 0;
            this.graph_picture.TabStop = false;
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 432);
            this.Controls.Add(this.graph_picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Graph";
            this.Text = "단어장";
            this.Load += new System.EventHandler(this.Graph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graph_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox graph_picture;
    }
}