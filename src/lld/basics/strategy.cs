public interface IDiscountStrategy
{
  double CalculateDiscountedPrice(double originalPrice); 
}

public class FestivalDiscount : IDiscountStrategy
{
  public double CalculateDiscountedPrice (double originalPrice)
  {
    return originalPrice - 0.2*originalPrice ; 
  }
}
public class NoDiscount : IDiscountStrategy
{
  public double CalculateDiscountedPrice (double originalPrice)
  {
    return originalPrice ; 
  }
}


public class DiscountCalculator
{
  IDiscountStrategy discountStrategy ;

  public DiscountCalculator(IDiscountStrategy discountStrategy)
  {
    this.discountStrategy = discountStrategy ; 
  }
  public double CalculateFinalPrice(double originalPrice)
  {
    return discountStrategy.CalculateDiscountedPrice(originalPrice) ; 
  }
}