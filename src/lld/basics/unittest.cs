// using Xunit;
// using Moq;

// public class CheckoutControllerTests
// {
//     [Fact]
//     public async Task ProcessCheckout_WithFestivalDiscount_ReturnsCorrectPrice()
//     {
//         Mock<IItemRepository> mockRepo = new Mock<IItemRepository>();
        
//         mockRepo.Setup(repo => repo.GetItemPrice()).ReturnsAsync(100.0);
 
//         DiscountFactory realFactory = new DiscountFactory();

//         CheckoutController checkoutController = new CheckoutController(mockRepo.Object ,realFactory) ;
//         double finalPrice = await checkoutController.ProcessCheckout(1 , "FesTival") ;

//          Assert.Equal(80.0, finalPrice);
//     }
// }