namespace leProjetBalle2PingPong.dossierFenBalle
{
    partial class codeFenBalle
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
            panel1 = new Panel();
            bBalle = new Button();
            bStart = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(bBalle);
            panel1.Location = new Point(12, 12);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 500);
            panel1.TabIndex = 0;
            // 
            // bBalle
            // 
            bBalle.BackColor = Color.Tomato;
            bBalle.ForeColor = Color.Tomato;
            bBalle.Location = new Point(245, 490);
            bBalle.Name = "bBalle";
            bBalle.Size = new Size(10, 10);
            bBalle.TabIndex = 0;
            bBalle.Text = "L";
            bBalle.UseVisualStyleBackColor = false;
            // 
            // bStart
            // 
            bStart.Location = new Point(12, 532);
            bStart.Name = "bStart";
            bStart.Size = new Size(94, 29);
            bStart.TabIndex = 0;
            bStart.Text = "Start";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // codeFenBalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 573);
            Controls.Add(bStart);
            Controls.Add(panel1);
            Name = "codeFenBalle";
            Text = "Balle";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bBalle;
        private Button bStart;
    }
}