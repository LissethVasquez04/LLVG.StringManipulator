using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLVG.StringManipulator
{
    public class StringManipulator
    {
        public string ReverseString(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Método para eliminar espacios en blanco
        public string RemoveSpaces(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            return input.Replace(" ", string.Empty);
        }

    }
}
