using System.Media;

namespace Teste_de_Matematica
{
    public partial class Form1 : Form
    {

        Random randomizer = new Random();

        int addend1;
        int addend2;
        int minuend;
        int subtrahend;
        int multiplicand;
        int multiplier;
        int dividend;
        int divisor;

        int timeLeft;

        public void StartTheQuiz()
        {
            timeLabel.BackColor = Color.White;
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            soma.Value = 0;

            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            diferenca.Value = 0;

            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            produto.Value = 0;

            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quociente.Value = 0;

            timeLeft = 30;
            timeLabel.Text = ($"{timeLeft} seconds");
            timer1.Start();
        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == soma.Value)
                && (minuend - subtrahend == diferenca.Value)
                && (multiplicand * multiplier == produto.Value)
                && (dividend / divisor == quociente.Value))
                return true;
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void plusLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void dividedRightLabel_Click(object sender, EventArgs e)
        {

        }

        private void dividedLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void answer_Enter(object sender, EventArgs e)
        {
        }
        private void answerCorrect(object sender, EventArgs e)
        {
            NumericUpDown numUD = (NumericUpDown)sender;
            switch (numUD.Name)
            {
                case "soma":
                    if (addend1 + addend2 == soma.Value) { SystemSounds.Beep.Play(); }
                    break;
                case "diferenca":
                    if (minuend - subtrahend == diferenca.Value) { SystemSounds.Beep.Play(); }
                    break;
                case "produto":
                    if (multiplicand * multiplier == produto.Value) { SystemSounds.Beep.Play(); }
                    break;
                case "quociente":
                    if (dividend / divisor == quociente.Value) { SystemSounds.Beep.Play(); }
                    break;
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            {
                if (CheckTheAnswer())
                {

                    timer1.Stop();
                    MessageBox.Show("You got all the answers right!",
                                    "Congratulations!");
                    startButton.Enabled = true;
                }
                if (timeLeft <= 6)
                {
                    timeLabel.BackColor = Color.Red;
                }
                if (timeLeft > 0)
                {

                    timeLeft = timeLeft - 1;
                    timeLabel.Text = timeLeft + " seconds";                }
                else
                {

                    timer1.Stop();
                    timeLabel.Text = "Time's up!";
                    MessageBox.Show("You didn't finish in time.", "Sorry!");
                    soma.Value = addend1 + addend2;
                    diferenca.Value = minuend - subtrahend;
                    produto.Value = multiplicand * multiplier;
                    quociente.Value = dividend / divisor;
                    startButton.Enabled = true;
                    timeLabel.BackColor = Color.White;
                }
            }
        }
    }
}