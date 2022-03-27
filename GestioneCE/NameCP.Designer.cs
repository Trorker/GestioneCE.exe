namespace GestioneCE
{
    partial class NameCP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameCP));
            this.bt_Save = new System.Windows.Forms.Button();
            this.txb_SerialNamberCP = new System.Windows.Forms.TextBox();
            this.rb_Sielte = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Enel = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(79, 64);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(238, 23);
            this.bt_Save.TabIndex = 1;
            this.bt_Save.Text = "Salva";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // txb_SerialNamberCP
            // 
            this.txb_SerialNamberCP.Location = new System.Drawing.Point(6, 18);
            this.txb_SerialNamberCP.MaxLength = 18;
            this.txb_SerialNamberCP.Name = "txb_SerialNamberCP";
            this.txb_SerialNamberCP.Size = new System.Drawing.Size(226, 20);
            this.txb_SerialNamberCP.TabIndex = 0;
            this.txb_SerialNamberCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rb_Sielte
            // 
            this.rb_Sielte.AutoSize = true;
            this.rb_Sielte.Location = new System.Drawing.Point(6, 44);
            this.rb_Sielte.Name = "rb_Sielte";
            this.rb_Sielte.Size = new System.Drawing.Size(51, 17);
            this.rb_Sielte.TabIndex = 2;
            this.rb_Sielte.Text = "Sielte";
            this.rb_Sielte.UseVisualStyleBackColor = true;
            this.rb_Sielte.CheckedChanged += new System.EventHandler(this.rb_Sielte_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Enel);
            this.groupBox1.Controls.Add(this.rb_Sielte);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(61, 75);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reso a:";
            // 
            // rb_Enel
            // 
            this.rb_Enel.AutoSize = true;
            this.rb_Enel.Checked = true;
            this.rb_Enel.Location = new System.Drawing.Point(6, 23);
            this.rb_Enel.Name = "rb_Enel";
            this.rb_Enel.Size = new System.Drawing.Size(46, 17);
            this.rb_Enel.TabIndex = 3;
            this.rb_Enel.TabStop = true;
            this.rb_Enel.Text = "Enel";
            this.rb_Enel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txb_SerialNamberCP);
            this.groupBox2.Location = new System.Drawing.Point(79, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 46);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Number";
            // 
            // NameCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 94);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NameCP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuovo Reso";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.TextBox txb_SerialNamberCP;
        private System.Windows.Forms.RadioButton rb_Sielte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Enel;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}