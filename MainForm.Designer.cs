
namespace AK8PO
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rozpisLabel = new System.Windows.Forms.Label();
            this.sezonaLabel = new System.Windows.Forms.Label();
            this.pridatRozpisButton = new System.Windows.Forms.Button();
            this.tabulkyButton = new System.Windows.Forms.Button();
            this.zapisyButton = new System.Windows.Forms.Button();
            this.uspesnostiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // rozpisLabel
            // 
            resources.ApplyResources(this.rozpisLabel, "rozpisLabel");
            this.rozpisLabel.Name = "rozpisLabel";
            // 
            // sezonaLabel
            // 
            resources.ApplyResources(this.sezonaLabel, "sezonaLabel");
            this.sezonaLabel.Name = "sezonaLabel";
            // 
            // pridatRozpisButton
            // 
            this.pridatRozpisButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.pridatRozpisButton, "pridatRozpisButton");
            this.pridatRozpisButton.Name = "pridatRozpisButton";
            this.pridatRozpisButton.UseVisualStyleBackColor = false;
            this.pridatRozpisButton.Click += new System.EventHandler(this.pridatRozpisButton_Click);
            // 
            // tabulkyButton
            // 
            resources.ApplyResources(this.tabulkyButton, "tabulkyButton");
            this.tabulkyButton.Name = "tabulkyButton";
            this.tabulkyButton.UseVisualStyleBackColor = true;
            // 
            // zapisyButton
            // 
            resources.ApplyResources(this.zapisyButton, "zapisyButton");
            this.zapisyButton.Name = "zapisyButton";
            this.zapisyButton.UseVisualStyleBackColor = true;
            // 
            // uspesnostiButton
            // 
            resources.ApplyResources(this.uspesnostiButton, "uspesnostiButton");
            this.uspesnostiButton.Name = "uspesnostiButton";
            this.uspesnostiButton.UseVisualStyleBackColor = true;
            this.uspesnostiButton.Click += new System.EventHandler(this.uspesnostiButton_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uspesnostiButton);
            this.Controls.Add(this.zapisyButton);
            this.Controls.Add(this.tabulkyButton);
            this.Controls.Add(this.pridatRozpisButton);
            this.Controls.Add(this.sezonaLabel);
            this.Controls.Add(this.rozpisLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rozpisLabel;
        private System.Windows.Forms.Label sezonaLabel;
        private System.Windows.Forms.Button pridatRozpisButton;
        private System.Windows.Forms.Button tabulkyButton;
        private System.Windows.Forms.Button zapisyButton;
        private System.Windows.Forms.Button uspesnostiButton;
    }
}

