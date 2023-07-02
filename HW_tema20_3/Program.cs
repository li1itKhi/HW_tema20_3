Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int y = int.Parse(Console.ReadLine()!);

My_foo(x, y);
void My_foo(int a, int b)
{
    Console.Write("Введите операцию: ");
    string operation = Console.ReadLine()!;

    int result=0;

    switch (operation)
    {
        case "&":
            result =a & b;
            break;

        case "|":
            result = a | b;
            break;

        case "^":
            result = a ^ b;
            break;

        case "~":
            result = ~a;
            break;

        case "<<":
            result = a << b;
            break;

        case ">>":
            result = a >> b;
            break;

        default:
            Console.WriteLine("Error");
            break;
    }
    Console.WriteLine(result);
}
