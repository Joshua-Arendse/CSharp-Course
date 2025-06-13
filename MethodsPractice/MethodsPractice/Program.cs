// See https://aka.ms/new-console-template for more information

// Methods are structured like this
// modifier returnType MethodName(Parameters){
// code block
// }

//Definition of a void: method that returns nothing

void MyFirstMethod()
{
    Console.WriteLine("The Method was called");
    Console.WriteLine("Some super complicated code");
}

//Calling a Method
MyFirstMethod();
MyFirstMethod();
MyFirstMethod();
MyFirstMethod();

Console.WriteLine("This is outside the method");

Console.ReadKey();
//Parameters
void WriteSomething()
{
    Console.WriteLine("I'm writng something!");
}

WriteSomething();

//A method that has the parameter myString of type string
// Method Decleration
void WriteSomethingSpecific(string myString)
{
    Console.WriteLine("You passed this argument " + myString);
}
string myUserName = "Josh";

//Calling the method using an Argument called "myUserName"
WriteSomethingSpecific(myUserName);

Console.ReadKey();

//Return Type and 2 Parameters.
int AddTwoValues(int value1, int value2) //using a datatype that isn't void has to have the Return statement or an error will occur (the returned value has to be the same datatype as the method)
{
    int result = value1 + value2;
    //Console.WriteLine("The result is " + result);
    return result; //cannot use return with a void method
}

AddTwoValues(2, 67);
//Also
int myResult = AddTwoValues(29, 13);
Console.WriteLine("The result is " + myResult);
//also
Console.WriteLine("Enter a number, I will add 10 to it!");
int num1 = int.Parse(Console.ReadLine());
int myResult1 = AddTwoValues(num1, 10);
Console.WriteLine("The result is " + myResult1);

Console.ReadKey();