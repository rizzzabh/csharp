public class TypeTextCommand : ICommand
{
  private string _text ; 
  public TypeTextCommand (string text)
  { 
    _text = text ; 
  }
  public void Execute ()
  {
    Console.WriteLine($"Typing {_text} ...") ;
  }

  public void Undo ()
  {
    Console.WriteLine($"Deleting {_text} ... ") ;
  }
}