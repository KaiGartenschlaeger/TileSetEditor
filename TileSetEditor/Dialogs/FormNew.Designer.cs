namespace TileSetEditor.Dialogs
{
    partial class FormNew
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
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTileSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPreset = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPreset = new System.Windows.Forms.Button();
            this.menuPreset = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mniDeletePreset = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSavePreset = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileSize)).BeginInit();
            this.menuPreset.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(15, 25);
            this.nudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(65, 20);
            this.nudWidth.TabIndex = 1;
            this.nudWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(85, 25);
            this.nudHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(65, 20);
            this.nudHeight.TabIndex = 3;
            this.nudHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Breite";
            // 
            // nudTileSize
            // 
            this.nudTileSize.Location = new System.Drawing.Point(174, 25);
            this.nudTileSize.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudTileSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudTileSize.Name = "nudTileSize";
            this.nudTileSize.Size = new System.Drawing.Size(65, 20);
            this.nudTileSize.TabIndex = 5;
            this.nudTileSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kachelgröße";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(179, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(93, 129);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 28);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Höhee";
            // 
            // cbxPreset
            // 
            this.cbxPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPreset.FormattingEnabled = true;
            this.cbxPreset.Location = new System.Drawing.Point(15, 74);
            this.cbxPreset.Name = "cbxPreset";
            this.cbxPreset.Size = new System.Drawing.Size(204, 21);
            this.cbxPreset.TabIndex = 8;
            this.cbxPreset.SelectedIndexChanged += new System.EventHandler(this.cbxPreset_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "&Vorgabe";
            // 
            // btnPreset
            // 
            this.btnPreset.Location = new System.Drawing.Point(225, 74);
            this.btnPreset.Name = "btnPreset";
            this.btnPreset.Size = new System.Drawing.Size(34, 21);
            this.btnPreset.TabIndex = 10;
            this.btnPreset.Text = "...";
            this.btnPreset.UseVisualStyleBackColor = true;
            this.btnPreset.Click += new System.EventHandler(this.btnPreset_Click);
            // 
            // menuPreset
            // 
            this.menuPreset.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSavePreset,
            this.mniDeletePreset});
            this.menuPreset.Name = "menuPreset";
            this.menuPreset.Size = new System.Drawing.Size(208, 70);
            this.menuPreset.Opening += new System.ComponentModel.CancelEventHandler(this.menuPreset_Opening);
            // 
            // mniDeletePreset
            // 
            this.mniDeletePreset.Name = "mniDeletePreset";
            this.mniDeletePreset.Size = new System.Drawing.Size(207, 22);
            this.mniDeletePreset.Text = "Vorgabe löschen";
            this.mniDeletePreset.Click += new System.EventHandler(this.mniDeletePreset_Click);
            // 
            // mniSavePreset
            // 
            this.mniSavePreset.Name = "mniSavePreset";
            this.mniSavePreset.Size = new System.Drawing.Size(207, 22);
            this.mniSavePreset.Text = "Als Vorgabe speichern";
            this.mniSavePreset.Click += new System.EventHandler(this.mniSavePreset_Click);
            // 
            // FormNew
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(271, 169);
            this.Controls.Add(this.btnPreset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxPreset);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudTileSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.nudWidth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormNew";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Neues Tileset";
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileSize)).EndInit();
            this.menuPreset.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTileSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPreset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPreset;
        private System.Windows.Forms.ContextMenuStrip menuPreset;
        private System.Windows.Forms.ToolStripMenuItem mniSavePreset;
        private System.Windows.Forms.ToolStripMenuItem mniDeletePreset;
    }
}