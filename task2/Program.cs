var count = int.Parse(Console.ReadLine()!);

for (int i = 0; i < count; i++)
{
    var dmy = Console.ReadLine()!.Split();
    var day = int.Parse(dmy[0]);
    var month = int.Parse(dmy[1]);
    var year = int.Parse(dmy[2]);

    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
    {
        if (month % 2 == 1 && month <= 7 || month % 2 == 0 && month > 7)
        {
            Console.WriteLine("YES");
        }
        else
        {
            if (month == 2)
            {
                Console.WriteLine(day <= 29 ? "YES" : "NO");
            }
            else
            {
                Console.WriteLine(day <= 30 ? "YES" : "NO");
            }
        }
    }
    else
    {
        if (month % 2 == 1 && month <= 7 || month % 2 == 0 && month > 7)
        {
            Console.WriteLine("YES");
        }
        else
        {
            if (month == 2)
            {
                Console.WriteLine(day <= 28 ? "YES" : "NO");
            }
            else
            {
                Console.WriteLine(day <= 30 ? "YES" : "NO");
            }
        }
    }
}