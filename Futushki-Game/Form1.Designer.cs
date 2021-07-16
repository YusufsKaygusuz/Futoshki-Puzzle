
namespace Futushki_Game
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Advanced = new System.Windows.Forms.RadioButton();
            this.İntermediate = new System.Windows.Forms.RadioButton();
            this.Beginner = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NewGame_Button = new System.Windows.Forms.Button();
            this.EndGame_Button = new System.Windows.Forms.Button();
            this.CheckInput_Button = new System.Windows.Forms.Button();
            this.ClearInput_Button = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 485);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Advanced);
            this.panel2.Controls.Add(this.İntermediate);
            this.panel2.Controls.Add(this.Beginner);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(503, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 255);
            this.panel2.TabIndex = 9;
            // 
            // Advanced
            // 
            this.Advanced.AutoSize = true;
            this.Advanced.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Advanced.Location = new System.Drawing.Point(3, 190);
            this.Advanced.Name = "Advanced";
            this.Advanced.Size = new System.Drawing.Size(137, 27);
            this.Advanced.TabIndex = 9;
            this.Advanced.TabStop = true;
            this.Advanced.Text = "ADVANCED";
            this.Advanced.UseVisualStyleBackColor = true;
            // 
            // İntermediate
            // 
            this.İntermediate.AutoSize = true;
            this.İntermediate.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İntermediate.Location = new System.Drawing.Point(3, 142);
            this.İntermediate.Name = "İntermediate";
            this.İntermediate.Size = new System.Drawing.Size(156, 27);
            this.İntermediate.TabIndex = 6;
            this.İntermediate.TabStop = true;
            this.İntermediate.Text = "INTERMEDİATE";
            this.İntermediate.UseVisualStyleBackColor = true;
            // 
            // Beginner
            // 
            this.Beginner.AutoSize = true;
            this.Beginner.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Beginner.Location = new System.Drawing.Point(3, 93);
            this.Beginner.Name = "Beginner";
            this.Beginner.Size = new System.Drawing.Size(122, 27);
            this.Beginner.TabIndex = 5;
            this.Beginner.TabStop = true;
            this.Beginner.Text = "BEGİNNER";
            this.Beginner.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 75);
            this.label1.TabIndex = 4;
            this.label1.Text = "LEVEL SELECTİON";
            // 
            // NewGame_Button
            // 
            this.NewGame_Button.BackColor = System.Drawing.Color.DarkBlue;
            this.NewGame_Button.Font = new System.Drawing.Font("Century", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NewGame_Button.ForeColor = System.Drawing.Color.White;
            this.NewGame_Button.Location = new System.Drawing.Point(503, 273);
            this.NewGame_Button.Name = "NewGame_Button";
            this.NewGame_Button.Size = new System.Drawing.Size(114, 90);
            this.NewGame_Button.TabIndex = 10;
            this.NewGame_Button.Text = "NEW GAME";
            this.NewGame_Button.UseVisualStyleBackColor = false;
            this.NewGame_Button.Click += new System.EventHandler(this.NewGame_Button_Click);
            // 
            // EndGame_Button
            // 
            this.EndGame_Button.BackColor = System.Drawing.Color.DarkRed;
            this.EndGame_Button.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EndGame_Button.ForeColor = System.Drawing.Color.White;
            this.EndGame_Button.Location = new System.Drawing.Point(623, 273);
            this.EndGame_Button.Name = "EndGame_Button";
            this.EndGame_Button.Size = new System.Drawing.Size(114, 90);
            this.EndGame_Button.TabIndex = 11;
            this.EndGame_Button.Text = "End Game ";
            this.EndGame_Button.UseVisualStyleBackColor = false;
            this.EndGame_Button.Click += new System.EventHandler(this.EndGame_Button_Click);
            // 
            // CheckInput_Button
            // 
            this.CheckInput_Button.BackColor = System.Drawing.Color.Green;
            this.CheckInput_Button.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CheckInput_Button.ForeColor = System.Drawing.Color.White;
            this.CheckInput_Button.Location = new System.Drawing.Point(503, 397);
            this.CheckInput_Button.Name = "CheckInput_Button";
            this.CheckInput_Button.Size = new System.Drawing.Size(114, 90);
            this.CheckInput_Button.TabIndex = 12;
            this.CheckInput_Button.Text = "Check Input";
            this.CheckInput_Button.UseVisualStyleBackColor = false;
            this.CheckInput_Button.Click += new System.EventHandler(this.CheckInput_Button_Click);
            // 
            // ClearInput_Button
            // 
            this.ClearInput_Button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClearInput_Button.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClearInput_Button.ForeColor = System.Drawing.Color.White;
            this.ClearInput_Button.Location = new System.Drawing.Point(623, 397);
            this.ClearInput_Button.Name = "ClearInput_Button";
            this.ClearInput_Button.Size = new System.Drawing.Size(114, 90);
            this.ClearInput_Button.TabIndex = 13;
            this.ClearInput_Button.Text = "Clear Input";
            this.ClearInput_Button.UseVisualStyleBackColor = false;
            this.ClearInput_Button.Click += new System.EventHandler(this.ClearInput_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.ClearInput_Button);
            this.Controls.Add(this.CheckInput_Button);
            this.Controls.Add(this.EndGame_Button);
            this.Controls.Add(this.NewGame_Button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Advanced;
        private System.Windows.Forms.RadioButton İntermediate;
        private System.Windows.Forms.RadioButton Beginner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewGame_Button;
        private System.Windows.Forms.Button EndGame_Button;
        private System.Windows.Forms.Button CheckInput_Button;
        private System.Windows.Forms.Button ClearInput_Button;
    }
}

