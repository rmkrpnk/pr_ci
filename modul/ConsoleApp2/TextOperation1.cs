namespace Task1
{
    public delegate string TextOperation1(string text);
    public static class TextProcessor
    {
        public static string ConvertToUpperCase(string text)
        {
            return "Текст у UPPERCASE:\n" + text.ToUpper();
        }
        public static string CountCharacters(string text)
        {
            return "Загальна кількість символів у тексті: " + text.Length;
        }
        public static string CountWords(string text)
        {
            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            return "Загальна кількість слів у тексті: " + words.Length;
        }
        public static void ProcessFile(string inputFilePath, string outputFilePath, TextOperation1 operation)
        {
            string content = File.ReadAllText(inputFilePath);

            string result = operation(content);

            string formattedResult = $"Результат операції {operation.Method.Name} \n{result}\n\n";

            File.AppendAllText(outputFilePath, formattedResult);
        }
    }
}