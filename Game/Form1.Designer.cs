namespace Game
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
            this.Adder = new System.Windows.Forms.Button();
            this.Multiplyer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.TextBox();
            this.Goal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Counter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Starter = new System.Windows.Forms.Button();
            this.tip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Adder
            // 
            this.Adder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adder.Location = new System.Drawing.Point(12, 32);
            this.Adder.Name = "Adder";
            this.Adder.Size = new System.Drawing.Size(121, 60);
            this.Adder.TabIndex = 0;
            this.Adder.Text = "+ 1";
            this.Adder.UseVisualStyleBackColor = true;
            this.Adder.Click += new System.EventHandler(this.Adder_Click);
            // 
            // Multiplyer
            // 
            this.Multiplyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Multiplyer.Location = new System.Drawing.Point(12, 98);
            this.Multiplyer.Name = "Multiplyer";
            this.Multiplyer.Size = new System.Drawing.Size(121, 60);
            this.Multiplyer.TabIndex = 1;
            this.Multiplyer.Text = "x 2";
            this.Multiplyer.UseVisualStyleBackColor = true;
            this.Multiplyer.Click += new System.EventHandler(this.Multiplyer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Команды";
            // 
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(165, 59);
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Size = new System.Drawing.Size(100, 20);
            this.Num.TabIndex = 3;
            this.Num.Text = "0";
            this.Num.TextChanged += new System.EventHandler(this.Num_TextChanged);
            // 
            // Goal
            // 
            this.Goal.Location = new System.Drawing.Point(302, 59);
            this.Goal.Name = "Goal";
            this.Goal.ReadOnly = true;
            this.Goal.Size = new System.Drawing.Size(100, 20);
            this.Goal.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(165, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ваше число";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(287, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Нужное число";
            // 
            // Counter
            // 
            this.Counter.Location = new System.Drawing.Point(233, 121);
            this.Counter.Name = "Counter";
            this.Counter.ReadOnly = true;
            this.Counter.Size = new System.Drawing.Size(100, 20);
            this.Counter.TabIndex = 7;
            this.Counter.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(193, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Число ваших попыток";
            // 
            // Starter
            // 
            this.Starter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Starter.Location = new System.Drawing.Point(12, 205);
            this.Starter.Name = "Starter";
            this.Starter.Size = new System.Drawing.Size(390, 33);
            this.Starter.TabIndex = 9;
            this.Starter.Text = "Начать игру";
            this.Starter.UseVisualStyleBackColor = true;
            this.Starter.Click += new System.EventHandler(this.Starter_Click);
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tip.Location = new System.Drawing.Point(68, 185);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(285, 17);
            this.tip.TabIndex = 10;
            this.tip.Text = "Нажмите снова чтобы начать новую игру*";
            this.tip.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 251);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.Starter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Goal);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Multiplyer);
            this.Controls.Add(this.Adder);
            this.MaximumSize = new System.Drawing.Size(435, 290);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(435, 290);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " GAME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Adder;
        private System.Windows.Forms.Button Multiplyer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.TextBox Goal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Counter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Starter;
        private System.Windows.Forms.Label tip;
    }
}

