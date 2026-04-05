using System.Text;


public static class Identifier
{
    public static string Clean(string identifier)
    {
       
    var result = new StringBuilder();
    bool makeUpper = false;

    foreach (char c in identifier)
    {
        if (c == ' ')
        {
            result.Append('_');
            makeUpper = false;
        }
        else if (char.IsControl(c))
        {
            result.Append("CTRL");
            makeUpper = false;
        }
        else if (c == '-')
        {
            makeUpper = true;
        }
        else if (c >= 'α' && c <= 'ω') // 🚨 remove Greek lowercase
        {
            continue;
        }
        else if (char.IsLetter(c))
        {
            if (makeUpper)
            {
                result.Append(char.ToUpper(c));
                makeUpper = false;
            }
            else
            {
                result.Append(c);
            }
        }
       
    }

    return result.ToString();
        throw new NotImplementedException($"Please implement the (static) Identifier.Clean() method");
    }
}
