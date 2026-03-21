public class CSharpLinter : IFileSaveObserver
{
  public void NotifyOnSave (string fileName)
  {
    Console.WriteLine($"Analyzing {fileName} for syntax errors....");
  }
}