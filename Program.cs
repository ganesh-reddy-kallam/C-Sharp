// See https://aka.ms/new-console-template for more information

class program{
    public static void Main(String[] args){
var dt = new DateTime();
DateTime d1 = DateTime.Now;
DateTime d2 = DateTime.UtcNow;
DateTime d3 = DateTime.Today;

Console.WriteLine("Hello, World!");
Console.WriteLine(dt);
Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(d3);
}
}