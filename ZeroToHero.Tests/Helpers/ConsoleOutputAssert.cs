using System;
using System.IO;

namespace ZeroToHero.Tests.Helpers
{
    public static class ConsoleOutputAssert
    {
        public static void AreEqual(string expected, Action outputGeneratingAction)
        {
            outputGeneratingAction.Invoke();

            var generatedOutput = GetGeneratedOutput(outputGeneratingAction);
            if (generatedOutput != expected)
            {
                throw new Exception("Generated output does not equal expected output");
            }
        }

        public static void AreEqual(Action expectedOutputGeneratingAction, Action outputGeneratingAction)
        {
            expectedOutputGeneratingAction.Invoke();
            outputGeneratingAction.Invoke();

            var expectedGeneratedOutput = GetGeneratedOutput(expectedOutputGeneratingAction);
            var generatedOutput = GetGeneratedOutput(outputGeneratingAction);

            if (generatedOutput != expectedGeneratedOutput)
            {
                throw new Exception("Generated output does not equal expected output");
            }
        }

        public static void AreNotEqual(Action expectedOutputGeneratingAction, Action outputGeneratingAction)
        {
            expectedOutputGeneratingAction.Invoke();
            outputGeneratingAction.Invoke();

            var expectedGeneratedOutput = GetGeneratedOutput(expectedOutputGeneratingAction);
            var generatedOutput = GetGeneratedOutput(outputGeneratingAction);

            if (generatedOutput == expectedGeneratedOutput)
            {
                throw new Exception("Generated output equals expected output");
            }
        }

        private static string GetGeneratedOutput(Action outputGeneratingAction)
        {
            using (var output = new StringWriter())
            {
                Console.SetOut(output);

                outputGeneratingAction.Invoke();

                return output.ToString();
            }
        }
    }
}
