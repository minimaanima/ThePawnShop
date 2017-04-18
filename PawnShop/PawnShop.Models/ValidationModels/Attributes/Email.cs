namespace PawnShop.Models.ValidationModels.Attributes
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Text.RegularExpressions;

    [AttributeUsage(AttributeTargets.Property)]
    public class Email : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string stringValue = value as string;
            if (stringValue == null)
            {
                throw new ArgumentNullException("Email should be of type string and not null !");
            }

            string pattern =
                @"^(([a-zA-Z]|\d)([a-zA-Z]*[\.\-_]*\d*)+[a-zA-Z]|\d)+@([a-zA-Z]{2,}\.[a-zA-Z]{2,}((\.[a-zA-Z]{2,})?)+)$";
            var regex = new Regex(pattern);
            var match = regex.Match(stringValue);

            if (!match.Success)
            {
                return false;
            }

            return true;
        }
    }
}
