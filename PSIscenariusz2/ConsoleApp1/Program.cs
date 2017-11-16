using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private readonly Network network = new Network();
        private readonly string[] letter = {"A", "B","C","D","E","F","G","H","I","J",
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };

        private  static int imageSize = 5;
        static void Main(string[] args)
        {
            var p = new Program();
            p.network.maximumIteration = int.Parse(10000.ToString());
            p.Test();
            p.Check();

            Console.ReadKey();
        }

        private void Test()
        {
            int length = letter.Length;
            network.Initialize(imageSize * imageSize, length);

            double[][] input = new double[length][];
            double[][] output = new double[length][];

            for (int i = 0; i < length; ++i)
            {
                output[i] = new double[length];

                for (int j = 0; j < length; ++j)
                {
                    output[i][j] = i == j ? 1.0 : 0.0;
                }

                network.outputLayer[i].Value = letter[i];
            }

            input[0] = new double[25] { 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1 };
            input[1] = new double[25] { 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 1, 1, 1, 0, 0 };
            input[2] = new double[25] { 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1 };
            input[3] = new double[25] { 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 1, 0, 0 };
            input[4] = new double[25] { 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1 };
            input[5] = new double[25] { 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0 };
            input[6] = new double[25] { 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 0 };
            input[7] = new double[25] { 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1 };
            input[8] = new double[25] { 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0 };
            input[9] = new double[25] { 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 1, 0, 0 };
            input[10] = new double[25] { 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0 };
            input[11] = new double[25] { 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 1, 0, 0 };
            input[12] = new double[25] { 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 };
            input[13] = new double[25] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 1, 0, 0 };
            input[14] = new double[25] { 0, 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 1, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0 };
            input[15] = new double[25] { 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0 };
            input[16] = new double[25] { 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0 };
            input[17] = new double[25] { 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0 };
            input[18] = new double[25] { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0 };
            input[19] = new double[25] { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0 };


            network.TrainNetwork(input, output);

            Console.WriteLine("Bledy:");
            for (int i = 0; i < network.currentIteration; ++i)
            {
                Console.WriteLine( i + "\t"+ network.errors[i].ToString("#0.000000"));
            }
        }

        private void Check()
        {
            double[] sample = new double[imageSize * imageSize];

            sample = new double[25] {0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0};

            network.Recognize(sample);

            Console.WriteLine("Wyniki:");
            var results = new double[letter.Length];
            for (int i = 0; i < network.outputLayer.Length; ++i)
            {
                results[i] = network.outputLayer[i].Output;
                Console.WriteLine(network.outputLayer[i].Value);
                Console.WriteLine(network.outputLayer[i].Output.ToString("#0.000000"));
            }

            int w = results.ToList().IndexOf(results.Max());
            if(w > letter.Length/2)
                Console.WriteLine("Wykryto małą literkę: " + network.outputLayer[w].Value);
            else
            {
                Console.WriteLine("Wykryto dużą literkę: " + network.outputLayer[w].Value);
            }
        }


    }

    class Network
    {
        public struct InLayer
        {
            public double Value;
            public double[] Weights;
        }

        public struct OutLayer
        {
            public double InputAmount;
            public double Output;
            public double Error;
            public double Target;
            public string Value;
        }

        public double learningRate = 0.35;
//        public double learningRate = 0.25;
//        public double learningRate = 0.15;

        public int ImageSize = 0;
        public int InputNum = 0;
        public int OutputNum = 0;

        public InLayer[] inputLayer = null;
        public OutLayer[] outputLayer = null;

        public double[] errors = null;

        public int currentIteration = 0;
        public int maximumIteration = 1000;

        public void Initialize(int inputSize, int outputSize)
        {
            InputNum = inputSize;
            OutputNum = outputSize;

            inputLayer = new Network.InLayer[inputSize];
            outputLayer = new Network.OutLayer[outputSize];

            // Zainicjuj wagi losowymi wartościami z zakresu 0.01 - 0.02.
            Random random = new Random();

            for (int i = 0; i < InputNum; ++i)
            {
                inputLayer[i].Weights = new double[OutputNum];

                for (int j = 0; j < OutputNum; ++j)
                {
                    inputLayer[i].Weights[j] = random.Next(1, 3) / 100.0;
                }
            }
        }

        public bool TrainNetwork(double[][] inputs, double[][] outputs)
        {
            double currentError = 0.0, maximumError = 0.01;

            currentIteration = 0;

            // Utwórz tablicę do przechowywania wartości kolejnych błędów.
            errors = new double[maximumIteration];

            do
            {
                currentError = 0;

                for (int i = 0; i < inputs.Length; ++i)
                {
                    CalculateOutput(inputs[i], outputLayer[i].Value);
                    BackPropagation();

                    currentError += GetError();
                }

                errors[currentIteration] = currentError;

                ++currentIteration;
            }
            while (currentError > maximumError && currentIteration < maximumIteration);

            // Jeżeli maksymalny błąd został osiągnięty w mniejszej liczbie iteracji,
            // to nauka sieci zakończyła się pomyślnie.
            if (currentIteration <= maximumIteration)
            {
                return true;
            }

            return false;
        }

        private void CalculateOutput(double[] exampl, string output)
        {
            // Przypisz wejście do warstwy wejściowej.
            for (int i = 0; i < exampl.Length; i++)
            {
                inputLayer[i].Value = exampl[i];
            }

            // Oblicz wejście, wyjście, wartość oczekiwaną oraz błąd pierwszej warstwy.
            for (int i = 0; i < OutputNum; i++)
            {
                double total = 0.0;

                for (int j = 0; j < InputNum; j++)
                {
                    total += inputLayer[j].Value * inputLayer[j].Weights[i];
                }

                outputLayer[i].InputAmount = total;
                outputLayer[i].Output = Activation(total);
                outputLayer[i].Target = outputLayer[i].Value.CompareTo(output) == 0 ? 1.0 : 0.0;
                outputLayer[i].Error = (outputLayer[i].Target - outputLayer[i].Output) * (outputLayer[i].Output) * (1 - outputLayer[i].Output);
            }
        }

        private void BackPropagation()
        {
            // Popraw wagi warstwy wejściowej.
            for (int j = 0; j < OutputNum; j++)
            {
                for (int i = 0; i < InputNum; i++)
                {
                    inputLayer[i].Weights[j] += learningRate * (outputLayer[j].Error) * inputLayer[i].Value;
                }
            }
        }

        private double GetError()
        {
            double total = 0.0;

            for (int j = 0; j < OutputNum; j++)
            {
                total += Math.Pow((outputLayer[j].Target - outputLayer[j].Output), 2.0) / 2.0;
            }

            return total;
        }

        private double Activation(double x)
        {
            return (1.0 / (1.0 + Math.Exp(-x)));
        }

        public void Recognize(double[] input)
        {
            for (int i = 0; i < InputNum; i++)
            {
                inputLayer[i].Value = input[i];
            }

            for (int i = 0; i < OutputNum; i++)
            {
                double tmp = 0.0;

                for (int j = 0; j < InputNum; j++)
                {
                    tmp += inputLayer[j].Value * inputLayer[j].Weights[i];
                }

                outputLayer[i].InputAmount = tmp;
                outputLayer[i].Output = Activation(tmp);
            }
        }
    }

}
