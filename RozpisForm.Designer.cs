
namespace AK8PO
{
    partial class RozpisForm
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RozpisForm));
            this.label1 = new System.Windows.Forms.Label();
            this.muzstvoACheckBox = new System.Windows.Forms.CheckBox();
            this.muzstvoBCheckBox = new System.Windows.Forms.CheckBox();
            this.muzstvoCCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nahraj .txt soubor s daty rozpisu soutěže:";
            // 
            // muzstvoACheckBox
            // 
            this.muzstvoACheckBox.AutoSize = true;
            this.muzstvoACheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.muzstvoACheckBox.Location = new System.Drawing.Point(29, 65);
            this.muzstvoACheckBox.Name = "muzstvoACheckBox";
            this.muzstvoACheckBox.Size = new System.Drawing.Size(101, 22);
            this.muzstvoACheckBox.TabIndex = 4;
            this.muzstvoACheckBox.Text = "Mužstvo A:";
            this.muzstvoACheckBox.UseVisualStyleBackColor = true;
            // 
            // muzstvoBCheckBox
            // 
            this.muzstvoBCheckBox.AutoSize = true;
            this.muzstvoBCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.muzstvoBCheckBox.Location = new System.Drawing.Point(29, 105);
            this.muzstvoBCheckBox.Name = "muzstvoBCheckBox";
            this.muzstvoBCheckBox.Size = new System.Drawing.Size(102, 22);
            this.muzstvoBCheckBox.TabIndex = 5;
            this.muzstvoBCheckBox.Text = "Mužstvo B:";
            this.muzstvoBCheckBox.UseVisualStyleBackColor = true;
            // 
            // muzstvoCCheckBox
            // 
            this.muzstvoCCheckBox.AutoSize = true;
            this.muzstvoCCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.muzstvoCCheckBox.Location = new System.Drawing.Point(28, 145);
            this.muzstvoCCheckBox.Name = "muzstvoCCheckBox";
            this.muzstvoCCheckBox.Size = new System.Drawing.Size(103, 22);
            this.muzstvoCCheckBox.TabIndex = 6;
            this.muzstvoCCheckBox.Text = "Mužstvo C:";
            this.muzstvoCCheckBox.UseVisualStyleBackColor = true;
            // 
            // RozpisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 301);
            this.Controls.Add(this.muzstvoCCheckBox);
            this.Controls.Add(this.muzstvoBCheckBox);
            this.Controls.Add(this.muzstvoACheckBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RozpisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roupis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox muzstvoACheckBox;
        private System.Windows.Forms.CheckBox muzstvoBCheckBox;
        private System.Windows.Forms.CheckBox muzstvoCCheckBox;
    }
}