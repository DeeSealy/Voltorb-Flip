namespace Voltorb_Flip
{
    partial class formGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPointTotal = new System.Windows.Forms.Label();
            this.lblPointsTitle = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThanks = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(25, 589);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 23);
            this.btnStart.TabIndex = 56;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPointTotal
            // 
            this.lblPointTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPointTotal.Location = new System.Drawing.Point(228, 604);
            this.lblPointTotal.Name = "lblPointTotal";
            this.lblPointTotal.Size = new System.Drawing.Size(200, 35);
            this.lblPointTotal.TabIndex = 58;
            this.lblPointTotal.Text = "0";
            this.lblPointTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPointsTitle
            // 
            this.lblPointsTitle.AutoSize = true;
            this.lblPointsTitle.Location = new System.Drawing.Point(308, 589);
            this.lblPointsTitle.Name = "lblPointsTitle";
            this.lblPointsTitle.Size = new System.Drawing.Size(40, 15);
            this.lblPointsTitle.TabIndex = 59;
            this.lblPointsTitle.Text = "Points";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(25, 616);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 23);
            this.btnReset.TabIndex = 60;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 15);
            this.label1.TabIndex = 62;
            this.label1.Text = "Thanks to Butterfree/Dragonfree/antialiasis for permission to link to their guide" +
    "";
            this.label1.Click += new System.EventHandler(this.Pl);
            // 
            // btnThanks
            // 
            this.btnThanks.Location = new System.Drawing.Point(532, 621);
            this.btnThanks.Name = "btnThanks";
            this.btnThanks.Size = new System.Drawing.Size(75, 23);
            this.btnThanks.TabIndex = 64;
            this.btnThanks.Text = "Thanks";
            this.btnThanks.UseVisualStyleBackColor = true;
            this.btnThanks.Click += new System.EventHandler(this.btnThanks_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(342, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(290, 23);
            this.textBox1.TabIndex = 65;
            this.textBox1.Text = "https://www.dragonflycave.com/johto/voltorb-flip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "How to Play ->";
            // 
            // formGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 645);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnThanks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblPointsTitle);
            this.Controls.Add(this.lblPointTotal);
            this.Controls.Add(this.btnStart);
            this.Name = "formGame";
            this.Text = "Voltorb Flip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblPoints6;
        private Button btnStart;
        private Label lblPointTotal;
        private Label lblPointsTitle;
        private Button btnReset;
        private Label label1;
        private Button btnThanks;
        private TextBox textBox1;
        private Label label2;
    }
}