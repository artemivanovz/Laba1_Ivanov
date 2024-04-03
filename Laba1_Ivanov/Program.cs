using Laba1_Ivanov;

void task2()
{
    var item1 = new TimeEU();
    Console.WriteLine(item1.PrintTime());
    var item1Decorator = new InsertTextEU(item1);
    Console.WriteLine(item1Decorator.PrintTime());
    var item2 = new TimeUS();
    Console.WriteLine(item2.PrintTime());
    var item2Decorator = new InsertTextUS(item2);
    Console.WriteLine(item2Decorator.PrintTime());
}
task2();