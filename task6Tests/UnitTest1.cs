using Task6;
namespace task6Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreationEmpty()
        {
            ElementSet set = new ElementSet();
            Assert.IsTrue(set.CheckEmpty());
            Assert.IsFalse(set.CheckFull());

        }
        [TestMethod]
        public void CreateFull()
        {
            ElementSet set = new ElementSet();
            Element element = new Element(1);
            set.PutElement(element);
            Assert.IsFalse(set.CheckEmpty());
            Assert.IsTrue(set.CheckFull());
        }
        [TestMethod]
        public void RemoveElement()
        {
            ElementSet set = new ElementSet();
            Element element = new Element(1);
            set.PutElement(element);
            Assert.IsTrue(set.RemoveElement(element));
            Assert.IsTrue(set.CheckEmpty());
            Assert.IsFalse(set.CheckFull());
        }
        [TestMethod]
        public void ReturnRandom()
        {
            ElementSet set = new ElementSet();
            Element element = new Element(1);
            set.PutElement(element);
            Assert.AreEqual(element, set.ReturnRandom());
        }
        [TestMethod]
        public void GetElements()
        {
            ElementSet set = new ElementSet();
            Element element = new Element(1);
            set.PutElement(element);
            Assert.AreEqual(element, set.GetElements()[0]);
        }
        [TestMethod]
        public void RemoveElementFalse()
        {
            ElementSet set = new ElementSet();
            Element element = new Element(1);
            Assert.IsFalse(set.RemoveElement(element));
        }

        [TestMethod]
        public void PutElementTwice()
        {
            ElementSet set = new ElementSet();
            Element element = new Element(1);
            set.PutElement(element);
            set.PutElement(element);
            Assert.AreEqual(1, set.GetElements().Count);
        }
        [TestMethod]
        public void RemoveElementTwice()
        {
            ElementSet set = new ElementSet();
            Element element = new Element(1);
            set.PutElement(element);
            set.RemoveElement(element);
            set.RemoveElement(element);
            Assert.AreEqual(0, set.GetElements().Count);
        }
        [TestMethod]
        public void CheckEvenCount()
        {
            ElementSet set = new ElementSet();
            Element element = new Element(2);
            set.PutElement(element);
            Assert.AreEqual(1, set.getEvenCount());
            set.RemoveElement(element);
            Assert.AreEqual(0, set.getEvenCount());
        }
    }
}
