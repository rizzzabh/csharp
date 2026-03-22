public interface IExtensionState
{
  void Activate() ; 
  void Disable() ; 

}


public class Downloading : IExtensionState
{
  public void Activate ()
  {
    Console.WriteLine("Dowload activated.");
  }

  public void Disable ()
  {
    Console.WriteLine("Download deactivated.");
  }

}
public class Running : IExtensionState
{
  public void Activate ()
  {
    Console.WriteLine("Running.");
  }

  public void Disable ()
  {
    Console.WriteLine("Shutting down the background process.");
  }

}