
namespace Task1
{
    class Program1
{
    static void Main(string[] args)
        {
            string groupNumber = "pd24";

            string inputFile = $"text{groupNumber}.txt";
            string outputFile = $"result{groupNumber}.txt";

            string initialText = "перевести рядок у UPPERCASE.\nпорахувати кількість символів в рядку\nпорахувати кількість слів в рядку ";

            File.WriteAllText(inputFile, initialText);

            File.WriteAllText(outputFile, string.Empty);

            TextProcessor.ProcessFile(inputFile, outputFile, TextProcessor.ConvertToUpperCase);
            TextProcessor.ProcessFile(inputFile, outputFile, TextProcessor.CountCharacters);
            TextProcessor.ProcessFile(inputFile, outputFile, TextProcessor.CountWords);


            Console.WriteLine($"Всі операції виконано. Результати в файлі {outputFile}.");

        }
    }
}