public class Program
{
    public static void Main()
    {
        VSCodeExtension extension = new VSCodeExtension(new Downloading());
        extension.Disable(); 
        Console.WriteLine("\n--- State Transition ---");
        extension.ChangeState(new Running());
        
        extension.Disable();
    }
}