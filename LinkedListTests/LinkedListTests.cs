using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList.LinkedList;

namespace LinkedList.LinkedListTests
{
    [TestClass]
    public class LinkedListTests
    {
        private MyLinkedList<int> _list;

        [TestInitialize]
        public void TestInitialize()
        {
            _list = new();
        }

        [TestMethod]
        public void AddItem_WhenAddOneItem_ThenContainsOneItem()
        {
            //arrange
            int item = 1;

            //act
            _list.AddFirst(item);

            //assert
            Assert.AreEqual(1, _list.Count);
        }

        [TestMethod]
        public void AddItem_WhenAddOneItem_ThenItemInList()
        {
            //arrange
            int item1 = 1000;

            //act
            _list.AddFirst(item1);

            //assert
            Assert.AreEqual(item1, _list.First.Value);
        }
        
        [TestMethod]
        public void AddItems_WhenAddTwoItems_ThenPreviousItemInListIsSecond()
        {
            //arrange
            int item1 = 1000;
            int item2 = 100;

            //act
            _list.AddFirst(item1);
            _list.AddFirst(item2);

            //assert
            Assert.AreEqual(item2, _list.Last.Previous.Value);
        }
        
        [TestMethod]
        public void RemoveItems_WhenAddThreeItemsAndRemoveFirst_ThenNewFirstItemInList()
        {
            //arrange
            int item1 = 1000;
            int item2 = 100;
            int item3 = 10;

            //act
            _list.AddFirst(item1);
            _list.AddFirst(item2);
            _list.AddFirst(item3);
            
            _list.RemoveFirst();

            //assert
            Assert.AreEqual(item2, _list.First.Value);
        }
        
        [TestMethod]
        public void UpdateItem_WhenAddOneItemAndUpdateFirst_ThenNewFirstItemInList()
        {
            //arrange
            int item1 = 1000;
            int item2 = 333;

            //act
            _list.AddFirst(item1);

            _list.First.Value = item2;

            //assert
            Assert.AreEqual(item2, _list.First.Value);
        }
        
        [TestMethod]
        public void FindIndexOfItemInList()
        {
            //arrange
            int item1 = 1000;
            int item2 = 333;
            int item3 = 1111;
            int item4 = 233;
            int item5 = 1200;
            int item6 = 113;

            //act
            _list.AddFirst(item1);
            _list.AddFirst(item2);
            _list.AddFirst(item3);
            _list.AddFirst(item4);
            _list.AddFirst(item5);
            _list.AddFirst(item6);

           

            //assert
            Assert.AreEqual(4,  _list.IndexOf(333));
        }

        [TestMethod]
        public void ContainsItemInList()
        {
            // arrange
            int item1 = 1000;
            int item2 = 100;
            int item3 = 10;

            // act
            _list.AddFirst(item1);
            _list.AddFirst(item2);
            _list.AddFirst(item1);
            _list.AddFirst(item3);

            bool isInList = _list.Contains(1000);

            //assert
            Assert.AreEqual(true, isInList);
        }
    }
}

