using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanedaGinalyn_PerceptronAlgorithm
{
    public class Perceptron
    {
        private double[] weights;
        private double learningRate;
        private double[] inputs;
        private int target;

        public Perceptron(int numInputs, double rate)
        {
            weights = new double[numInputs + 1];
            Random rand = new Random();
            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = rand.NextDouble() * 2 - 1; // initialize weights to random values between -1 and 1
            }
            learningRate = rate;
        }

        public int Activate(double[] input)
        {
            inputs = new double[input.Length + 1];
            for (int i = 0; i < input.Length; i++)
            {
                inputs[i] = input[i];
            }
            inputs[input.Length] = 1; // bias input
            double sum = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                sum += inputs[i] * weights[i];
            }
            return sum > 0 ? 1 : 0; // hard-limiting function
        }

        public void Train(double[][] trainingData, int[] targets)
        {
            int epoch = 0;
            while (true)
            {
                int errors = 0;
                for (int i = 0; i < trainingData.Length; i++)
                {
                    int output = Activate(trainingData[i]);
                    target = targets[i];
                    if (output != target)
                    {
                        errors++;
                        UpdateWeights(output);
                    }
                }
                epoch++;
                if (errors == 0)
                {
                    Console.WriteLine("Training complete in {0} epochs", epoch);
                    return;
                }
            }
        }

        private void UpdateWeights(int output)
        {
            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] += learningRate * (target - output) * inputs[i];
            }
        }
    }
}
