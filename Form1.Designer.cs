namespace TreinosJC
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
            this.lsvInfo = new System.Windows.Forms.ListView();
            this.tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdc = new System.Windows.Forms.Button();
            this.btnMst = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.txtDist = new System.Windows.Forms.TextBox();
            this.lblDist = new System.Windows.Forms.Label();
            this.lblDur = new System.Windows.Forms.Label();
            this.txtDur = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lsvInfo
            // 
            this.lsvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tipo,
            this.dist,
            this.dur});
            this.lsvInfo.HideSelection = false;
            this.lsvInfo.Location = new System.Drawing.Point(316, 21);
            this.lsvInfo.Name = "lsvInfo";
            this.lsvInfo.Size = new System.Drawing.Size(480, 257);
            this.lsvInfo.TabIndex = 0;
            this.lsvInfo.UseCompatibleStateImageBehavior = false;
            this.lsvInfo.View = System.Windows.Forms.View.Details;
            // 
            // tipo
            // 
            this.tipo.Text = "Tipo De Treino";
            this.tipo.Width = 148;
            // 
            // dist
            // 
            this.dist.Text = "Distância";
            this.dist.Width = 163;
            // 
            // dur
            // 
            this.dur.Text = "Duração";
            this.dur.Width = 164;
            // 
            // btnAdc
            // 
            this.btnAdc.Location = new System.Drawing.Point(20, 139);
            this.btnAdc.Name = "btnAdc";
            this.btnAdc.Size = new System.Drawing.Size(242, 23);
            this.btnAdc.TabIndex = 1;
            this.btnAdc.Text = "Adicionar";
            this.btnAdc.UseVisualStyleBackColor = true;
            this.btnAdc.Click += new System.EventHandler(this.btnAdc_Click);
            // 
            // btnMst
            // 
            this.btnMst.Location = new System.Drawing.Point(316, 284);
            this.btnMst.Name = "btnMst";
            this.btnMst.Size = new System.Drawing.Size(171, 23);
            this.btnMst.TabIndex = 2;
            this.btnMst.Text = "Mostrar Lista";
            this.btnMst.UseVisualStyleBackColor = true;
            this.btnMst.Click += new System.EventHandler(this.btnMst_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(493, 284);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(164, 23);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "Contagem";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(663, 285);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(133, 23);
            this.btnMedia.TabIndex = 4;
            this.btnMedia.Text = "Média";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // txtDist
            // 
            this.txtDist.Location = new System.Drawing.Point(97, 18);
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(161, 20);
            this.txtDist.TabIndex = 5;
            // 
            // lblDist
            // 
            this.lblDist.AutoSize = true;
            this.lblDist.Location = new System.Drawing.Point(13, 21);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(78, 13);
            this.lblDist.TabIndex = 6;
            this.lblDist.Text = "Distância (Km):";
            // 
            // lblDur
            // 
            this.lblDur.AutoSize = true;
            this.lblDur.Location = new System.Drawing.Point(12, 62);
            this.lblDur.Name = "lblDur";
            this.lblDur.Size = new System.Drawing.Size(97, 13);
            this.lblDur.TabIndex = 7;
            this.lblDur.Text = "Duração (Minutos):";
            // 
            // txtDur
            // 
            this.txtDur.Location = new System.Drawing.Point(115, 59);
            this.txtDur.Name = "txtDur";
            this.txtDur.Size = new System.Drawing.Size(143, 20);
            this.txtDur.TabIndex = 8;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(17, 99);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Corrida",
            "Caminhada",
            "Misto"});
            this.cmbTipo.Location = new System.Drawing.Point(54, 96);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(204, 21);
            this.cmbTipo.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 329);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtDur);
            this.Controls.Add(this.lblDur);
            this.Controls.Add(this.lblDist);
            this.Controls.Add(this.txtDist);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnMst);
            this.Controls.Add(this.btnAdc);
            this.Controls.Add(this.lsvInfo);
            this.Name = "Form1";
            this.Text = "Treinos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvInfo;
        private System.Windows.Forms.ColumnHeader tipo;
        private System.Windows.Forms.ColumnHeader dist;
        private System.Windows.Forms.ColumnHeader dur;
        private System.Windows.Forms.Button btnAdc;
        private System.Windows.Forms.Button btnMst;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.TextBox txtDist;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.Label lblDur;
        private System.Windows.Forms.TextBox txtDur;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}

