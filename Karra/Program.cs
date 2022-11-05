using Project;
using Project.Data;


var a = Int32.Parse(Console.ReadLine() ?? string.Empty);

var context = new AppDbContext();
var numberExist = context.Numbers!.FirstOrDefault(c => c.KarraNumber == a);
if (numberExist is null && (a <= 10 || a > 1))
{

    context.Numbers!.Add(new Number()
    {
        KarraNumber = a
    });
    for (int i = 1; i < 10; i++)
    {
        context.NumberValues!.Add(new NumberValue()
        {
            Karra = $"{i}" + "*" + $"{a}" + "=" + $"{i * a}",
            NumberId = a
        });
        Console.WriteLine($"{i}" + "*" + $"{a}" + "=" + $"{i * a}");
        context.SaveChanges();

    }
    context.SaveChanges();
}
var numberExist1 = context.Numbers!.FirstOrDefault(c => c.KarraNumber == a);

if (numberExist1 is not null && (a <= 10 || a > 1))
{
    var value = context.NumberValues!.Where(v => v.NumberId == numberExist1.KarraNumber);

    foreach (var item in value)
    {
        Console.WriteLine(item.Karra);
    }
}
else
{
    Console.WriteLine("Iltimos 1 dan 10 gacha son kiriting");
}

