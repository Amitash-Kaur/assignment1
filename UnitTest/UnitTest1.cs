using NUnit.Framework;
using SENG8040_Assignment01;
namespace UnitTest
{
    [TestFixture]
    public class UnitTest1
    {

        Rectangle TestObject = new Rectangle();
        [Test]
        public void GetLength_Constructor1_Returns1_1()
        {




            int Length1Actual = TestObject.GetLength();

            Assert.AreEqual(1, Length1Actual);
        }

        [Test]
        [TestCase(3)]
        [TestCase(12)]
        public void GetLength_Constructor2_ReturnSetValue(int NewLength)
        {
            Rectangle TestObject = new Rectangle(NewLength, 5);

            int Length1Actual = TestObject.GetLength();

            Assert.AreEqual(NewLength, Length1Actual);
        }

        //for GetWidth
        [Test]
        public void GetWidth_Constructor1_Returns1_1()
        {
            Rectangle TestObject = new Rectangle();

            int Width1Actual = TestObject.GetWidth();

            Assert.AreEqual(1, Width1Actual);
        }

        [Test]
        [TestCase(15)]
        [TestCase(1)]
        public void GetWidth_Constructor2_ReturnSetValue(int NewWidth)
        {
            Rectangle TestObject = new Rectangle(5, NewWidth);

            int Width1Actual = TestObject.GetWidth();

            Assert.AreEqual(NewWidth, Width1Actual);
        }

    }
}
