using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericsImplementatiom;
using NegativeNumberException;

namespace TestClass
{
    [TestClass]
    public class TestList
    {
        [TestMethod]
        public void ShouldGiveZeroIfArrayIsEmpty()
        {
            RecentlyUsedList<int> nums = new RecentlyUsedList<int>(5);
            int count=nums.NoOfElements();
            Assert.AreEqual(0,count , "Expected value is 0");
        }

        [TestMethod]
        public void ShouldGiveFourIfFourIsAddedToIndexZeroAndReturnCountOne()
        {
            RecentlyUsedList<int> nums = new RecentlyUsedList<int>(5);
            nums.AddItem(4);
            int count = nums.NoOfElements();
            Assert.AreEqual(1, count, "Expected value is 1");
            Assert.AreEqual(4, nums[0], "Expected value is 4");
        }

        [TestMethod]
        public void ShouldInsertValuesIfFourIsAddedToIndexZeroAndFiveIsAddedToIndexOneAndReturnCountTwo()
        {
            RecentlyUsedList<int> nums = new RecentlyUsedList<int>(5);
            nums.AddItem(4);
            nums.AddItem(5);
            int count = nums.NoOfElements();
            Assert.AreEqual(2, count, "Expected value is 2");
            Assert.AreEqual(5, nums[0], "Expected value is 5");
            Assert.AreEqual(4, nums[1], "Expected value is 4");
        }

        [TestMethod]
        public void ShouldGiveSixFiveFourIfFourIsAddedToIndexZeroAndFiveIsAddedToIndexOneAndSixIsAddedToIndexTwoAndReturnCountThree()
        {
            RecentlyUsedList<int> nums = new RecentlyUsedList<int>(5);
            nums.AddItem(4);
            nums.AddItem(5);
            nums.AddItem(6);
            int count = nums.NoOfElements();
            Assert.AreEqual(3, count, "Expected value is 3");
            Assert.AreEqual(6, nums[0], "Expected value is 6");
            Assert.AreEqual(5, nums[1], "Expected value is 5");
            Assert.AreEqual(4, nums[2], "Expected value is 4");
        }

        [TestMethod]
        public void ShouldRemoveFourFromZeroIndexIfNineIsAddedToIndexFiveAndReturnCountFive()
        {
            RecentlyUsedList<int> nums = new RecentlyUsedList<int>(5);
            nums.AddItem(4);
            nums.AddItem(5);
            nums.AddItem(6);
            nums.AddItem(7);
            nums.AddItem(8);
            nums.AddItem(9);
            int count = nums.NoOfElements();
            Assert.AreEqual(5, count, "Expected value is 5");
            Assert.AreEqual(9, nums[0], "Expected value is 9");
            Assert.AreEqual(5, nums[4], "Expected value is 5");
        }

        [TestMethod]
        public void ShouldGiveFiveAtZeroIndexIfFiveIsAddedToIndexFourAndItIsAlreadyAtIndexOneAndReturnFour()
        {
            RecentlyUsedList<int> nums = new RecentlyUsedList<int>(5);
            nums.AddItem(4);
            nums.AddItem(5);
            nums.AddItem(6);
            nums.AddItem(7);
            nums.AddItem(5);
            int count = nums.NoOfElements();
            Assert.AreEqual(4, count, "Expected value is 4");
            Assert.AreEqual(5, nums[0], "Expected value is 5");
            Assert.AreEqual(4, nums[3], "Expected value is 4");
        }

        [TestMethod]
        public void ShouldInsertValuesAccordinglyIfStringsAreAddedAndReturnCountTwo()
        {
            RecentlyUsedList<string> nums = new RecentlyUsedList<string>(5);
            nums.AddItem("abc");
            nums.AddItem("xyz");
            int count = nums.NoOfElements();
            Assert.AreEqual(2, count, "Expected value is 2");
            Assert.AreEqual("xyz", nums[0], "Expected value is 5");
            Assert.AreEqual("abc", nums[1], "Expected value is 4");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowExecptionIfAccessValueAtIndexWhichIsEmpty()
        {
            RecentlyUsedList<string> nums = new RecentlyUsedList<string>(5);
            nums.AddItem("abc");
            nums.AddItem("xyz");
            var a = nums[2];
        }

        [TestMethod]
        public void ShouldAddClassObjectIntoList()
        {
            RecentlyUsedList<Employee> nums = new RecentlyUsedList<Employee>(5);
            Employee e1 = new Employee { Age = 24, Name = "Arjita" };
            nums.AddItem(e1);
            int count = nums.NoOfElements();
            Assert.AreEqual(1, count, "Expected value is 1");
            Assert.AreEqual(24, nums[0].Age, "Expected value is 24");
            Assert.AreEqual("Arjita", nums[0].Name, "Expected value is Arjita");
        }

        [TestMethod]
        public void ShouldAddClassObjectIntoListAccordingly()
        {
            RecentlyUsedList<Employee> nums = new RecentlyUsedList<Employee>(5);
            Employee e1 = new Employee { Age = 24, Name = "Arjita" };
            Employee e2 = new Employee { Age = 22, Name = "Garima" };
            nums.AddItem(e1);
            nums.AddItem(e2);
            int count = nums.NoOfElements();
            Assert.AreEqual(2, count, "Expected value is 2");
            Assert.AreEqual(24, nums[1].Age, "Expected value is 24");
            Assert.AreEqual("Arjita", nums[1].Name, "Expected value is Arjita");
            Assert.AreEqual(22, nums[0].Age, "Expected value is 22");
            Assert.AreEqual("Garima", nums[0].Name, "Expected value is Garima");
        }

        [TestMethod]
        public void ShouldAddClassObjectIntoListAccordinglyIfDuplicateObjectIsAdded()
        {
            RecentlyUsedList<Employee> nums = new RecentlyUsedList<Employee>(5);
            Employee e1 = new Employee { Age = 24, Name = "Arjita" };
            Employee e2 = new Employee { Age = 22, Name = "Garima" };
            //Employee e3 = new Employee { Age = 24, Name = "Arjita" };
            nums.AddItem(e1);
            nums.AddItem(e2);
            nums.AddItem(e1);
            int count = nums.NoOfElements();
            Assert.AreEqual(2, count, "Expected value is 2");
            Assert.AreEqual(24, nums[0].Age, "Expected value is 24");
            Assert.AreEqual("Arjita", nums[0].Name, "Expected value is Arjita");
            Assert.AreEqual(22, nums[1].Age, "Expected value is 22");
            Assert.AreEqual("Garima", nums[1].Name, "Expected value is Garima");
        }

        [TestMethod]
        public void ShouldAddClassObjectsIntoListAccordinglyIfOverFlowOccurs()
        {
            RecentlyUsedList<Employee> nums = new RecentlyUsedList<Employee>(5);
            Employee e1 = new Employee { Age = 24, Name = "Arjita" };
            Employee e2 = new Employee { Age = 22, Name = "Garima" };
            Employee e3 = new Employee { Age = 24, Name = "Mohit" };
            Employee e4 = new Employee { Age = 21, Name = "Arjita" };
            Employee e5 = new Employee { Age = 23, Name = "Garima" };
            Employee e6 = new Employee { Age = 21, Name = "Mohit" };
            nums.AddItem(e1);
            nums.AddItem(e2);
            nums.AddItem(e3);
            nums.AddItem(e4);
            nums.AddItem(e5);
            nums.AddItem(e6);
            int count = nums.NoOfElements();
            Assert.AreEqual(5, count, "Expected value is 5");
            Assert.AreEqual(21, nums[0].Age, "Expected value is 21");
            Assert.AreEqual("Mohit", nums[0].Name, "Expected value is Mohit");
            Assert.AreEqual(23, nums[1].Age, "Expected value is 23");
            Assert.AreEqual("Garima", nums[1].Name, "Expected value is Garima");
            Assert.AreEqual(21, nums[2].Age, "Expected value is 21");
            Assert.AreEqual("Arjita", nums[2].Name, "Expected value is Arjita");
            Assert.AreEqual(24, nums[3].Age, "Expected value is 24");
            Assert.AreEqual("Mohit", nums[3].Name, "Expected value is Mohit");
            Assert.AreEqual(22, nums[4].Age, "Expected value is 22");
            Assert.AreEqual("Garima", nums[4].Name, "Expected value is Garima");
        }
    }
}
