using System;
using System.Collections.Generic;
using System.Text;

namespace c__StringMethods
{
     class stringMethods
    {
        static void Main(String[] args)
        {
            String str = "Rabeya Akter Lima";
            Console.WriteLine("Original String: " + str);
            // Length of the string
            int length = str.Length;
            Console.WriteLine("Length of the string: " + length);
            // Convert to uppercase
            String upperStr = str.ToUpper();
            Console.WriteLine("Uppercase: " + upperStr);
            // Convert to lowercase
            String lowerStr = str.ToLower();
            Console.WriteLine("Lowercase: " + lowerStr);
            // Substring
            String substring = str.Substring(0, 5);
            Console.WriteLine("Substring (0,5): " + substring);
            // Replace
            String replacedStr = str.Replace("Lima", "Limu");
            Console.WriteLine("Replaced String: " + replacedStr);
            // Trim
            String trimmedStr = "   Lima   ".Trim();
            Console.WriteLine("Trimmed String: '" + trimmedStr + "'");
            // Split
            String[] words = str.Split(' ');
            Console.WriteLine("Split words:");

            foreach (String word in words)
            {
                Console.WriteLine(word);
            }
            // Insert
            String userNAme = str.Insert(0, "@");
            Console.WriteLine("User Name: " + userNAme);
            // Remove
            String removedStr = str.Remove(0, 7);
            Console.WriteLine("Removed String: " + removedStr);
            // Check if string contains a substring
            bool contains = str.Contains("Akter");
            Console.WriteLine("Contains 'Akter': " + contains);
            // Check if string starts with a substring
            bool startsWith = str.StartsWith("Rabeya");
            Console.WriteLine("Starts with 'Rabeya': " + startsWith);
            // Check if string ends with a substring
            bool endsWith = str.EndsWith("Lima");
            Console.WriteLine("Ends with 'Lima': " + endsWith);
            // Check if string is null or empty
            bool isNullOrEmpty = String.IsNullOrEmpty(str);
            Console.WriteLine("Is null or empty: " + isNullOrEmpty);
            // Check if string is null or whitespace
            bool isNullOrWhiteSpace = String.IsNullOrWhiteSpace(str);
            Console.WriteLine("Is null or whitespace: " + isNullOrWhiteSpace);
            // Check if string is equal to another string
            bool isEqual = str.Equals("Rabeya Akter Lima");
            Console.WriteLine("Is equal to 'Rabeya Akter Lima': " + isEqual);
            // Check if string is equal to another string (case-insensitive)
            bool isEqualIgnoreCase = str.Equals("Rabeya Akter Lima", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Is equal to 'Rabeya Akter Lima' (case-insensitive): " + isEqualIgnoreCase);
            // Check if string is equal to another string (ordinal)
            bool isEqualOrdinal = str.Equals("Rabeya Akter Lima", StringComparison.Ordinal);
            Console.WriteLine("Is equal to 'Rabeya Akter Lima' (ordinal): " + isEqualOrdinal);
            // Check if string is equal to another string (invariant culture)
            bool isEqualInvariantCulture = str.Equals("Rabeya Akter Lima", StringComparison.InvariantCulture);
            Console.WriteLine("Is equal to 'Rabeya Akter Lima' (invariant culture): " + isEqualInvariantCulture);

            Console.ReadKey();
        }
    }
}
