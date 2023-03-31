using System.Reflection.Metadata;

namespace LinkedListLabD
{
    public class Tests
    {

        private LinkedList sll;

        [SetUp]
        public void Setup()
        {
            sll = new LinkedList();
        }

        [Test]
        public void TestPrepend()
        {
            sll.AddFirst("Joe Schmoe");

            // Assert that the Count is 1
            Assert.AreEqual(1, sll.Count);

            // Assert list has "Joe Blow"
            Assert.AreEqual("Joe Schmoe", sll.GetValue(0));

            sll.AddFirst("Joe Blow");
            Assert.AreEqual(2, sll.Count);
            Assert.AreEqual("Joe Schmoe", sll.GetValue(1));
        }

        [Test]
        public void TestAppend()
        {
            sll.AddFirst("John Smith");

            Assert.AreEqual(1, sll.Count);
            Assert.AreEqual("John Smith", sll.GetValue(0));

            sll.AddLast("Jane Doe");
            Assert.AreEqual (2, sll.Count);
            Assert.AreEqual("Jane Doe",sll.GetValue(1));
        }

        [Test]
        public void TestRemoveFirst()
        {
            sll.AddFirst("Jane Doe");
            sll.AddFirst("John Smith");
            sll.AddFirst("Joe Schmoe");
            sll.AddFirst("Joe Blow");
            sll.AddLast("Bob bobberson");
            sll.AddLast("Sam Sammerson");
            sll.AddLast("Dave Daverson");

            sll.RemoveFirst();
            Assert.AreEqual(6, sll.Count);
            Assert.AreEqual("Joe Schmoe", sll.GetValue(0));

            sll.RemoveFirst();
            Assert.AreEqual(5,sll.Count);
            Assert.AreEqual("Bob bobberson", sll.GetValue(2));

        }
        
        [Test]
        public void TestRemoveLast()
        {
            sll.AddFirst("Joe Blow");
            sll.AddLast("Joe Schmoe");
            sll.AddLast("John Smith");
            sll.AddLast("Jane Doe");
            sll.AddLast("Bob Bobberson");
            sll.AddLast("Sam Sammerson");
            sll.AddLast("Dave Daverson");

            sll.RemoveLast();
            sll.RemoveLast();
            Assert.AreEqual(5,sll.Count);
            Assert.AreEqual("Bob Bobberson", sll.GetValue(4));
        }

        [Test]
        public void TestRetrieveValue()
        {
            sll.AddFirst("Joe Blow");
            sll.AddLast("Joe Schmoe");
            sll.AddLast("John Smith");
            sll.AddLast("Jane Doe");
            sll.AddLast("Bob Bobberson");
            sll.AddLast("Sam Sammerson");
            sll.AddLast("Dave Daverson");

            sll.GetValue(2);
            Assert.AreEqual(sll.GetValue(2), "John Smith");
        }
        
        [Test]
        public void TestCount()
        {
            sll.AddFirst("Joe Blow");
            sll.AddLast("Joe Schmoe");
            sll.AddLast("John Smith");
            sll.AddLast("Jane Doe");
            sll.AddLast("Bob Bobberson");
            sll.AddLast("Sam Sammerson");
            sll.AddLast("Dave Daverson");

            Assert.AreEqual(7, sll.Count);

        }

        [TearDown] 
        public void TearDown()
        {
            sll.Head = null;
            sll.Count= 0;
        }

    }
}