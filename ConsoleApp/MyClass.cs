namespace ConsoleApp;

public class MyClass
{
    public int MyMethod(string param)
    {
        return param switch
        {
            "hello" => 42,
            _ => 99
        };
    }
}