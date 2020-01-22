using System.Collections.Generic;
using TestingDemo.Models;

namespace TestingDemo
{
    public class CodeGeneratorService
    {
        private List<string> vowels = new List<string>
        {
            "a", "e", "i", "o", "u"
        };

        public CodeGenerationResult GenerateCode(string input)
        {
            CodeGenerationResult result = new CodeGenerationResult { };

            if(string.IsNullOrEmpty(input))
            {
                result.IsSuccessful = false;
                result.Error = "Input cannot be null or empty";

                return result;
            }

            if (input.Length < 3)
            {
                result.IsSuccessful = false;
                result.Error = "Input cannot be less than 3 characters";

                return result;
            }

            // Generazione PREFIX
            string prefix = string.Empty;

            if (IsVowel(input[0])) prefix = "VC";
            else prefix = "CS";

            // Generazione BODY
            string bodyEnding = IsVowel(input[2]) ? "00--" : "000:";
            string body = "B" + input.Length + bodyEnding;

            // Generazione SUFFIX
            string suffix = input.Length % 2 == 0 ? "$PR" : "$DS";

            result.Code = $"{prefix}{body}{suffix}";
            result.IsSuccessful = true;

            return result;
        }

        public bool IsVowel(char input)
        {
            return vowels.Contains(input.ToString().ToLower());
        }
    }
}