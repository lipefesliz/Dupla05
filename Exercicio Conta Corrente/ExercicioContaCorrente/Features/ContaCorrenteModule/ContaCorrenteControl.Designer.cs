﻿namespace ExercicioContaCorrente.Features.ContaCorrenteModule
{
    partial class ContaCorrenteControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listContasCorrente = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listContasCorrente
            // 
            this.listContasCorrente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listContasCorrente.FormattingEnabled = true;
            this.listContasCorrente.Location = new System.Drawing.Point(0, 0);
            this.listContasCorrente.Name = "listContasCorrente";
            this.listContasCorrente.Size = new System.Drawing.Size(531, 377);
            this.listContasCorrente.TabIndex = 0;
            // 
            // ContaCorrenteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listContasCorrente);
            this.Name = "ContaCorrenteControl";
            this.Size = new System.Drawing.Size(531, 377);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listContasCorrente;
    }
}
