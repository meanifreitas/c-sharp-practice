double n1, n2, result;
char op;
Console.WriteLine("Input first value: ");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Input second value: ");
n2 = double.Parse(Console.ReadLine());
Console.WriteLine("Select an operation: ");
Console.WriteLine("+ ---> sum\n- ---> subtract");
Console.WriteLine("* ---> multiply\n/ ---> divide");
op = char.Parse(Console.ReadLine());

switch (op)
{

    case '+':
        result = n1 + n2;
        Console.WriteLine(n1 + " + " + n2 + " = " + result);
        break;
    case '-':
        result = n1 - n2;
        Console.WriteLine(n1 + " - " + n2 + " = " + result);
        break;
    case '*':
        result = n1 * n2;
        Console.WriteLine(n1 + " * " + n2 + " = " + result);
        break;
    case '/':
        result = n1 / n2;
        Console.WriteLine(n1 + " / " + n2 + " = " + result);
        break;
    default:
        Console.WriteLine("Invalid operation");
        break;
}