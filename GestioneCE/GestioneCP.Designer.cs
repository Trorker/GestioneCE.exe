namespace GestioneCE
{
    partial class GeneralWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralWindow));
            this.pn_General = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.author = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.topMost = new System.Windows.Forms.CheckBox();
            this.delayTimer = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_SlideShow = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_NewCP = new System.Windows.Forms.Button();
            this.bt_LoadCP = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_removeLastLine = new System.Windows.Forms.Button();
            this.btn_removeLastCE = new System.Windows.Forms.Button();
            this.txb_edit = new System.Windows.Forms.TextBox();
            this.bt_edit = new System.Windows.Forms.Button();
            this.lbl_SerialNumberCE = new System.Windows.Forms.Label();
            this.pb_barCode = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_SerialNumberCP = new System.Windows.Forms.Label();
            this.lb_SerialNumberCE = new System.Windows.Forms.ListBox();
            this.bt_insert = new System.Windows.Forms.Button();
            this.txb_serialCE = new System.Windows.Forms.TextBox();
            this.infoVersion = new System.Windows.Forms.ToolTip(this.components);
            this.pn_General.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayTimer)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_barCode)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_General
            // 
            this.pn_General.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_General.Controls.Add(this.panel2);
            this.pn_General.Controls.Add(this.panel1);
            this.pn_General.Location = new System.Drawing.Point(12, 12);
            this.pn_General.Name = "pn_General";
            this.pn_General.Size = new System.Drawing.Size(510, 387);
            this.pn_General.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.author);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.lbl_SerialNumberCE);
            this.panel2.Controls.Add(this.pb_barCode);
            this.panel2.Location = new System.Drawing.Point(246, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 387);
            this.panel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(10, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Import File Consultivare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // author
            // 
            this.author.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.author.AutoSize = true;
            this.author.BackColor = System.Drawing.Color.Transparent;
            this.author.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.Location = new System.Drawing.Point(74, 81);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(117, 16);
            this.author.TabIndex = 3;
            this.author.Text = "By Dzyuba Ruslan";
            this.infoVersion.SetToolTip(this.author, resources.GetString("author.ToolTip"));
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.topMost);
            this.groupBox1.Controls.Add(this.delayTimer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bt_SlideShow);
            this.groupBox1.Location = new System.Drawing.Point(3, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 68);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SlideShow";
            // 
            // topMost
            // 
            this.topMost.AutoSize = true;
            this.topMost.Location = new System.Drawing.Point(171, 15);
            this.topMost.Name = "topMost";
            this.topMost.Size = new System.Drawing.Size(68, 17);
            this.topMost.TabIndex = 17;
            this.topMost.Text = "TopMost";
            this.topMost.UseVisualStyleBackColor = true;
            this.topMost.CheckedChanged += new System.EventHandler(this.TopMost_CheckedChanged);
            // 
            // delayTimer
            // 
            this.delayTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delayTimer.Location = new System.Drawing.Point(65, 14);
            this.delayTimer.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.delayTimer.Name = "delayTimer";
            this.delayTimer.Size = new System.Drawing.Size(34, 20);
            this.delayTimer.TabIndex = 16;
            this.delayTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delayTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Intervallo:";
            // 
            // bt_SlideShow
            // 
            this.bt_SlideShow.Location = new System.Drawing.Point(7, 40);
            this.bt_SlideShow.Name = "bt_SlideShow";
            this.bt_SlideShow.Size = new System.Drawing.Size(245, 23);
            this.bt_SlideShow.TabIndex = 13;
            this.bt_SlideShow.Text = "Start";
            this.bt_SlideShow.UseVisualStyleBackColor = true;
            this.bt_SlideShow.Click += new System.EventHandler(this.bt_Slide_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.bt_NewCP);
            this.groupBox3.Controls.Add(this.bt_LoadCP);
            this.groupBox3.Controls.Add(this.bt_save);
            this.groupBox3.Location = new System.Drawing.Point(4, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 76);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File";
            // 
            // bt_NewCP
            // 
            this.bt_NewCP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_NewCP.Location = new System.Drawing.Point(6, 47);
            this.bt_NewCP.Name = "bt_NewCP";
            this.bt_NewCP.Size = new System.Drawing.Size(122, 23);
            this.bt_NewCP.TabIndex = 1;
            this.bt_NewCP.Text = "Nuovo";
            this.bt_NewCP.UseVisualStyleBackColor = true;
            this.bt_NewCP.Click += new System.EventHandler(this.bt_NewCP_Click);
            // 
            // bt_LoadCP
            // 
            this.bt_LoadCP.Location = new System.Drawing.Point(134, 47);
            this.bt_LoadCP.Name = "bt_LoadCP";
            this.bt_LoadCP.Size = new System.Drawing.Size(117, 23);
            this.bt_LoadCP.TabIndex = 12;
            this.bt_LoadCP.Text = "Carica";
            this.bt_LoadCP.UseVisualStyleBackColor = true;
            this.bt_LoadCP.Click += new System.EventHandler(this.bt_LoadCP_Click);
            // 
            // bt_save
            // 
            this.bt_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_save.Location = new System.Drawing.Point(6, 17);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(245, 23);
            this.bt_save.TabIndex = 11;
            this.bt_save.Text = "Salva";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_removeLastLine);
            this.groupBox2.Controls.Add(this.btn_removeLastCE);
            this.groupBox2.Controls.Add(this.txb_edit);
            this.groupBox2.Controls.Add(this.bt_edit);
            this.groupBox2.Location = new System.Drawing.Point(4, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 104);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit";
            // 
            // btn_removeLastLine
            // 
            this.btn_removeLastLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_removeLastLine.Location = new System.Drawing.Point(131, 74);
            this.btn_removeLastLine.Name = "btn_removeLastLine";
            this.btn_removeLastLine.Size = new System.Drawing.Size(120, 23);
            this.btn_removeLastLine.TabIndex = 8;
            this.btn_removeLastLine.Text = "Elimina ultimo piano";
            this.btn_removeLastLine.UseVisualStyleBackColor = true;
            this.btn_removeLastLine.Click += new System.EventHandler(this.btn_removeLastLine_Click);
            // 
            // btn_removeLastCE
            // 
            this.btn_removeLastCE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_removeLastCE.Location = new System.Drawing.Point(6, 74);
            this.btn_removeLastCE.Name = "btn_removeLastCE";
            this.btn_removeLastCE.Size = new System.Drawing.Size(120, 23);
            this.btn_removeLastCE.TabIndex = 7;
            this.btn_removeLastCE.Text = "Elimina ultimo CE";
            this.btn_removeLastCE.UseVisualStyleBackColor = true;
            this.btn_removeLastCE.Click += new System.EventHandler(this.btn_removeLastCE_Click);
            // 
            // txb_edit
            // 
            this.txb_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_edit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_edit.Location = new System.Drawing.Point(6, 19);
            this.txb_edit.MaxLength = 17;
            this.txb_edit.Name = "txb_edit";
            this.txb_edit.ReadOnly = true;
            this.txb_edit.Size = new System.Drawing.Size(245, 20);
            this.txb_edit.TabIndex = 6;
            this.txb_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_edit.Click += new System.EventHandler(this.txb_edit_Click);
            this.txb_edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_edit_KeyDown);
            this.txb_edit.Leave += new System.EventHandler(this.txb_edit_Leave);
            // 
            // bt_edit
            // 
            this.bt_edit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_edit.Location = new System.Drawing.Point(6, 45);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(245, 23);
            this.bt_edit.TabIndex = 4;
            this.bt_edit.Text = "Modifica";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // lbl_SerialNumberCE
            // 
            this.lbl_SerialNumberCE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SerialNumberCE.Location = new System.Drawing.Point(4, 1);
            this.lbl_SerialNumberCE.Name = "lbl_SerialNumberCE";
            this.lbl_SerialNumberCE.Size = new System.Drawing.Size(257, 23);
            this.lbl_SerialNumberCE.TabIndex = 14;
            this.lbl_SerialNumberCE.Text = "Serial Number CE";
            this.lbl_SerialNumberCE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_barCode
            // 
            this.pb_barCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_barCode.Location = new System.Drawing.Point(4, 27);
            this.pb_barCode.Name = "pb_barCode";
            this.pb_barCode.Size = new System.Drawing.Size(257, 70);
            this.pb_barCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_barCode.TabIndex = 10;
            this.pb_barCode.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.lbl_SerialNumberCP);
            this.panel1.Controls.Add(this.lb_SerialNumberCE);
            this.panel1.Controls.Add(this.bt_insert);
            this.panel1.Controls.Add(this.txb_serialCE);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 387);
            this.panel1.TabIndex = 8;
            // 
            // lbl_SerialNumberCP
            // 
            this.lbl_SerialNumberCP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SerialNumberCP.Location = new System.Drawing.Point(3, 1);
            this.lbl_SerialNumberCP.Name = "lbl_SerialNumberCP";
            this.lbl_SerialNumberCP.Size = new System.Drawing.Size(241, 23);
            this.lbl_SerialNumberCP.TabIndex = 6;
            this.lbl_SerialNumberCP.Text = "Serial Number CP";
            this.lbl_SerialNumberCP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_SerialNumberCP.Click += new System.EventHandler(this.lbl_SerialNumberCP_Click);
            // 
            // lb_SerialNumberCE
            // 
            this.lb_SerialNumberCE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SerialNumberCE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_SerialNumberCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_SerialNumberCE.FormattingEnabled = true;
            this.lb_SerialNumberCE.ItemHeight = 16;
            this.lb_SerialNumberCE.Location = new System.Drawing.Point(3, 27);
            this.lb_SerialNumberCE.Name = "lb_SerialNumberCE";
            this.lb_SerialNumberCE.Size = new System.Drawing.Size(241, 290);
            this.lb_SerialNumberCE.TabIndex = 2;
            this.lb_SerialNumberCE.SelectedIndexChanged += new System.EventHandler(this.lb_SerialNumberCE_SelectedIndexChanged);
            // 
            // bt_insert
            // 
            this.bt_insert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_insert.Location = new System.Drawing.Point(3, 356);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(241, 23);
            this.bt_insert.TabIndex = 3;
            this.bt_insert.Text = "Aggiungi";
            this.bt_insert.UseVisualStyleBackColor = true;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // txb_serialCE
            // 
            this.txb_serialCE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_serialCE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_serialCE.Location = new System.Drawing.Point(3, 330);
            this.txb_serialCE.MaxLength = 17;
            this.txb_serialCE.Name = "txb_serialCE";
            this.txb_serialCE.Size = new System.Drawing.Size(241, 20);
            this.txb_serialCE.TabIndex = 5;
            this.txb_serialCE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_serialCE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_serialCE_KeyDown);
            // 
            // infoVersion
            // 
            this.infoVersion.ToolTipTitle = "Version";
            // 
            // GeneralWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.pn_General);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 450);
            this.Name = "GeneralWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione CP - v0.5.6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralWindow_FormClosing);
            this.Load += new System.EventHandler(this.GeneralWindow_Load);
            this.pn_General.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayTimer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_barCode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_General;
        private System.Windows.Forms.Button bt_NewCP;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_SerialNumberCP;
        private System.Windows.Forms.ListBox lb_SerialNumberCE;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.TextBox txb_serialCE;
        private System.Windows.Forms.PictureBox pb_barCode;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_SlideShow;
        private System.Windows.Forms.Button bt_LoadCP;
        private System.Windows.Forms.Label lbl_SerialNumberCE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_removeLastCE;
        private System.Windows.Forms.TextBox txb_edit;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button btn_removeLastLine;
        private System.Windows.Forms.NumericUpDown delayTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox topMost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip infoVersion;
    }
}

