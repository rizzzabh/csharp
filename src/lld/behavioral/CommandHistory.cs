using System.Windows.Input;

public class CommandHistory
{
  private Stack<ICommand> _history = new Stack<ICommand>() ; 

  public void ExecuteCommand(ICommand command)
  {
    _history.Push(command) ; 
    command.Execute() ; 
    Console.WriteLine($"Executing command {command}");
  }

  public void UndoLast()
  {

    if (_history.Count > 0)
    {
      ICommand command = _history.Pop() ; 
      command.Undo() ; 
      Console.WriteLine($"Undoing command {command}") ; 
    }else
    {
      throw new Exception ("Nothing to retrieve") ;
    }
  }
}