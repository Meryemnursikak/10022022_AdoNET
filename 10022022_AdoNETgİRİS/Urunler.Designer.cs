
namespace _10022022_AdoNETgİRİS
{
    partial class Urunler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txturunadi = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnkategoriler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudfiyat = new System.Windows.Forms.NumericUpDown();
            this.nudstok = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnekle_sp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudstok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView1.Location = new System.Drawing.Point(54, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 469);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(95, 28);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // txturunadi
            // 
            this.txturunadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunadi.Location = new System.Drawing.Point(74, 64);
            this.txturunadi.Name = "txturunadi";
            this.txturunadi.Size = new System.Drawing.Size(100, 26);
            this.txturunadi.TabIndex = 1;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(518, 62);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(118, 34);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "Ürün Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnkategoriler
            // 
            this.btnkategoriler.Location = new System.Drawing.Point(642, 61);
            this.btnkategoriler.Name = "btnkategoriler";
            this.btnkategoriler.Size = new System.Drawing.Size(112, 34);
            this.btnkategoriler.TabIndex = 3;
            this.btnkategoriler.Text = "Kategoriler";
            this.btnkategoriler.UseVisualStyleBackColor = true;
            this.btnkategoriler.Click += new System.EventHandler(this.btnkategoriler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı";
            // 
            // nudfiyat
            // 
            this.nudfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudfiyat.Location = new System.Drawing.Point(214, 62);
            this.nudfiyat.Name = "nudfiyat";
            this.nudfiyat.Size = new System.Drawing.Size(120, 26);
            this.nudfiyat.TabIndex = 5;
            // 
            // nudstok
            // 
            this.nudstok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudstok.Location = new System.Drawing.Point(372, 62);
            this.nudstok.Name = "nudstok";
            this.nudstok.Size = new System.Drawing.Size(120, 26);
            this.nudstok.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(214, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(372, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stok";
            // 
            // btnekle_sp
            // 
            this.btnekle_sp.Location = new System.Drawing.Point(535, 12);
            this.btnekle_sp.Name = "btnekle_sp";
            this.btnekle_sp.Size = new System.Drawing.Size(200, 36);
            this.btnekle_sp.TabIndex = 9;
            this.btnekle_sp.Text = "SP İle Ekle";
            this.btnekle_sp.UseVisualStyleBackColor = true;
            this.btnekle_sp.Click += new System.EventHandler(this.btnekle_sp_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 629);
            this.Controls.Add(this.btnekle_sp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudstok);
            this.Controls.Add(this.nudfiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkategoriler);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txturunadi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Urunler";
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudstok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txturunadi;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnkategoriler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudfiyat;
        private System.Windows.Forms.NumericUpDown nudstok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnekle_sp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}