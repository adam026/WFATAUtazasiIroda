
namespace WFATAUtazasiIroda
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.utasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idegenvezetőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szállásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.útvonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.túraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaiDatum = new System.Windows.Forms.Label();
            this.TSMISzerkesztes = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIKereses = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utasToolStripMenuItem,
            this.idegenvezetőToolStripMenuItem,
            this.szállásToolStripMenuItem,
            this.útvonalToolStripMenuItem,
            this.túraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 87);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Túrák:";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvMain.Location = new System.Drawing.Point(27, 156);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.Size = new System.Drawing.Size(671, 181);
            this.dgvMain.TabIndex = 2;
            // 
            // utasToolStripMenuItem
            // 
            this.utasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMISzerkesztes,
            this.TSMIKereses});
            this.utasToolStripMenuItem.Image = global::WFATAUtazasiIroda.Properties.Resources.utas1;
            this.utasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.utasToolStripMenuItem.Name = "utasToolStripMenuItem";
            this.utasToolStripMenuItem.Size = new System.Drawing.Size(76, 83);
            this.utasToolStripMenuItem.Text = "Utas";
            this.utasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // idegenvezetőToolStripMenuItem
            // 
            this.idegenvezetőToolStripMenuItem.Image = global::WFATAUtazasiIroda.Properties.Resources.idegenvezeto;
            this.idegenvezetőToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.idegenvezetőToolStripMenuItem.Name = "idegenvezetőToolStripMenuItem";
            this.idegenvezetőToolStripMenuItem.Size = new System.Drawing.Size(89, 83);
            this.idegenvezetőToolStripMenuItem.Text = "Idegenvezető";
            this.idegenvezetőToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // szállásToolStripMenuItem
            // 
            this.szállásToolStripMenuItem.Image = global::WFATAUtazasiIroda.Properties.Resources.szallas;
            this.szállásToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.szállásToolStripMenuItem.Name = "szállásToolStripMenuItem";
            this.szállásToolStripMenuItem.Size = new System.Drawing.Size(76, 83);
            this.szállásToolStripMenuItem.Text = "Szállás";
            this.szállásToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // útvonalToolStripMenuItem
            // 
            this.útvonalToolStripMenuItem.Image = global::WFATAUtazasiIroda.Properties.Resources.utvonal;
            this.útvonalToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.útvonalToolStripMenuItem.Name = "útvonalToolStripMenuItem";
            this.útvonalToolStripMenuItem.Size = new System.Drawing.Size(76, 83);
            this.útvonalToolStripMenuItem.Text = "Útvonal";
            this.útvonalToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // túraToolStripMenuItem
            // 
            this.túraToolStripMenuItem.Image = global::WFATAUtazasiIroda.Properties.Resources.tura;
            this.túraToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.túraToolStripMenuItem.Name = "túraToolStripMenuItem";
            this.túraToolStripMenuItem.Size = new System.Drawing.Size(76, 83);
            this.túraToolStripMenuItem.Text = "Túra";
            this.túraToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "T_KÓD";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cél";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kezdet";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Vége";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Idegenvezető";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Szállás";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ár (Ft)";
            this.Column7.Name = "Column7";
            // 
            // lblMaiDatum
            // 
            this.lblMaiDatum.AutoSize = true;
            this.lblMaiDatum.Location = new System.Drawing.Point(24, 355);
            this.lblMaiDatum.Name = "lblMaiDatum";
            this.lblMaiDatum.Size = new System.Drawing.Size(115, 16);
            this.lblMaiDatum.TabIndex = 1;
            this.lblMaiDatum.Text = "###mai datum###.";
            // 
            // TSMISzerkesztes
            // 
            this.TSMISzerkesztes.Name = "TSMISzerkesztes";
            this.TSMISzerkesztes.Size = new System.Drawing.Size(180, 22);
            this.TSMISzerkesztes.Text = "Szerkesztés";
            this.TSMISzerkesztes.Click += new System.EventHandler(this.TSMISzerkesztes_Click);
            // 
            // TSMIKereses
            // 
            this.TSMIKereses.Name = "TSMIKereses";
            this.TSMIKereses.Size = new System.Drawing.Size(180, 22);
            this.TSMIKereses.Text = "Keresés";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 385);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.lblMaiDatum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Text = "Napos Oldal Utazási Iroda";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ToolStripMenuItem utasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMISzerkesztes;
        private System.Windows.Forms.ToolStripMenuItem TSMIKereses;
        private System.Windows.Forms.ToolStripMenuItem idegenvezetőToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szállásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem útvonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem túraToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label lblMaiDatum;
    }
}

