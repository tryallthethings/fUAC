namespace FUAC
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.DisableUAC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisableUAC
            // 
            this.DisableUAC.Location = new System.Drawing.Point(350, 341);
            this.DisableUAC.Name = "DisableUAC";
            this.DisableUAC.Size = new System.Drawing.Size(149, 26);
            this.DisableUAC.TabIndex = 0;
            this.DisableUAC.Text = "Disable UAC";
            this.DisableUAC.UseVisualStyleBackColor = true;
            this.DisableUAC.Click += new System.EventHandler(this.DisableUAC_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fUAC.Properties.Resources._62970767;
            this.ClientSize = new System.Drawing.Size(498, 366);
            this.Controls.Add(this.DisableUAC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(514, 404);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(514, 404);
            this.Name = "Menu";
            this.Text = "fUAC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DisableUAC;
    }
}

