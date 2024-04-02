using Laba1_Ivanov;

//Rational num = new Rational(0, 1);
//Rational num2 = new Rational(1, 1);
//Rational res = num / num2;
//Console.WriteLine(res.Numerator.ToString() + res.Denominator.ToString());

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