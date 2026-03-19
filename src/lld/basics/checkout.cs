using Microsoft.VisualBasic;

public class CheckoutController
{
    private readonly IItemRepository _repository;
    private readonly DiscountFactory _factory;

    public CheckoutController(IItemRepository repository, DiscountFactory factory)
    {
        _repository = repository;
        _factory = factory;
    }

    public async Task<double> ProcessCheckout(int itemId, string discountCode)
    {
      double originalPrice = await _repository.GetItemPrice() ; 

      if (originalPrice > 0)
    {
      IDiscountStrategy discountStrategy = _factory.GetDiscountStrategy(discountCode) ; 
      DiscountCalculator discountCalculator = new DiscountCalculator(discountStrategy); 

      double finalPrice = discountCalculator.CalculateFinalPrice(originalPrice) ; 
      
      return finalPrice ; 
    }else
    {
      throw new Exception("Failed to fetch original price from database . Try again. ") ; 
    }
     }
}