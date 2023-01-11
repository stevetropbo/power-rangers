
namespace gsbRapports
{
    partial class Form2
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
            this.grpFamille = new System.Windows.Forms.GroupBox();
            this.lblFamille = new System.Windows.Forms.Label();
            this.cbFamille = new System.Windows.Forms.ComboBox();
            this.grpFamille.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFamille
            // 
            this.grpFamille.Controls.Add(this.cbFamille);
            this.grpFamille.Controls.Add(this.lblFamille);
            this.grpFamille.Location = new System.Drawing.Point(13, 13);
            this.grpFamille.Name = "grpFamille";
            this.grpFamille.Size = new System.Drawing.Size(318, 196);
            this.grpFamille.TabIndex = 0;
            this.grpFamille.TabStop = false;
            this.grpFamille.Text = "Famille";
            // 
            // lblFamille
            // 
            this.lblFamille.AutoSize = true;
            this.lblFamille.Location = new System.Drawing.Point(22, 52);
            this.lblFamille.Name = "lblFamille";
            this.lblFamille.Size = new System.Drawing.Size(52, 17);
            this.lblFamille.TabIndex = 0;
            this.lblFamille.Text = "Famille";
            // 
            // cbFamille
            // 
            this.cbFamille.FormattingEnabled = true;
            this.cbFamille.Location = new System.Drawing.Point(104, 52);
            this.cbFamille.Name = "cbFamille";
            this.cbFamille.Size = new System.Drawing.Size(121, 24);
            this.cbFamille.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpFamille);
            this.Name = "Form2";
            this.Text = "Form2";
            this.grpFamille.ResumeLayout(false);
            this.grpFamille.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFamille;
        private System.Windows.Forms.Label lblFamille;
        private System.Windows.Forms.ComboBox cbFamille;
    }
}