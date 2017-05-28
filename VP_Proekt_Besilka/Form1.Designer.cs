namespace VP_Proekt_Besilka
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
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.buttonPlayGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 31.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(64, 58);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(282, 75);
            this.Title.TabIndex = 1;
            this.Title.Text = "БЕСИЛКА";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(71, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "КАТЕГОРИЈА:";
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCategories.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCategories.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 32;
            this.listBoxCategories.Location = new System.Drawing.Point(77, 256);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(241, 128);
            this.listBoxCategories.TabIndex = 3;
            // 
            // buttonPlayGame
            // 
            this.buttonPlayGame.BackColor = System.Drawing.Color.DarkGray;
            this.buttonPlayGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlayGame.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayGame.ForeColor = System.Drawing.Color.White;
            this.buttonPlayGame.Location = new System.Drawing.Point(77, 451);
            this.buttonPlayGame.Name = "buttonPlayGame";
            this.buttonPlayGame.Size = new System.Drawing.Size(256, 70);
            this.buttonPlayGame.TabIndex = 4;
            this.buttonPlayGame.Text = "НОВА ИГРА";
            this.buttonPlayGame.UseVisualStyleBackColor = false;
            this.buttonPlayGame.Click += new System.EventHandler(this.buttonPlayGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VP_Proekt_Besilka.Properties.Resources.blackboard_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 635);
            this.Controls.Add(this.buttonPlayGame);
            this.Controls.Add(this.listBoxCategories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Бесилка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.Button buttonPlayGame;
    }
}

