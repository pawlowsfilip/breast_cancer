using System;

public class Neuron
{
    public double[] Weights { get; set; }
    public double Bias { get; set; }

    public Neuron(int inputSize)
    {
        Random rand = new Random();
        Weights = new double[inputSize];
        for (int i = 0; i < inputSize; i++)
        {
            Weights[i] = rand.NextDouble();
        }
        Bias = rand.NextDouble();
    }

    public double ActivationFunction(double[] inputs)
    {
        double sum = 0.0;
        for (int i = 0; i < inputs.Length; i++)
        {
            sum += inputs[i] * Weights[i];
        }
        sum += Bias;
        return ReLu(sum);
    }

    private double ReLu(double x)
    {
        if (x > 0)
        {
            return x;
        }
        else
        {
            return 0;
        }
    }
}