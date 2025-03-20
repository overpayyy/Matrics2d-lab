using Matrics2dLib;


namespace Matrix2dTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Konstructor_WieleArgumentow_Poprawnie_OK()
        {
            var m = new Matrix2d(1, 2, 3, 4);

            // Assert
            Assert.AreEqual(1, m.A);
            Assert.AreEqual(2, m.B);
            Assert.AreEqual(3, m.C);
            Assert.AreEqual(4, m.D);
        }

        [TestMethod]
        public void Konstructor_BezArgumentow_Poprawnie_OK()
        {
            var m = new Matrix2d();

            // Assert
            Assert.AreEqual(1, m.A);
            Assert.AreEqual(0, m.B);
            Assert.AreEqual(0, m.C);
            Assert.AreEqual(1, m.D);
        }
    }
}
