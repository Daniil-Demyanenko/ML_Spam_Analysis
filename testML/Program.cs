using System;
using TestMLML.Model;

namespace testML
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput();
            // Load model and predict output of sample data
            ModelOutput result;

            while (true)
            {
                input.Message = Console.ReadLine();
                result = ConsumeModel.Predict(input);
                Console.WriteLine((result.Prediction ? "Spam":"Not spam") + " \n" + result.Score+"\n");
            }
        }
    }
}
