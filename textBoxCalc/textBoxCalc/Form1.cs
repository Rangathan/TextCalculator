using System.Diagnostics.Metrics;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace textBoxCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value1 = double.Parse(textBox1.Text);
            double value2 = double.Parse(textBox2.Text);

            double result = value1 + value2;

            Result.Items.Clear();
            Result.Items.Add(result);

            Calculations.Items.Add($"{value1} + {value2} = {result}");
        }




        private void button2_Click(object sender, EventArgs e)
        {
            double value1 = double.Parse(textBox1.Text);
            double value2 = double.Parse(textBox2.Text);

            double result = value1 - value2;


            Result.Items.Clear();
            Result.Items.Add(result);

            Calculations.Items.Add($"{value1} - {value2} = {result}");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double value1 = double.Parse(textBox1.Text);
            double value2 = double.Parse(textBox2.Text);

            double result = value1 * value2;
            Result.Items.Clear();
            Result.Items.Add(result);

            Calculations.Items.Add($"{value1} * {value2} = {result}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double value1 = double.Parse(textBox1.Text);
            double value2 = double.Parse(textBox2.Text);

            double result = value1 / value2;

            Result.Items.Clear();
            Result.Items.Add(result);

            Calculations.Items.Add($"{value1} / {value2} = {result}");
        }

        private void Calculations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}