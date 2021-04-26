using System;
using System.Text.RegularExpressions;

namespace FavoriteGames.Shared.Helpers
{
    public static class ValidateHelper
    {
        public static void IsNullOrEmptyStringValidate(string item)
        {
            var itemIsNullOrEmpty = string.IsNullOrEmpty(item);
            if (itemIsNullOrEmpty)
            {
                throw new ArgumentException(nameof(item));
            }
        }

        public static void IsNullOrEmptyIntValidate(int item)
        {
            var itemIsNullOrEmpty = string.IsNullOrEmpty(item.ToString());
            if (itemIsNullOrEmpty)
            {
                throw new ArgumentException(nameof(item));
            }
        }

        public static void PhoneNumberValidate(string phoneNumber)
        {
            if (!string.IsNullOrEmpty(phoneNumber))
            {
                const string pattern = @"(\(?\d{2}\)?)(\D*)9(\d{4})([-]?|\s*?)(\d{4})";
                
                var isCorrectly = Regex.Match(phoneNumber, pattern).Success;
                if (!isCorrectly)
                {
                    throw new Exception("Number is not valid.");
                }
            }
            else
            {
                throw new Exception("Number is required.");
            }
        }
    }
}