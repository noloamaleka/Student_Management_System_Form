namespace PRG_261_Project
{
    partial class Display
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display));
            this.button1 = new System.Windows.Forms.Button();
            this.btnDegree = new System.Windows.Forms.Button();
            this.btnDiploma = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDegree
            // 
            this.btnDegree.Location = new System.Drawing.Point(353, 394);
            this.btnDegree.Name = "btnDegree";
            this.btnDegree.Size = new System.Drawing.Size(90, 23);
            this.btnDegree.TabIndex = 2;
            this.btnDegree.Text = "Display Degree";
            this.btnDegree.UseVisualStyleBackColor = true;
            this.btnDegree.Click += new System.EventHandler(this.btnDegree_Click);
            // 
            // btnDiploma
            // 
            this.btnDiploma.Location = new System.Drawing.Point(465, 394);
            this.btnDiploma.Name = "btnDiploma";
            this.btnDiploma.Size = new System.Drawing.Size(90, 23);
            this.btnDiploma.TabIndex = 3;
            this.btnDiploma.Text = "Display Diploma";
            this.btnDiploma.UseVisualStyleBackColor = true;
            this.btnDiploma.Click += new System.EventHandler(this.btnDiploma_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(88, 48);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(582, 257);
            this.dgvStudents.TabIndex = 4;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(580, 394);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(90, 23);
            this.btnAll.TabIndex = 5;
            this.btnAll.Text = "Display All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnDiploma);
            this.Controls.Add(this.btnDegree);
            this.Controls.Add(this.button1);
            this.Name = "Display";
            this.Text = "Display";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Display_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDegree;
        private System.Windows.Forms.Button btnDiploma;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnAll;
    }
}