using System;
using Xunit;
using DemoConsoleApp1;

namespace XUnitTestProject1
{
    public class DemoPaymentTest
    {
        [Fact]
        public void TestForPhysicalProduct()
        {
            //arrange
            string expectedresult = "Generate a packing slip for shipping!";

            IProduct  product = new PhysicalProduct();

            // act 
            var rtntext = product.ProcessPayment();

            // assert
            Assert.Equal(expectedresult, rtntext);
        }

        [Fact]
        public void TestForBook()
        {
            //arrange
            string expectedresult = "Generate a duplicate packing slip for the royalty department!";

            IProduct product = new Book();

            // act 
            var rtntext = product.ProcessPayment();

            // assert
            Assert.Equal(expectedresult, rtntext);
        }

        [Fact]
        public void TestForNewMembership()
        {
            //arrange
            string expectedresult = "Activate Membership!";

            IProduct product = new NewMembership();

            // act 
            var rtntext = product.ProcessPayment();

            // assert
            Assert.Equal(expectedresult, rtntext);
        }

        [Fact]
        public void TestForUpgradeMembership()
        {
            //arrange
            string expectedresult = "Upgrade Membership!";

            IProduct product = new UpgradeMembership();

            // act 
            var rtntext = product.ProcessPayment();

            // assert
            Assert.Equal(expectedresult, rtntext);
        }

        [Fact]
        public void TestForVideo()
        {
            //arrange
            string expectedresult = "Add additional video!";

            IProduct product = new Video();

            // act 
            var rtntext = product.ProcessPayment();

            // assert
            Assert.Equal(expectedresult, rtntext);
        }
    }
}
