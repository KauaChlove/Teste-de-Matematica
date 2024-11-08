namespace Teste_de_Matematica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timeLabel = new Label();
            label1 = new Label();
            plusLeftLabel = new Label();
            label2 = new Label();
            plusRightLabel = new Label();
            label4 = new Label();
            soma = new NumericUpDown();
            diferenca = new NumericUpDown();
            label3 = new Label();
            minusRightLabel = new Label();
            label6 = new Label();
            minusLeftLabel = new Label();
            produto = new NumericUpDown();
            label8 = new Label();
            timesRightLabel = new Label();
            label10 = new Label();
            timesLeftLabel = new Label();
            quociente = new NumericUpDown();
            label12 = new Label();
            dividedRightLabel = new Label();
            label14 = new Label();
            dividedLeftLabel = new Label();
            startButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)soma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diferenca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quociente).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 15.75F);
            timeLabel.Location = new Point(272, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 30);
            timeLabel.TabIndex = 0;
            timeLabel.Click += timeLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(154, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 30);
            label1.TabIndex = 1;
            label1.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Segoe UI", 18F);
            plusLeftLabel.Location = new Point(56, 75);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(60, 50);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            plusLeftLabel.Click += plusLeftLabel_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(122, 75);
            label2.Name = "label2";
            label2.Size = new Size(60, 50);
            label2.TabIndex = 3;
            label2.Text = "+";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI", 18F);
            plusRightLabel.Location = new Point(187, 75);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(60, 50);
            plusRightLabel.TabIndex = 4;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(253, 75);
            label4.Name = "label4";
            label4.Size = new Size(60, 50);
            label4.TabIndex = 5;
            label4.Text = "=";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // soma
            // 
            soma.Font = new Font("Segoe UI", 18F);
            soma.Location = new Point(319, 82);
            soma.Name = "soma";
            soma.Size = new Size(100, 39);
            soma.TabIndex = 1;
            soma.ValueChanged += answerCorrect;
            soma.Enter += answer_Enter;
            // 
            // diferenca
            // 
            diferenca.Font = new Font("Segoe UI", 18F);
            diferenca.Location = new Point(319, 141);
            diferenca.Name = "diferenca";
            diferenca.Size = new Size(100, 39);
            diferenca.TabIndex = 2;
            diferenca.ValueChanged += answerCorrect;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(253, 134);
            label3.Name = "label3";
            label3.Size = new Size(60, 50);
            label3.TabIndex = 10;
            label3.Text = "=";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font = new Font("Segoe UI", 18F);
            minusRightLabel.Location = new Point(187, 134);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(60, 50);
            minusRightLabel.TabIndex = 9;
            minusRightLabel.Text = "?";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(122, 134);
            label6.Name = "label6";
            label6.Size = new Size(60, 50);
            label6.TabIndex = 8;
            label6.Text = "-";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("Segoe UI", 18F);
            minusLeftLabel.Location = new Point(56, 134);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(60, 50);
            minusLeftLabel.TabIndex = 7;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // produto
            // 
            produto.Font = new Font("Segoe UI", 18F);
            produto.Location = new Point(319, 200);
            produto.Name = "produto";
            produto.Size = new Size(100, 39);
            produto.TabIndex = 3;
            produto.ValueChanged += answerCorrect;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 18F);
            label8.Location = new Point(253, 193);
            label8.Name = "label8";
            label8.Size = new Size(60, 50);
            label8.TabIndex = 15;
            label8.Text = "=";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Segoe UI", 18F);
            timesRightLabel.Location = new Point(187, 193);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(60, 50);
            timesRightLabel.TabIndex = 14;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 18F);
            label10.Location = new Point(122, 193);
            label10.Name = "label10";
            label10.Size = new Size(60, 50);
            label10.TabIndex = 13;
            label10.Text = "x";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Segoe UI", 18F);
            timesLeftLabel.Location = new Point(56, 193);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(60, 50);
            timesLeftLabel.TabIndex = 12;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quociente
            // 
            quociente.Font = new Font("Segoe UI", 18F);
            quociente.Location = new Point(319, 265);
            quociente.Name = "quociente";
            quociente.Size = new Size(100, 39);
            quociente.TabIndex = 4;
            quociente.ValueChanged += answerCorrect;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 18F);
            label12.Location = new Point(253, 258);
            label12.Name = "label12";
            label12.Size = new Size(60, 50);
            label12.TabIndex = 20;
            label12.Text = "=";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font = new Font("Segoe UI", 18F);
            dividedRightLabel.Location = new Point(187, 258);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(60, 50);
            dividedRightLabel.TabIndex = 19;
            dividedRightLabel.Text = "?";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            dividedRightLabel.Click += dividedRightLabel_Click;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 18F);
            label14.Location = new Point(122, 258);
            label14.Name = "label14";
            label14.Size = new Size(60, 50);
            label14.TabIndex = 18;
            label14.Text = "÷";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("Segoe UI", 18F);
            dividedLeftLabel.Location = new Point(56, 258);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(60, 50);
            dividedLeftLabel.TabIndex = 17;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            dividedLeftLabel.Click += dividedLeftLabel_Click;
            // 
            // startButton
            // 
            startButton.AutoSize = true;
            startButton.Font = new Font("Segoe UI", 14F);
            startButton.Location = new Point(154, 314);
            startButton.Name = "startButton";
            startButton.Size = new Size(121, 35);
            startButton.TabIndex = 0;
            startButton.Text = "Iniciar Teste";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(startButton);
            Controls.Add(quociente);
            Controls.Add(label12);
            Controls.Add(dividedRightLabel);
            Controls.Add(label14);
            Controls.Add(dividedLeftLabel);
            Controls.Add(produto);
            Controls.Add(label8);
            Controls.Add(timesRightLabel);
            Controls.Add(label10);
            Controls.Add(timesLeftLabel);
            Controls.Add(diferenca);
            Controls.Add(label3);
            Controls.Add(minusRightLabel);
            Controls.Add(label6);
            Controls.Add(minusLeftLabel);
            Controls.Add(soma);
            Controls.Add(label4);
            Controls.Add(plusRightLabel);
            Controls.Add(label2);
            Controls.Add(plusLeftLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Teste de Matematica";
            ((System.ComponentModel.ISupportInitialize)soma).EndInit();
            ((System.ComponentModel.ISupportInitialize)diferenca).EndInit();
            ((System.ComponentModel.ISupportInitialize)produto).EndInit();
            ((System.ComponentModel.ISupportInitialize)quociente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label label1;
        private Label plusLeftLabel;
        private Label label2;
        private Label plusRightLabel;
        private Label label4;
        private NumericUpDown soma;
        private NumericUpDown diferenca;
        private Label label3;
        private Label minusRightLabel;
        private Label label6;
        private Label minusLeftLabel;
        private NumericUpDown produto;
        private Label label8;
        private Label timesRightLabel;
        private Label label10;
        private Label timesLeftLabel;
        private NumericUpDown quociente;
        private Label label12;
        private Label dividedRightLabel;
        private Label label14;
        private Label dividedLeftLabel;
        private Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}
