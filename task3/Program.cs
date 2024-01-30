using System.Text.RegularExpressions;

var count = int.Parse(Console.ReadLine()!);
var reg1 = new Regex(@"^[A-Z]\d\d[A-Z][A-Z]");
var reg2 = new Regex(@"^[A-Z]\d[A-Z][A-Z]");

int Match(string str)
{
    if (reg1.IsMatch(str))
        return 1;
    if (reg2.IsMatch(str))
        return 2;
    return 0;
}

List<string> ser = new List<string>();

for (int i = 0; i < count; i++)
{
    string res = "";
    var str = Console.ReadLine()!;
    for (; str.Length >= 5;)
    {
        var m = Match(str[..5]);
        if (m == 1)
        {
            res += str[..5]+" ";
            str = str[5..];
        }
        else if (m == 2)
        {
            res += str[..4]+" ";
            str = str[4..];
        }
        else
        {
            res = "";
            break;
        }
    }
    
    if (str.Length == 4)
    {
        var m = Match(str[..4]);
        if (m == 2)
        {
            res += str[..4];
            Console.WriteLine(res);
            ser.Add(res);
        }
        else
        {
            Console.WriteLine("-");
            ser.Add("-");
        }
    }
    else if (res == "")
    {
        Console.WriteLine("-");
        ser.Add("-");
    }

    else if (str.Length > 0)
    {
        Console.WriteLine("-");
        ser.Add("-");
    }
    else
    {
        Console.WriteLine(res);
        ser.Add(res);
    }
}
