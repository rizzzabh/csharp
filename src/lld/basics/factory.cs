public class DiscountFactory
{
  public IDiscountStrategy GetDiscountStrategy(string discountType)
  {
    switch (discountType.ToLower())
    {
      case ("festival") : 
        return new FestivalDiscount() ; 

      default : 
        return new NoDiscount() ; 
    }
  }
}