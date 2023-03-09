namespace CanedaGinalyn_PerceptronAlgorithm
{
    public partial class Form1 : Form
    {
        Perceptron perceptron;
        double[][] trainingData;
        int[] targets;

        public Form1()
        {
            InitializeComponent();
        }

        private void oRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            perceptron = new Perceptron(2, 0.3);
            trainingData = new double[][] { new double[] { 0, 0 }, new double[] { 0, 1 }, new double[] { 1, 0 }, new double[] { 1, 1 } };
            targets = new int[] { 0, 1, 1, 1 };
        }

        private void nOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            perceptron = new Perceptron(1, 0.3);
            trainingData = new double[][] { new double[] { 0 }, new double[] { 1 } };
            targets = new int[] { 1, 0 };
        }

        private void aNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            perceptron = new Perceptron(2, 0.3);
            trainingData = new double[][] { new double[] { 0, 0 }, new double[] { 0, 1 }, new double[] { 1, 0 }, new double[] { 1, 1 } };
            targets = new int[] { 0, 0, 0, 1 };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void xORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            perceptron = new Perceptron(2, 1);
            trainingData = new double[][] { new double[] { 0, 0 }, new double[] { 0, 1 }, new double[] { 1, 0 }, new double[] { 1, 1 } };
            targets = new int[] { 0, 1, 1, 0 };
        }

        private void nANDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            perceptron = new Perceptron(2, 0.3);
            trainingData = new double[][] { new double[] { 0, 0 }, new double[] { 0, 1 }, new double[] { 1, 0 }, new double[] { 1, 1 } };
            targets = new int[] { 1, 1, 1, 0 };
        }

        private void nORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            perceptron = new Perceptron(2, 0.3);
            trainingData = new double[][] { new double[] { 0, 0 }, new double[] { 0, 1 }, new double[] { 1, 0 }, new double[] { 1, 1 } };
            targets = new int[] { 1, 0, 0, 0 };
        }

        private void xNORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            perceptron = new Perceptron(2, 1);
            trainingData = new double[][] { new double[] { 0, 0 }, new double[] { 0, 1 }, new double[] { 1, 0 }, new double[] { 1, 1 } };
            targets = new int[] { 1, 0, 0, 1 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input1, input2;
            perceptron.Train(trainingData, targets);

            if (textBox2.Enabled == false)
            {
                input1 = int.Parse(textBox1.Text);
                textBox3.Text = (perceptron.Activate(new double[] { input1 })).ToString();
            }
            else
            {
                input1 = int.Parse(textBox1.Text);
                input2 = int.Parse(textBox2.Text);
                textBox3.Text = (perceptron.Activate(new double[] { input1, input2 })).ToString();
            }
        }
    }
}