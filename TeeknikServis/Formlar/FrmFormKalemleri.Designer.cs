namespace TeeknikServis.Formlar
{
    partial class FrmFormKalemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFormKalemleri));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtserinoo = new DevExpress.XtraEditors.TextEdit();
            this.txtsıranoo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtfaturid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtserinoo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsıranoo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfaturid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(1, 70);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1921, 619);
            this.gridControl1.TabIndex = 20;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(124)))), ((int)(((byte)(217)))));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(334, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 22);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "SERİ NO:";
            // 
            // BtnAra
            // 
            this.BtnAra.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnAra.Appearance.Options.UseForeColor = true;
            this.BtnAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnAra.Location = new System.Drawing.Point(1027, 12);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(187, 46);
            this.BtnAra.TabIndex = 22;
            this.BtnAra.Text = "ARA";
            this.BtnAra.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtserinoo
            // 
            this.txtserinoo.Location = new System.Drawing.Point(427, 23);
            this.txtserinoo.Name = "txtserinoo";
            this.txtserinoo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtserinoo.Properties.Appearance.Options.UseFont = true;
            this.txtserinoo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtserinoo.Properties.MaskSettings.Set("mask", "L");
            this.txtserinoo.Size = new System.Drawing.Size(193, 28);
            this.txtserinoo.TabIndex = 23;
            // 
            // txtsıranoo
            // 
            this.txtsıranoo.Location = new System.Drawing.Point(746, 23);
            this.txtsıranoo.Name = "txtsıranoo";
            this.txtsıranoo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsıranoo.Properties.Appearance.Options.UseFont = true;
            this.txtsıranoo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.txtsıranoo.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtsıranoo.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d\\d\\d");
            this.txtsıranoo.Size = new System.Drawing.Size(163, 28);
            this.txtsıranoo.TabIndex = 25;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(664, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 22);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "SIRA NO:";
            // 
            // txtfaturid
            // 
            this.txtfaturid.Location = new System.Drawing.Point(123, 23);
            this.txtfaturid.Name = "txtfaturid";
            this.txtfaturid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfaturid.Properties.Appearance.Options.UseFont = true;
            this.txtfaturid.Size = new System.Drawing.Size(182, 28);
            this.txtfaturid.TabIndex = 27;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 22);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "FATURA ID:";
            // 
            // FrmFormKalemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 686);
            this.Controls.Add(this.txtfaturid);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtsıranoo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtserinoo);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmFormKalemleri";
            this.Text = "FrmFormKalemleri";
            this.Load += new System.EventHandler(this.FrmFormKalemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtserinoo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsıranoo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfaturid.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtserinoo;
        private DevExpress.XtraEditors.TextEdit txtsıranoo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtfaturid;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnAra;
    }
}