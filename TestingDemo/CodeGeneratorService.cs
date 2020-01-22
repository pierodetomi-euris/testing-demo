using System.Collections.Generic;

namespace TestingDemo
{
    public class CodeGeneratorService
    {
        private List<string> vowels = new List<string>
        {
            "a", "e", "i", "o", "u"
        };

        public string GenerateCode(string input)
        {
            string code = string.Empty;

            // Generazione PREFIX
            string prefix = string.Empty;

            if (IsVowel(input[0])) prefix = "VC";
            else prefix = "CS";

            // Generazione BODY
            string bodyEnding = IsVowel(input[2]) ? "00--" : "000:";
            string body = "B" + input.Length + bodyEnding;

            // Generazione SUFFIX
            string suffix = input.Length % 2 == 0 ? "$PR" : "$DS";

            return $"{prefix}{body}{suffix}";
        }

        public bool IsVowel(char input)
        {
            return vowels.Contains(input.ToString().ToLower());
        }
    }
}