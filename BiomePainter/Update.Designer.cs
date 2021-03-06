﻿namespace BiomePainter
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.btnBlocks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBiomes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProgram = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picBlocks = new System.Windows.Forms.PictureBox();
            this.picBiomes = new System.Windows.Forms.PictureBox();
            this.picProgram = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBiomes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProgram)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBlocks
            // 
            this.btnBlocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBlocks.Location = new System.Drawing.Point(75, 44);
            this.btnBlocks.Name = "btnBlocks";
            this.btnBlocks.Size = new System.Drawing.Size(448, 23);
            this.btnBlocks.TabIndex = 0;
            this.btnBlocks.Text = "Check for updates to default block colors";
            this.btnBlocks.UseVisualStyleBackColor = true;
            this.btnBlocks.Click += new System.EventHandler(this.btnBlocks_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blocks.default.txt contains colors used in the overhead terrain map. Please add c" +
    "ustom color settings to Blocks.user.txt which can be opened from the Settings me" +
    "nu.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(75, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // btnBiomes
            // 
            this.btnBiomes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBiomes.Location = new System.Drawing.Point(75, 127);
            this.btnBiomes.Name = "btnBiomes";
            this.btnBiomes.Size = new System.Drawing.Size(448, 23);
            this.btnBiomes.TabIndex = 3;
            this.btnBiomes.Text = "Check for updates to biome definitions and colors";
            this.btnBiomes.UseVisualStyleBackColor = true;
            this.btnBiomes.Click += new System.EventHandler(this.btnBiomes_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(75, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(448, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "New versions of Biome Painter won\'t be downloaded automatically, but here you can" +
    " check for an update and open the download page in your web browser.";
            // 
            // btnProgram
            // 
            this.btnProgram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProgram.Location = new System.Drawing.Point(75, 199);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(448, 23);
            this.btnProgram.TabIndex = 5;
            this.btnProgram.Text = "Check for Biome Painter program updates";
            this.btnProgram.UseVisualStyleBackColor = true;
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(75, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(448, 2);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(75, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(448, 2);
            this.label5.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(75, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(448, 2);
            this.label6.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(479, 239);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiomePainter.Properties.Resources.icon64;
            this.pictureBox1.Location = new System.Drawing.Point(5, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BiomePainter.Properties.Resources.biomes_default;
            this.pictureBox2.Location = new System.Drawing.Point(5, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BiomePainter.Properties.Resources.blocks_default;
            this.pictureBox3.Location = new System.Drawing.Point(5, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // picBlocks
            // 
            this.picBlocks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBlocks.Image = global::BiomePainter.Properties.Resources.q;
            this.picBlocks.Location = new System.Drawing.Point(529, 7);
            this.picBlocks.Name = "picBlocks";
            this.picBlocks.Size = new System.Drawing.Size(64, 64);
            this.picBlocks.TabIndex = 15;
            this.picBlocks.TabStop = false;
            // 
            // picBiomes
            // 
            this.picBiomes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBiomes.Image = global::BiomePainter.Properties.Resources.q;
            this.picBiomes.Location = new System.Drawing.Point(529, 82);
            this.picBiomes.Name = "picBiomes";
            this.picBiomes.Size = new System.Drawing.Size(64, 64);
            this.picBiomes.TabIndex = 14;
            this.picBiomes.TabStop = false;
            // 
            // picProgram
            // 
            this.picProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picProgram.Image = global::BiomePainter.Properties.Resources.q;
            this.picProgram.Location = new System.Drawing.Point(529, 162);
            this.picProgram.Name = "picProgram";
            this.picProgram.Size = new System.Drawing.Size(64, 64);
            this.picProgram.TabIndex = 13;
            this.picProgram.TabStop = false;
            // 
            // Update
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 268);
            this.Controls.Add(this.picBlocks);
            this.Controls.Add(this.picBiomes);
            this.Controls.Add(this.picProgram);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnProgram);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBiomes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBlocks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::BiomePainter.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Check for Updates";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBiomes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProgram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBlocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBiomes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProgram;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picBlocks;
        private System.Windows.Forms.PictureBox picBiomes;
        private System.Windows.Forms.PictureBox picProgram;
    }
}