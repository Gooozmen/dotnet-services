// using NUnit.Framework;
// using System.Threading.Tasks;
//
// [TestFixture]
// public class ServicesTests
// {
//     [Test]
//     public async Task CalculatorService_Add_Works()
//     {
//         // Arrange
//         var client = new CalculatorServiceClient(CalculatorServiceClient.EndpointConfiguration.BasicHttpBinding_ICalculatorService, "http://localhost:5000/CalculatorService.svc");
//
//         // Act
//         var result = await client.AddAsync(5, 3);
//
//         // Assert
//         Assert.AreEqual(8, result);
//     }
//
//     [Test]
//     public async Task CalculatorService_Subtract_Works()
//     {
//         var client = new CalculatorServiceClient(CalculatorServiceClient.EndpointConfiguration.BasicHttpBinding_ICalculatorService, "http://localhost:5000/CalculatorService.svc");
//
//         var result = await client.SubtractAsync(10, 4);
//
//         Assert.AreEqual(6, result);
//     }
//
//     [Test]
//     public async Task MessageService_SendMessage_ReturnsId()
//     {
//         var client = new MessageServiceClient(MessageServiceClient.EndpointConfiguration.BasicHttpBinding_IMessageService, "http://localhost:5000/MessageService.svc");
//
//         var id = await client.SendMessageAsync("Hello from NUnit!");
//
//         Assert.That(id, Is.Not.EqualTo(Guid.Empty));
//     }
// }
