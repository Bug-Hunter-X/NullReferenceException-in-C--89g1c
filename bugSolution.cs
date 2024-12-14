public class MyClass
{
    public int? MyProperty { get; set; } //Nullable int

    public void MyMethod()
    {
        // Handling potential null using the null-conditional operator
        Console.WriteLine(MyProperty?.ToString() ?? "MyProperty is null"); 
    }
}