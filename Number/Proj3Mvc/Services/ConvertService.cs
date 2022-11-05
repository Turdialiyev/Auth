using Proj3Mvc.Data;

public class ConvertService
{
    private readonly AppDbContext _context;

    public ConvertService(AppDbContext context)
    {
        _context = context;
    }

    public string FromNumberToWords(long number)
    {
        string words = "";

        if ((number / 1000000000) > 0)
        {
            words += FromNumberToWords(number / 1000000000) + GetIfodaInDatabase(1000000000);
            number %= 1000000000;
        }
        if ((number / 1000000) > 0)
        {
            words += FromNumberToWords(number / 1000000) + GetIfodaInDatabase(1000000);
            number %= 1000000;
        }

        if ((number / 1000) > 0)
        {
            words += FromNumberToWords(number / 1000) + GetIfodaInDatabase(1000);
            number %= 1000;
        }

        if ((number / 100) > 0)
        {
            words += FromNumberToWords(number / 100) + GetIfodaInDatabase(100);
            number %= 100;
        }
        for (var i = 90; i > 0 ; i-=10)
        {
            if ((number / i) > 0)
            {
                words += GetIfodaInDatabase(i);
                number %= i;
            }
        }
        
        for (var i = 9; i > 0 ; i-=1)
        {
            if ((number / i) > 0)
            {
                words += GetIfodaInDatabase(i);
                number %= i;
            }
        }
        return words;
    }

    public string GetIfodaInDatabase(long num)
    {
        var result = _context.SonEntitylar.FirstOrDefault(n => n.Id == num);
        return result.Ifoda;
    }
}