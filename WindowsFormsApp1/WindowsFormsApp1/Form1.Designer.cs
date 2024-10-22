namespace WindowsFormsApp1
{
    partial class FlappyBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBird));
            this.kus = new System.Windows.Forms.PictureBox();
            this.ustBoru = new System.Windows.Forms.PictureBox();
            this.zemin = new System.Windows.Forms.PictureBox();
            this.altBoru = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustBoru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altBoru)).BeginInit();
            this.SuspendLayout();
            // 
            // kus
            // 
            this.kus.Image = ((System.Drawing.Image)(resources.GetObject("kus.Image")));
            this.kus.Location = new System.Drawing.Point(103, 161);
            this.kus.Name = "kus";
            this.kus.Size = new System.Drawing.Size(61, 44);
            this.kus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kus.TabIndex = 0;
            this.kus.TabStop = false;
            // 
            // ustBoru
            // 
            this.ustBoru.Image = ((System.Drawing.Image)(resources.GetObject("ustBoru.Image")));
            this.ustBoru.Location = new System.Drawing.Point(612, -32);
            this.ustBoru.Name = "ustBoru";
            this.ustBoru.Size = new System.Drawing.Size(100, 133);
            this.ustBoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ustBoru.TabIndex = 0;
            this.ustBoru.TabStop = false;
            // 
            // zemin
            // 
            this.zemin.Image = ((System.Drawing.Image)(resources.GetObject("zemin.Image")));
            this.zemin.Location = new System.Drawing.Point(-8, 420);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(758, 100);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 0;
            this.zemin.TabStop = false;
            // 
            // altBoru
            // 
            this.altBoru.Image = ((System.Drawing.Image)(resources.GetObject("altBoru.Image")));
            this.altBoru.Location = new System.Drawing.Point(515, 251);
            this.altBoru.Name = "altBoru";
            this.altBoru.Size = new System.Drawing.Size(100, 174);
            this.altBoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.altBoru.TabIndex = 0;
            this.altBoru.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "SCORE:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(747, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.altBoru);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.ustBoru);
            this.Controls.Add(this.kus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FlappyBird";
            this.Text = "flappy bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tusBas);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tusCek);
            ((System.ComponentModel.ISupportInitialize)(this.kus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustBoru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altBoru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox kus;
        private System.Windows.Forms.PictureBox ustBoru;
        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.PictureBox altBoru;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

