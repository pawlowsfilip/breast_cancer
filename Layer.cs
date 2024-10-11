using System;

public class Layer
{
    public Neuron[] Neurons { get; set; }

    public Layer(int neuronsCount, int inputSize)
    {
        Neurons = new Neuron[neuronsCount];             // Number of neurons in layer
        for (int i = 0; i < neuronsCount; i++)
        {
            Neurons[i] = new Neuron(inputSize);
        }
    }

    public double[] FeedForward(double[] inputs)
    {
        double[] outputs = new double[Neurons.Length];  // output must be the size of number of neurons in layer
        for (int i = 0; i < Neurons.Length; i++)
        {
            outputs[i] = Neurons[i].ActivationFunction(inputs);
        }
        return outputs;
    }
}