string discountCode = "FesTivAl" ; 

DiscountFactory discountFactory = new DiscountFactory() ; 


IDiscountStrategy discountStrategy = discountFactory.GetDiscountStrategy(discountCode) ;

DiscountCalculator discountCalculator = new DiscountCalculator(discountStrategy) ; 

double finalPrice = discountCalculator.CalculateFinalPrice(200) ; 

Console.WriteLine(finalPrice) ; 