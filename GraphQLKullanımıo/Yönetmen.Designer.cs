namespace GraphQLKullanımıo
{
    partial class Yönetmen
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
            this.label1 = new System.Windows.Forms.Label();
            this.directorID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.directorName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.directorBirth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetmen ID: ";
            // 
            // directorID
            // 
            this.directorID.AutoSize = true;
            this.directorID.Location = new System.Drawing.Point(167, 18);
            this.directorID.Name = "directorID";
            this.directorID.Size = new System.Drawing.Size(10, 13);
            this.directorID.TabIndex = 1;
            this.directorID.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yönetmen Adı: ";
            // 
            // directorName
            // 
            this.directorName.AutoSize = true;
            this.directorName.Location = new System.Drawing.Point(167, 41);
            this.directorName.Name = "directorName";
            this.directorName.Size = new System.Drawing.Size(10, 13);
            this.directorName.TabIndex = 1;
            this.directorName.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yönetmen Doğum Tarihi: ";
            // 
            // directorBirth
            // 
            this.directorBirth.AutoSize = true;
            this.directorBirth.Location = new System.Drawing.Point(167, 68);
            this.directorBirth.Name = "directorBirth";
            this.directorBirth.Size = new System.Drawing.Size(10, 13);
            this.directorBirth.TabIndex = 1;
            this.directorBirth.Text = "-";
            // 
            // Yönetmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 101);
            this.Controls.Add(this.directorBirth);
            this.Controls.Add(this.directorName);
            this.Controls.Add(this.directorID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Yönetmen";
            this.Text = "Yönetmen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label directorID;
        public System.Windows.Forms.Label directorName;
        public System.Windows.Forms.Label directorBirth;
    }
}