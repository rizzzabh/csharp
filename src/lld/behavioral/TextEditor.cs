public class TextEditor
{
  private List<IFileSaveObserver> _fileSaveObservers = new List<IFileSaveObserver>(); 

  public void Attach(IFileSaveObserver fileSaveObserver)
  { 
    _fileSaveObservers.Add(fileSaveObserver) ; 
  }
  public void Save (string fileName)
  {
    Console.WriteLine("Saving the file ... ") ; 

    foreach (IFileSaveObserver ifso in _fileSaveObservers)
    {
      ifso.NotifyOnSave(fileName) ; 
    }
  }
}