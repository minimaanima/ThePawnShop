namespace PawnShop.Models.ValidationModels.Attributes
{

    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    [AttributeUsage(AttributeTargets.Property)]
    public class Password : ValidationAttribute
    {
        private readonly int minLenght;
        private readonly int maxLenght;

        public Password(int minLenght = 0, int maxLenght = 30)
        {
            this.minLenght = minLenght;
            this.maxLenght = maxLenght;
        }

        public bool ShouldContainDigit { get; set; }

        public bool ShouldContainCapitalLetter { get; set; }

        public bool ShouldContainLowercaseLetter { get; set; }

        public bool ShouldContainSpecialSymbol { get; set; }

        public override bool IsValid(object value)
        {
            string stringValue = value as string;
            if (stringValue == null)
            {
                throw new ArgumentNullException("Email should be of type string and not null !");
            }

            if (stringValue.Length < minLenght || stringValue.Length > maxLenght)
            {
                return false;
            }

            if (ShouldContainCapitalLetter && !ContainsCapitalLetter(stringValue))
            {
                return false;
            }

            if (ShouldContainLowercaseLetter && !ContainsLowercaseLetter(stringValue))
            {
                return false;
            }

            if (ShouldContainDigit && !ContainsDigit(stringValue))
            {
                return false;
            }

            if (ShouldContainSpecialSymbol && !ContainsSpecialSymbol(stringValue))
            {
                return false;
            }

            return true;
        }

        private bool ContainsDigit(string input)
        {

            if (input.Count(char.IsDigit) != 0)
            {
                return true;
            }

            return false;
        }

        private bool ContainsCapitalLetter(string input)
        {

            if (input.Count(char.IsUpper) != 0)
            {
                return true;
            }

            return false;
        }

        private bool ContainsLowercaseLetter(string input)
        {
            if (input.Count(char.IsLower) != 0)
            {
                return true;
            }

            return false;
        }

        private bool ContainsSpecialSymbol(string input)
        {
            char[] specialSymbols = new[] { '!', '@', '#', '$', '%', '^', '%', '*', '(', ')', '_', '+', '>', '<', '?' };

            foreach (var symbol in input)
            {
                if (specialSymbols.Contains(symbol))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
