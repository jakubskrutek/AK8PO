﻿
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
            this.generujRozpisButton = new System.Windows.Forms.Button();
            this.rozpisZpetButton = new System.Windows.Forms.Button();
            this.openADialog = new System.Windows.Forms.OpenFileDialog();
            this.checkAPictureBox = new System.Windows.Forms.PictureBox();
            this.openCButton = new System.Windows.Forms.Button();
            this.openBButton = new System.Windows.Forms.Button();
            this.openAButton = new System.Windows.Forms.Button();
            this.checkBPictureBox = new System.Windows.Forms.PictureBox();
            this.checkCPictureBox = new System.Windows.Forms.PictureBox();
            this.rozpisListBox = new System.Windows.Forms.ListBox();
            this.generujSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.checkAPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkCPictureBox)).BeginInit();
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
            this.muzstvoBCheckBox.Location = new System.Drawing.Point(29, 111);
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
            this.muzstvoCCheckBox.Location = new System.Drawing.Point(28, 158);
            this.muzstvoCCheckBox.Name = "muzstvoCCheckBox";
            this.muzstvoCCheckBox.Size = new System.Drawing.Size(103, 22);
            this.muzstvoCCheckBox.TabIndex = 6;
            this.muzstvoCCheckBox.Text = "Mužstvo C:";
            this.muzstvoCCheckBox.UseVisualStyleBackColor = true;
            // 
            // generujRozpisButton
            // 
            this.generujRozpisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generujRozpisButton.Location = new System.Drawing.Point(51, 257);
            this.generujRozpisButton.Name = "generujRozpisButton";
            this.generujRozpisButton.Size = new System.Drawing.Size(108, 32);
            this.generujRozpisButton.TabIndex = 7;
            this.generujRozpisButton.Text = "Generuj rozpis";
            this.generujRozpisButton.UseVisualStyleBackColor = true;
            this.generujRozpisButton.Click += new System.EventHandler(this.generujRozpisButton_Click);
            // 
            // rozpisZpetButton
            // 
            this.rozpisZpetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rozpisZpetButton.Location = new System.Drawing.Point(279, 257);
            this.rozpisZpetButton.Name = "rozpisZpetButton";
            this.rozpisZpetButton.Size = new System.Drawing.Size(108, 32);
            this.rozpisZpetButton.TabIndex = 8;
            this.rozpisZpetButton.Text = "Zpět";
            this.rozpisZpetButton.UseVisualStyleBackColor = true;
            this.rozpisZpetButton.Click += new System.EventHandler(this.rozpisZpetButton_Click);
            // 
            // openADialog
            // 
            this.openADialog.FileName = "openFileDialog1";
            // 
            // checkAPictureBox
            // 
            this.checkAPictureBox.Image = global::AK8PO.Properties.Resources.check;
            this.checkAPictureBox.Location = new System.Drawing.Point(171, 62);
            this.checkAPictureBox.Name = "checkAPictureBox";
            this.checkAPictureBox.Size = new System.Drawing.Size(30, 30);
            this.checkAPictureBox.TabIndex = 12;
            this.checkAPictureBox.TabStop = false;
            this.checkAPictureBox.Visible = false;
            // 
            // openCButton
            // 
            this.openCButton.Image = global::AK8PO.Properties.Resources.openFile;
            this.openCButton.Location = new System.Drawing.Point(133, 155);
            this.openCButton.Margin = new System.Windows.Forms.Padding(2);
            this.openCButton.Name = "openCButton";
            this.openCButton.Size = new System.Drawing.Size(26, 28);
            this.openCButton.TabIndex = 11;
            this.openCButton.UseVisualStyleBackColor = true;
            this.openCButton.Click += new System.EventHandler(this.openCButton_Click);
            // 
            // openBButton
            // 
            this.openBButton.Image = global::AK8PO.Properties.Resources.openFile;
            this.openBButton.Location = new System.Drawing.Point(133, 109);
            this.openBButton.Margin = new System.Windows.Forms.Padding(2);
            this.openBButton.Name = "openBButton";
            this.openBButton.Size = new System.Drawing.Size(26, 28);
            this.openBButton.TabIndex = 10;
            this.openBButton.UseVisualStyleBackColor = true;
            this.openBButton.Click += new System.EventHandler(this.openBButton_Click);
            // 
            // openAButton
            // 
            this.openAButton.Image = global::AK8PO.Properties.Resources.openFile;
            this.openAButton.Location = new System.Drawing.Point(133, 63);
            this.openAButton.Margin = new System.Windows.Forms.Padding(2);
            this.openAButton.Name = "openAButton";
            this.openAButton.Size = new System.Drawing.Size(26, 28);
            this.openAButton.TabIndex = 9;
            this.openAButton.UseVisualStyleBackColor = true;
            this.openAButton.Click += new System.EventHandler(this.openAButton_Click);
            // 
            // checkBPictureBox
            // 
            this.checkBPictureBox.Image = global::AK8PO.Properties.Resources.check;
            this.checkBPictureBox.Location = new System.Drawing.Point(171, 108);
            this.checkBPictureBox.Name = "checkBPictureBox";
            this.checkBPictureBox.Size = new System.Drawing.Size(30, 30);
            this.checkBPictureBox.TabIndex = 12;
            this.checkBPictureBox.TabStop = false;
            this.checkBPictureBox.Visible = false;
            // 
            // checkCPictureBox
            // 
            this.checkCPictureBox.Image = global::AK8PO.Properties.Resources.check;
            this.checkCPictureBox.Location = new System.Drawing.Point(171, 153);
            this.checkCPictureBox.Name = "checkCPictureBox";
            this.checkCPictureBox.Size = new System.Drawing.Size(30, 30);
            this.checkCPictureBox.TabIndex = 12;
            this.checkCPictureBox.TabStop = false;
            this.checkCPictureBox.Visible = false;
            // 
            // rozpisListBox
            // 
            this.rozpisListBox.BackColor = System.Drawing.Color.White;
            this.rozpisListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rozpisListBox.FormattingEnabled = true;
            this.rozpisListBox.ItemHeight = 16;
            this.rozpisListBox.Location = new System.Drawing.Point(229, 62);
            this.rozpisListBox.Name = "rozpisListBox";
            this.rozpisListBox.Size = new System.Drawing.Size(179, 164);
            this.rozpisListBox.TabIndex = 13;
            // 
            // RozpisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 301);
            this.Controls.Add(this.rozpisListBox);
            this.Controls.Add(this.checkCPictureBox);
            this.Controls.Add(this.checkBPictureBox);
            this.Controls.Add(this.checkAPictureBox);
            this.Controls.Add(this.openCButton);
            this.Controls.Add(this.openBButton);
            this.Controls.Add(this.openAButton);
            this.Controls.Add(this.rozpisZpetButton);
            this.Controls.Add(this.generujRozpisButton);
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
            this.Text = "Rozpis";
            this.Load += new System.EventHandler(this.RozpisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkAPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkCPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox muzstvoACheckBox;
        private System.Windows.Forms.CheckBox muzstvoBCheckBox;
        private System.Windows.Forms.CheckBox muzstvoCCheckBox;
        private System.Windows.Forms.Button generujRozpisButton;
        private System.Windows.Forms.Button rozpisZpetButton;
        private System.Windows.Forms.Button openAButton;
        private System.Windows.Forms.Button openBButton;
        private System.Windows.Forms.Button openCButton;
        private System.Windows.Forms.OpenFileDialog openADialog;
        private System.Windows.Forms.PictureBox checkAPictureBox;
        private System.Windows.Forms.PictureBox checkBPictureBox;
        private System.Windows.Forms.PictureBox checkCPictureBox;
        private System.Windows.Forms.ListBox rozpisListBox;
        private System.Windows.Forms.SaveFileDialog generujSaveFileDialog;
    }
}