using System.Windows.Input;

public class Program
{
    public static void Main()
    {
        CommandHistory history = new CommandHistory();
        ICommand command = new TypeTextCommand ("Hello") ;
        history.ExecuteCommand(command) ; 
        command = new TypeTextCommand("World") ; 
        history.ExecuteCommand(command) ; 
        history.UndoLast() ; 
    }
}