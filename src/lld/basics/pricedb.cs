
public class ItemRepository
{
  public async Task<double> GetItemPrice ()
  {
    await Task.Delay(2000) ; 
    
    return 100.0 ; 
  }
}