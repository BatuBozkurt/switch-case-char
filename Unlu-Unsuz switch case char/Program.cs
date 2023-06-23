Console.Write("Bir harf giriniz:  ");
char harf = char.Parse(Console.ReadLine().ToLower());
switch (harf)
{
    case 'a':
    case 'e':
    case 'ı':
    case 'i':
    case 'u':
    case 'ü':
    case 'o':
    case 'ö':
        Console.WriteLine("ünlü harf"); break;
        default: Console.WriteLine("Ünsüz harf"); break;
}
