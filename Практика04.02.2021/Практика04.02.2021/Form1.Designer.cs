
namespace Практика04._02._2021
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.But_Anim = new System.Windows.Forms.Button();
            this.But_Del = new System.Windows.Forms.Button();
            this.But_Draw = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitContainer1.Panel2.Controls.Add(this.But_Anim);
            this.splitContainer1.Panel2.Controls.Add(this.But_Del);
            this.splitContainer1.Panel2.Controls.Add(this.But_Draw);
            this.splitContainer1.Size = new System.Drawing.Size(774, 449);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(767, 260);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // But_Anim
            // 
            this.But_Anim.Location = new System.Drawing.Point(477, 48);
            this.But_Anim.Name = "But_Anim";
            this.But_Anim.Size = new System.Drawing.Size(170, 98);
            this.But_Anim.TabIndex = 2;
            this.But_Anim.Text = "Оживить";
            this.But_Anim.UseVisualStyleBackColor = true;
            this.But_Anim.Click += new System.EventHandler(this.But_Anim_Click);
            // 
            // But_Del
            // 
            this.But_Del.Location = new System.Drawing.Point(117, 100);
            this.But_Del.Name = "But_Del";
            this.But_Del.Size = new System.Drawing.Size(170, 46);
            this.But_Del.TabIndex = 1;
            this.But_Del.Text = "Стереть";
            this.But_Del.UseVisualStyleBackColor = true;
            this.But_Del.Click += new System.EventHandler(this.But_Del_Click);
            // 
            // But_Draw
            // 
            this.But_Draw.Location = new System.Drawing.Point(117, 48);
            this.But_Draw.Name = "But_Draw";
            this.But_Draw.Size = new System.Drawing.Size(170, 46);
            this.But_Draw.TabIndex = 0;
            this.But_Draw.Text = "Нарисовать";
            this.But_Draw.UseVisualStyleBackColor = true;
            this.But_Draw.Click += new System.EventHandler(this.But_Draw_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 30;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 449);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button But_Anim;
        private System.Windows.Forms.Button But_Del;
        private System.Windows.Forms.Button But_Draw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Timer;
    }
}

