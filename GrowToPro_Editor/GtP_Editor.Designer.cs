namespace GrowToPro_Editor
{
    partial class GtP_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GtP_Editor));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SkillSelectbox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::GrowToPro_Editor.Properties.Resources.gtp_logo_kleuren_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-28, -28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SkillSelectbox
            // 
            this.SkillSelectbox.BackColor = System.Drawing.Color.DarkViolet;
            this.SkillSelectbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SkillSelectbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillSelectbox.FormattingEnabled = true;
            this.SkillSelectbox.Items.AddRange(new object[] {
            "Selecteer soort vraag!",
            "Realistisch",
            "Artistiek",
            "Intellectueel",
            "Sociaal",
            "Ondernemend",
            "Conventioneel"});
            this.SkillSelectbox.Location = new System.Drawing.Point(51, 259);
            this.SkillSelectbox.Name = "SkillSelectbox";
            this.SkillSelectbox.Size = new System.Drawing.Size(152, 21);
            this.SkillSelectbox.TabIndex = 1;
            this.SkillSelectbox.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.SkillSelectbox.DropDownClosed += new System.EventHandler(this.comboBox1_DropDownClosed);
            
            // 
            // GtP_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::GrowToPro_Editor.Properties.Resources._47251286_abstract_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 544);
            this.Controls.Add(this.SkillSelectbox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GtP_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrowToPro Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox SkillSelectbox;
    }
}

