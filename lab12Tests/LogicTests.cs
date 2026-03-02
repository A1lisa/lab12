using Microsoft.Testing.Platform.Extensions.Messages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class LogicTests
    {

        //проверка правильно подсчета количетсва
        [TestMethod()]
        public void CountGradeTest()
        {
            int[] grades = new int[] { 5, 4, 3, 2, 2, 5 };

            int[] result = Logic.Grade(grades);

            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(1, result[2]);
            Assert.AreEqual(2, result[3]);
        }

        //проыерка пустого массива
        [TestMethod()]
        public void pustGrades()
        {
            int[] grades = new int[0];
            int[] result = Logic.Grade(grades);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(0, result[1]);
            Assert.AreEqual(0, result[2]);
            Assert.AreEqual(0, result[3]);

        }

        [TestMethod()]
        public void Only2Test()
        {
            int[] grades = new int[] {2, 2, 2};
            int[] result = Logic.Grade(grades);
            Assert.AreEqual(3, result[0]);
            Assert.AreEqual(0, result[1]);
            Assert.AreEqual(0, result[2]);
            Assert.AreEqual(0, result[3]);

        }



    }
}