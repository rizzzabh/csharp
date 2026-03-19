public interface IItemRepository
{
    Task<double> GetItemPrice();
}
public class ItemRepository : IItemRepository
{
  public async Task<double> GetItemPrice ()
  {
    await Task.Delay(2000) ; 
    
    return 100.0 ; 
  }
}