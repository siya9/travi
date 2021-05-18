using NUnit.Framework;

namespace Oware.Tests
{   
    
    public class MockScoreHouse : IScoreHouse{
        
        
        public int GetCount() {
            throw new System.NotImplementedException();
        }

        public void AddSeed(Seed seed) {
            throw new System.NotImplementedException();
            
        }

        public void Reset() {
            throw new System.NotImplementedException();
        }

    }

    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test()
        {
            //ARRANGE
            House h1 = new House(1,1);
            // ACT
            h1.ResetHouse();
            // ASSERT
            Assert.AreEqual(4,h1.GetCount(), "The number of seeds should be 4");
            
        }

        [Test]
        public void Test2()
        {
            //ARRANGE
            // ACT
            Player p1 = new Player("John");
            // ASSERT
            //Assert.Pass(p1.AddSeedToScoreHouse(new Seed()));
            //MockScoreHouse.Verify();
            Assert.AreEqual(0, p1.GetScore(),"the test returns a void");
            p1.AddSeedToScoreHouse(new Seed());
            //p1.VerifyAll();
            //IScoreHouse.Verify();
            Assert.AreEqual(1, p1.GetScore(),"the test should add one score");
            
        }

    }
}