namespace lab_2_A
{
    partial class Form1
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
            this.miniTCPanel1 = new lab_2_A.MiniTCPanel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.miniTCPanel2 = new lab_2_A.MiniTCPanel();
            this.SuspendLayout();
            // 
            // miniTCPanel1
            // 
            this.miniTCPanel1.CurrentPath = "";
            this.miniTCPanel1.Location = new System.Drawing.Point(11, 11);
            this.miniTCPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.miniTCPanel1.Name = "miniTCPanel1";
            this.miniTCPanel1.Size = new System.Drawing.Size(192, 284);
            this.miniTCPanel1.TabIndex = 0;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(171, 300);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // miniTCPanel2
            // 
            this.miniTCPanel2.CurrentPath = "";
            this.miniTCPanel2.Location = new System.Drawing.Point(216, 10);
            this.miniTCPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.miniTCPanel2.Name = "miniTCPanel2";
            this.miniTCPanel2.Size = new System.Drawing.Size(192, 284);
            this.miniTCPanel2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 469);
            this.Controls.Add(this.miniTCPanel2);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.miniTCPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MiniTCPanel miniTCPanel1;
        private System.Windows.Forms.Button btnCopy;
        private MiniTCPanel miniTCPanel2;
    }
}

