using NUnit.Framework;
using Op_CtrlFlow;
using System.Collections.Generic;
using System;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        // write unit test(s) for MyMethod here
        [TestCase(2, 1, true)]
        [TestCase(4, 1, true)]
        [TestCase(3, 2, false)]
        [TestCase(3, 4, false)]
        [TestCase(10, 10, false)]
        [TestCase(10, 2, true)]
        [TestCase(6, 2, true)]

        public void myMethodTest(int num1, int num2, bool expected)
        {
            var result = Exercises.MyMethod(num1, num2);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }
        // DONE
        [Test]
        public void WhenListIsEmpty_Average_ReturnsException()
        {
            var myList = new List<int>() {};
            Assert.That(() => Exercises.Average(myList), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Invalid data"));
        }

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }
        // DONE 
        [TestCase(-1)]
        public void TicketTypeTestInvalidData(int age)
        {
            Assert.That(() => Exercises.TicketType(age), Throws.TypeOf<Exception>().With.Message.Contains("Invalid input"));
        }

        [TestCase(75,"Pass with distinction")]
        [TestCase(100, "Pass with distinction")]
        [TestCase(91, "Pass with distinction")]
        [TestCase(60, "Pass with merit")]
        [TestCase(74, "Pass with merit")]
        [TestCase(69, "Pass with merit")]
        [TestCase(40, "Pass")]
        [TestCase(59, "Pass")]
        [TestCase(42, "Pass")]
        [TestCase(0, "Fail")]
        [TestCase(39, "Fail")]
        [TestCase(35, "Fail")]
        public void markedGradeTest(int mark, string expected)
        {
            var result = Exercises.Grade(mark);
            Assert.That(result, Is.EqualTo(expected));

        }
        // DONE 
        [TestCase(101)]
        [TestCase(402)]
        [TestCase(-1)]
        [TestCase(-112)]
        public void WhenMarkIsLessThanZero_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Exercises.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Allowed range 1-100"));
        }


        [TestCase(0, 200)]
        [TestCase(1, 100)]
        [TestCase(2, 50)]
        [TestCase(3, 50)]
        [TestCase(4, 20)]
        public void covidWeddingTest(int level, int expected)
        {
            var result = Exercises.GetScottishMaxWeddingNumbers(level);
            Assert.That(result, Is.EqualTo(expected));

        }

        // DONE 
        [TestCase(-1)]
        [TestCase(6)]
        public void CovidWeddingCodeOutsideBoundaries(int level) 
        {
            Assert.That(() => Exercises.GetScottishMaxWeddingNumbers(level),
                Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Invalid Input"));
        }

    }
}
