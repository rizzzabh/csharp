public class Program
{
    public static void Main()
    {
        TextEditor editor = new TextEditor();
        CSharpLinter linter = new CSharpLinter();

        editor.Attach(linter) ; 
        editor.Save("helloPath") ;
    }
}