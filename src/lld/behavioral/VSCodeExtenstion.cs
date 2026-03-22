public class VSCodeExtension
{
  private IExtensionState _extensionState  ; 

  public VSCodeExtension(IExtensionState extensionState)
  {
    _extensionState = extensionState ; 
  }

  public void Activate()
  {
    _extensionState.Activate();
  }
  public void Disable()
  {
    _extensionState.Disable() ;
  }

  public void ChangeState(IExtensionState extensionState)
  {
    _extensionState = extensionState ; 
  }

}