using AntraAssignment3;

/* Test your Knowledge
 * 1. Six access modifier types:
 * - public: field can be accessed by any other class
 * - private: field can only be accessed within the class
 * - protected: can be accessed within the class or from derived classes
 * - internal: can be accessed by code within the same package
 * - protected internal: can be accessed by code in the same package or by derived classes in a different package
 * - private protected: can only be accessed by derived classes in the same package
 * 
 * 2. 
 * - static: code that is static belongs to the class itself and can not need to be instantiated to use
 * - const: code that is const is used to label a field as a constant which cannot change
 * - readonly: fields that are readonly can only be assigned a value in its declaration or in the constructor
 * 
 * 3. A constructor is a method that is called immediately when a class object is instantiated. 
 * All code in it will run before any other methods can be called. It can be overloaded and will have a default constructor if none exist.
 * 
 * 4. The partial keyword allows classes and methods to be split into multiple files. This allows multiple people
 * to work on multiple files and combine them later on at compile time.
 * 
 * 5. A tuple is a set of attributes or information of a given object.
 * 
 * 6. Record defines a reference type to provide built-in functionality
 * 
 * 7. Overloading means providing the same methid multiple times, but providing each one with a
 * different combination of parameters. The method called will be the one that has matching parameters.
 * 
 * Overridng is when a method has the same name as a method in an inherited class. The method called will begin 
 * in the most recent derived class with the method.
 * 
 * 8. Fields are the data variables of a class. Properties are methods that allow us to retrieve and set those variables.
 * 
 * 9. A parameter can be default, so nothing needs to be passed. It can also use the optinal keyword. Another way is to 
 * create an overloaded method without the parameter.
 * 
 * 10. An interface can have method names and fields but cannot be instantiated or implements. They are forced to be implemented
 * in the class that inherits it.
 * 
 * Abstract classes can have implementation but must have at least one abstract method which cannot be implemented.
 * Also cannot be instantiated.
 * 
 * 11. They are public or internal.
 * 
 * 12. True
 * 
 * 13. True
 * 
 * 14. False
 * 
 * 15. False
 * 
 * 16. True
 * 
 * 17. True
 * 
 * 18. True
 * 
 * 19. True
 * 
 * 20. False
 * 
 * 21. True
 * 
 * 22. False
 * 
 * 23. True
 * */

Main();

static void Main()
{
    //Question 1
    Console.WriteLine("Question 1");
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());
    int[] numbers = GenerateNumbers(num);
    Reverse(ref numbers);
    PrintNumbers(numbers);
    Console.WriteLine();
    Console.WriteLine("Question 2: Fibonacci");
    //fibonacci
    int[] fibonacci1 = new int[10];
    for(int i = 0; i < 10; i++)
    {
        if(i == 1 || i == 0)
        {
            fibonacci1[i] = 1;
        }
        else
        {
            fibonacci1[i] = fibonacci1[i-1] + fibonacci1[i-2];
        }
    }
    foreach(int num1 in fibonacci1)
    {
        Console.Write(num1 + " ");
    }
    Console.WriteLine();
    Console.Write("Enter a term in the fibonacci sequence: ");
    int fib = int.Parse(Console.ReadLine());
    Console.WriteLine(fibonacci(fib));
}

static int fibonacci(int n)
{
    if(n == 1 || n == 2)
    {
        return 1;
    }
    else
    {
        return fibonacci(n - 1) + fibonacci(n-2);
    }
}

static int[] GenerateNumbers(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = i;
    }
    return arr;
}

static void Reverse(ref int[] arr)
{
    int[] arr2 = new int[arr.Length];
    for (int j = 0; j < arr.Length; j++)
    {
        arr2[j] = arr[arr.Length - 1 - j];
    }
    arr = arr2;
}

static void PrintNumbers(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
}
Console.WriteLine();
//////////////////////////////

Console.WriteLine("Ball is created");

Color color = new Color(100, 10, 10, 100);
Ball ball = new Ball(10, color);

ball.Throw();
ball.Throw();
ball.Throw();
Console.WriteLine(ball.thrown());//3
ball.Throw();
Console.WriteLine(ball.thrown());//4
ball.pop();
ball.Throw();
ball.Throw();
Console.WriteLine(ball.thrown());//4



