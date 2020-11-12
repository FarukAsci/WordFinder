namespace Kelime_Bulucu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tblKelimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.dgvKelime = new System.Windows.Forms.DataGridView();
            this.lblHarf = new System.Windows.Forms.Label();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSearchLetters = new System.Windows.Forms.Button();
            this.tbxBegin = new System.Windows.Forms.TextBox();
            this.tbxMinLetter = new System.Windows.Forms.TextBox();
            this.tbxEnd = new System.Windows.Forms.TextBox();
            this.lblBegin = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblMinLetter = new System.Windows.Forms.Label();
            this.tbxInclude = new System.Windows.Forms.TextBox();
            this.lblInclude = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblKelimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKelime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(130, 175);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(105, 12);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 20);
            this.txtAra.TabIndex = 2;
            // 
            // dgvKelime
            // 
            this.dgvKelime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKelime.Location = new System.Drawing.Point(211, 12);
            this.dgvKelime.Name = "dgvKelime";
            this.dgvKelime.Size = new System.Drawing.Size(260, 426);
            this.dgvKelime.TabIndex = 3;
            // 
            // lblHarf
            // 
            this.lblHarf.AutoSize = true;
            this.lblHarf.Location = new System.Drawing.Point(12, 15);
            this.lblHarf.Name = "lblHarf";
            this.lblHarf.Size = new System.Drawing.Size(87, 13);
            this.lblHarf.TabIndex = 4;
            this.lblHarf.Text = "Aranacak Harfler";
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(105, 142);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxNumber.TabIndex = 2;
            this.tbxNumber.Text = "7";
            this.tbxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumber_KeyPress);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(12, 145);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(80, 13);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "Maksimum Harf";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(130, 415);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Sil";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSearchLetters
            // 
            this.btnSearchLetters.Location = new System.Drawing.Point(130, 204);
            this.btnSearchLetters.Name = "btnSearchLetters";
            this.btnSearchLetters.Size = new System.Drawing.Size(75, 23);
            this.btnSearchLetters.TabIndex = 6;
            this.btnSearchLetters.Text = "Ara2";
            this.btnSearchLetters.UseVisualStyleBackColor = true;
            this.btnSearchLetters.Click += new System.EventHandler(this.btnSearchLetters_Click);
            // 
            // tbxBegin
            // 
            this.tbxBegin.Location = new System.Drawing.Point(105, 38);
            this.tbxBegin.Name = "tbxBegin";
            this.tbxBegin.Size = new System.Drawing.Size(100, 20);
            this.tbxBegin.TabIndex = 2;
            // 
            // tbxMinLetter
            // 
            this.tbxMinLetter.Location = new System.Drawing.Point(105, 116);
            this.tbxMinLetter.Name = "tbxMinLetter";
            this.tbxMinLetter.Size = new System.Drawing.Size(100, 20);
            this.tbxMinLetter.TabIndex = 2;
            this.tbxMinLetter.Text = "3";
            this.tbxMinLetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumber_KeyPress);
            // 
            // tbxEnd
            // 
            this.tbxEnd.Location = new System.Drawing.Point(105, 90);
            this.tbxEnd.Name = "tbxEnd";
            this.tbxEnd.Size = new System.Drawing.Size(100, 20);
            this.tbxEnd.TabIndex = 2;
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.Location = new System.Drawing.Point(12, 41);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(60, 13);
            this.lblBegin.TabIndex = 4;
            this.lblBegin.Text = "İle Başlasın";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(12, 93);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(46, 13);
            this.lblEnd.TabIndex = 4;
            this.lblEnd.Text = "İle Bitsin";
            // 
            // lblMinLetter
            // 
            this.lblMinLetter.AutoSize = true;
            this.lblMinLetter.Location = new System.Drawing.Point(12, 119);
            this.lblMinLetter.Name = "lblMinLetter";
            this.lblMinLetter.Size = new System.Drawing.Size(71, 13);
            this.lblMinLetter.TabIndex = 4;
            this.lblMinLetter.Text = "Minimum Harf";
            // 
            // tbxInclude
            // 
            this.tbxInclude.Location = new System.Drawing.Point(105, 64);
            this.tbxInclude.Name = "tbxInclude";
            this.tbxInclude.Size = new System.Drawing.Size(100, 20);
            this.tbxInclude.TabIndex = 2;
            // 
            // lblInclude
            // 
            this.lblInclude.AutoSize = true;
            this.lblInclude.Location = new System.Drawing.Point(12, 67);
            this.lblInclude.Name = "lblInclude";
            this.lblInclude.Size = new System.Drawing.Size(38, 13);
            this.lblInclude.TabIndex = 4;
            this.lblInclude.Text = "İçersin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 444);
            this.Controls.Add(this.btnSearchLetters);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblMinLetter);
            this.Controls.Add(this.lblInclude);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblBegin);
            this.Controls.Add(this.lblHarf);
            this.Controls.Add(this.dgvKelime);
            this.Controls.Add(this.tbxNumber);
            this.Controls.Add(this.tbxEnd);
            this.Controls.Add(this.tbxMinLetter);
            this.Controls.Add(this.tbxInclude);
            this.Controls.Add(this.tbxBegin);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnAra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(499, 483);
            this.MinimumSize = new System.Drawing.Size(499, 483);
            this.Name = "Form1";
            this.Text = "Kelime Bulucu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblKelimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKelime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tblKelimeBindingSource;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.DataGridView dgvKelime;
        private System.Windows.Forms.Label lblHarf;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSearchLetters;
        private System.Windows.Forms.TextBox tbxBegin;
        private System.Windows.Forms.TextBox tbxMinLetter;
        private System.Windows.Forms.TextBox tbxEnd;
        private System.Windows.Forms.Label lblBegin;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblMinLetter;
        private System.Windows.Forms.TextBox tbxInclude;
        private System.Windows.Forms.Label lblInclude;
    }
}

