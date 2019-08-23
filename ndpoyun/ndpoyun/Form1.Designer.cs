//**                                     SAKARYA ÜNİVERSİTESİ
//**                           BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
//**                                BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
//**                               NESNEYE DAYALI PROGRAMLAMA DERSİ
//**                                   2015 - 2016 BAHAR DÖNEMİ
//**
//**                          ÖDEV NUMARASI.......... :04
//**                          ÖĞRENCİ ADI............ :Taylan Umut Tokoğlu
//**                          ÖĞRENCİ NUMARASI....... :b151210077
//**                          DERSİN ALINDIĞI GRUP... :D grubu
//*****************************************************************************************************/
namespace ndpoyun
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yüksekSkorDataSet = new ndpoyun.YüksekSkorDataSet();
            this.kayitTableAdapter = new ndpoyun.YüksekSkorDataSetTableAdapters.kayitTableAdapter();
            this.ustpanel1 = new ndpoyun.Ustpanel();
            this.button1 = new System.Windows.Forms.Button();
            this.uyari_lbl = new ndpoyun.Skor();
            this.skor_btn = new System.Windows.Forms.Button();
            this.skor2 = new ndpoyun.Skor();
            this.dur_btn = new System.Windows.Forms.Button();
            this.oyunzemini1 = new ndpoyun.Oyunzemini();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.YüksekSkor = new System.Windows.Forms.GroupBox();
            this.basla_btn = new System.Windows.Forms.Button();
            this.kayit_btn = new System.Windows.Forms.Button();
            this.skoryaz_lbl = new ndpoyun.Skor();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.skor_lbl = new ndpoyun.Skor();
            this.isim_lbl = new ndpoyun.Skor();
            this.raket1 = new ndpoyun.Raket();
            this.top1 = new ndpoyun.Top();
            ((System.ComponentModel.ISupportInitialize)(this.kayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yüksekSkorDataSet)).BeginInit();
            this.ustpanel1.SuspendLayout();
            this.oyunzemini1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.YüksekSkor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raket1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kayitBindingSource
            // 
            this.kayitBindingSource.DataMember = "kayit";
            this.kayitBindingSource.DataSource = this.yüksekSkorDataSet;
            // 
            // yüksekSkorDataSet
            // 
            this.yüksekSkorDataSet.DataSetName = "YüksekSkorDataSet";
            this.yüksekSkorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayitTableAdapter
            // 
            this.kayitTableAdapter.ClearBeforeFill = true;
            // 
            // ustpanel1
            // 
            this.ustpanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ustpanel1.Controls.Add(this.button1);
            this.ustpanel1.Controls.Add(this.uyari_lbl);
            this.ustpanel1.Controls.Add(this.skor_btn);
            this.ustpanel1.Controls.Add(this.skor2);
            this.ustpanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ustpanel1.Location = new System.Drawing.Point(0, 0);
            this.ustpanel1.Name = "ustpanel1";
            this.ustpanel1.Size = new System.Drawing.Size(838, 28);
            this.ustpanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(0, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Yüksek Skor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uyari_lbl
            // 
            this.uyari_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uyari_lbl.AutoSize = true;
            this.uyari_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyari_lbl.Location = new System.Drawing.Point(636, 1);
            this.uyari_lbl.Ms = 0;
            this.uyari_lbl.Name = "uyari_lbl";
            this.uyari_lbl.Size = new System.Drawing.Size(202, 24);
            this.uyari_lbl.TabIndex = 3;
            this.uyari_lbl.Text = "Başlamak için tıklayınız.\r\n";
            // 
            // skor_btn
            // 
            this.skor_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.skor_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.skor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.skor_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skor_btn.Location = new System.Drawing.Point(0, 2);
            this.skor_btn.Margin = new System.Windows.Forms.Padding(0);
            this.skor_btn.Name = "skor_btn";
            this.skor_btn.Size = new System.Drawing.Size(77, 23);
            this.skor_btn.TabIndex = 2;
            this.skor_btn.Text = "Yüksek Skor";
            this.skor_btn.UseVisualStyleBackColor = false;
            this.skor_btn.Click += new System.EventHandler(this.skor_btn_Click);
            // 
            // skor2
            // 
            this.skor2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.skor2.AutoSize = true;
            this.skor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skor2.Location = new System.Drawing.Point(3, 3);
            this.skor2.Ms = 0;
            this.skor2.Name = "skor2";
            this.skor2.Size = new System.Drawing.Size(18, 20);
            this.skor2.TabIndex = 1;
            this.skor2.Text = "0";
            // 
            // dur_btn
            // 
            this.dur_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dur_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dur_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dur_btn.Location = new System.Drawing.Point(101, 97);
            this.dur_btn.Name = "dur_btn";
            this.dur_btn.Size = new System.Drawing.Size(75, 23);
            this.dur_btn.TabIndex = 5;
            this.dur_btn.Text = "Çıkış";
            this.dur_btn.UseVisualStyleBackColor = false;
            this.dur_btn.Click += new System.EventHandler(this.dur_btn_Click);
            // 
            // oyunzemini1
            // 
            this.oyunzemini1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.oyunzemini1.Controls.Add(this.dataGridView1);
            this.oyunzemini1.Controls.Add(this.YüksekSkor);
            this.oyunzemini1.Controls.Add(this.raket1);
            this.oyunzemini1.Controls.Add(this.top1);
            this.oyunzemini1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oyunzemini1.Location = new System.Drawing.Point(0, 0);
            this.oyunzemini1.Name = "oyunzemini1";
            this.oyunzemini1.Size = new System.Drawing.Size(838, 443);
            this.oyunzemini1.TabIndex = 0;
            this.oyunzemini1.Click += new System.EventHandler(this.oyunzemini1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // YüksekSkor
            // 
            this.YüksekSkor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.YüksekSkor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.YüksekSkor.Controls.Add(this.dur_btn);
            this.YüksekSkor.Controls.Add(this.basla_btn);
            this.YüksekSkor.Controls.Add(this.kayit_btn);
            this.YüksekSkor.Controls.Add(this.skoryaz_lbl);
            this.YüksekSkor.Controls.Add(this.textBox1);
            this.YüksekSkor.Controls.Add(this.skor_lbl);
            this.YüksekSkor.Controls.Add(this.isim_lbl);
            this.YüksekSkor.Location = new System.Drawing.Point(309, 186);
            this.YüksekSkor.Name = "YüksekSkor";
            this.YüksekSkor.Size = new System.Drawing.Size(270, 130);
            this.YüksekSkor.TabIndex = 3;
            this.YüksekSkor.TabStop = false;
            this.YüksekSkor.Text = "Yeni Skor";
            // 
            // basla_btn
            // 
            this.basla_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.basla_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.basla_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.basla_btn.Location = new System.Drawing.Point(6, 98);
            this.basla_btn.Name = "basla_btn";
            this.basla_btn.Size = new System.Drawing.Size(89, 23);
            this.basla_btn.TabIndex = 6;
            this.basla_btn.Text = "Yeniden Başla";
            this.basla_btn.UseVisualStyleBackColor = false;
            this.basla_btn.Click += new System.EventHandler(this.basla_btn_Click);
            // 
            // kayit_btn
            // 
            this.kayit_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.kayit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kayit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayit_btn.Location = new System.Drawing.Point(188, 97);
            this.kayit_btn.Name = "kayit_btn";
            this.kayit_btn.Size = new System.Drawing.Size(75, 23);
            this.kayit_btn.TabIndex = 5;
            this.kayit_btn.Text = "Kayıt";
            this.kayit_btn.UseVisualStyleBackColor = false;
            this.kayit_btn.Click += new System.EventHandler(this.kayit_btn_Click);
            // 
            // skoryaz_lbl
            // 
            this.skoryaz_lbl.AutoSize = true;
            this.skoryaz_lbl.Location = new System.Drawing.Point(98, 72);
            this.skoryaz_lbl.Ms = 0;
            this.skoryaz_lbl.Name = "skoryaz_lbl";
            this.skoryaz_lbl.Size = new System.Drawing.Size(0, 13);
            this.skoryaz_lbl.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 2;
            // 
            // skor_lbl
            // 
            this.skor_lbl.AutoSize = true;
            this.skor_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skor_lbl.Location = new System.Drawing.Point(6, 67);
            this.skor_lbl.Ms = 0;
            this.skor_lbl.Name = "skor_lbl";
            this.skor_lbl.Size = new System.Drawing.Size(85, 18);
            this.skor_lbl.TabIndex = 1;
            this.skor_lbl.Text = "Skorunuz:";
            // 
            // isim_lbl
            // 
            this.isim_lbl.AutoSize = true;
            this.isim_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim_lbl.Location = new System.Drawing.Point(6, 28);
            this.isim_lbl.Ms = 0;
            this.isim_lbl.Name = "isim_lbl";
            this.isim_lbl.Size = new System.Drawing.Size(66, 18);
            this.isim_lbl.TabIndex = 0;
            this.isim_lbl.Text = "İsminiz:";
            // 
            // raket1
            // 
            this.raket1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.raket1.BackColor = System.Drawing.Color.Transparent;
            this.raket1.Image = ((System.Drawing.Image)(resources.GetObject("raket1.Image")));
            this.raket1.Location = new System.Drawing.Point(359, 417);
            this.raket1.Name = "raket1";
            this.raket1.Size = new System.Drawing.Size(100, 14);
            this.raket1.TabIndex = 0;
            this.raket1.TabStop = false;
            // 
            // top1
            // 
            this.top1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.top1.BackColor = System.Drawing.Color.Transparent;
            this.top1.Hız_sol = 3;
            this.top1.Hız_ust = 3;
            this.top1.Image = ((System.Drawing.Image)(resources.GetObject("top1.Image")));
            this.top1.InitialImage = ((System.Drawing.Image)(resources.GetObject("top1.InitialImage")));
            this.top1.Location = new System.Drawing.Point(403, 405);
            this.top1.Name = "top1";
            this.top1.Size = new System.Drawing.Size(15, 15);
            this.top1.TabIndex = 1;
            this.top1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 443);
            this.Controls.Add(this.ustpanel1);
            this.Controls.Add(this.oyunzemini1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yüksekSkorDataSet)).EndInit();
            this.ustpanel1.ResumeLayout(false);
            this.ustpanel1.PerformLayout();
            this.oyunzemini1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.YüksekSkor.ResumeLayout(false);
            this.YüksekSkor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raket1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Oyunzemini oyunzemini1;
        private Ustpanel ustpanel1;
        private Raket raket1;
        private Top top1;
        private System.Windows.Forms.Timer timer1;
        private Skor skor2;
        private System.Windows.Forms.Button skor_btn;
        private Skor uyari_lbl;
        private YüksekSkorDataSet yüksekSkorDataSet;
        private System.Windows.Forms.BindingSource kayitBindingSource;
        private YüksekSkorDataSetTableAdapters.kayitTableAdapter kayitTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox YüksekSkor;
        private System.Windows.Forms.TextBox textBox1;
        private Skor skor_lbl;
        private Skor isim_lbl;
        private Skor skoryaz_lbl;
        private System.Windows.Forms.Button kayit_btn;
        private System.Windows.Forms.Button dur_btn;
        private System.Windows.Forms.Button basla_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

