using System.Linq;
using System.Text.RegularExpressions;

namespace codewars;

public class CamelCase
{
    public static Regex regex = new Regex(@"[\-_]", RegexOptions.CultureInvariant | RegexOptions.Compiled);

    public static string ToCamelCase(string str) =>    
        string.Concat( 
            regex.Split(str)
                 .Select((word, index) => index == 0 ? word : char.ToUpper(word[0]) + word.Substring(1))
        );
}
