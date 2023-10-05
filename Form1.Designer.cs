namespace SMOLab1
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
            this.epsilonTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.halfDivisionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deltaTB = new System.Windows.Forms.TextBox();
            this.goldenRatioButton = new System.Windows.Forms.Button();
            this.FibonacciButton = new System.Windows.Forms.Button();
            this.NewtonButton = new System.Windows.Forms.Button();
            this.outputTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // epsilonTB
            // 
            this.epsilonTB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.epsilonTB.Location = new System.Drawing.Point(243, 10);
            this.epsilonTB.Name = "epsilonTB";
            this.epsilonTB.Size = new System.Drawing.Size(100, 23);
            this.epsilonTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Function: x^3-x; 0<x<1";
            // 
            // halfDivisionButton
            // 
            this.halfDivisionButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.halfDivisionButton.Location = new System.Drawing.Point(12, 47);
            this.halfDivisionButton.Name = "halfDivisionButton";
            this.halfDivisionButton.Size = new System.Drawing.Size(91, 45);
            this.halfDivisionButton.TabIndex = 3;
            this.halfDivisionButton.Text = "Половинное деление";
            this.halfDivisionButton.UseVisualStyleBackColor = true;
            this.halfDivisionButton.Click += new System.EventHandler(this.halfDivisionButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(181, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Epsilon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(349, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Delta";
            // 
            // deltaTB
            // 
            this.deltaTB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deltaTB.Location = new System.Drawing.Point(397, 10);
            this.deltaTB.Name = "deltaTB";
            this.deltaTB.Size = new System.Drawing.Size(100, 23);
            this.deltaTB.TabIndex = 2;
            // 
            // goldenRatioButton
            // 
            this.goldenRatioButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goldenRatioButton.Location = new System.Drawing.Point(109, 47);
            this.goldenRatioButton.Name = "goldenRatioButton";
            this.goldenRatioButton.Size = new System.Drawing.Size(91, 45);
            this.goldenRatioButton.TabIndex = 4;
            this.goldenRatioButton.Text = "Золотое сечение";
            this.goldenRatioButton.UseVisualStyleBackColor = true;
            this.goldenRatioButton.Click += new System.EventHandler(this.goldenRatioButton_Click);
            // 
            // FibonacciButton
            // 
            this.FibonacciButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FibonacciButton.Location = new System.Drawing.Point(206, 47);
            this.FibonacciButton.Name = "FibonacciButton";
            this.FibonacciButton.Size = new System.Drawing.Size(91, 45);
            this.FibonacciButton.TabIndex = 5;
            this.FibonacciButton.Text = "Метод Фибоначчи";
            this.FibonacciButton.UseVisualStyleBackColor = true;
            this.FibonacciButton.Click += new System.EventHandler(this.FibonacciButton_Click);
            // 
            // NewtonButton
            // 
            this.NewtonButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewtonButton.Location = new System.Drawing.Point(303, 47);
            this.NewtonButton.Name = "NewtonButton";
            this.NewtonButton.Size = new System.Drawing.Size(91, 45);
            this.NewtonButton.TabIndex = 6;
            this.NewtonButton.Text = "Метод Ньютона";
            this.NewtonButton.UseVisualStyleBackColor = true;
            this.NewtonButton.Click += new System.EventHandler(this.NewtonButton_Click);
            // 
            // outputTB
            // 
            this.outputTB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outputTB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputTB.Location = new System.Drawing.Point(0, 121);
            this.outputTB.Multiline = true;
            this.outputTB.Name = "outputTB";
            this.outputTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTB.Size = new System.Drawing.Size(587, 193);
            this.outputTB.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 314);
            this.Controls.Add(this.outputTB);
            this.Controls.Add(this.NewtonButton);
            this.Controls.Add(this.FibonacciButton);
            this.Controls.Add(this.goldenRatioButton);
            this.Controls.Add(this.deltaTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.halfDivisionButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.epsilonTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox epsilonTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button halfDivisionButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deltaTB;
        private System.Windows.Forms.Button goldenRatioButton;
        private System.Windows.Forms.Button FibonacciButton;
        private System.Windows.Forms.Button NewtonButton;
        private System.Windows.Forms.TextBox outputTB;
    }
}

