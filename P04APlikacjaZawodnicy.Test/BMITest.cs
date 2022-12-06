using Microsoft.VisualStudio.TestTools.UnitTesting;
using P02AplikacjaZawodnicy.Domain;
using System;

namespace P04APlikacjaZawodnicy.Test
{
    [TestClass]
    public class BMITest
    {
        [TestMethod]
        public void TestBMI1()
        {
            //Arrange
            Zawodnik klasaDoPrzetestowania = new Zawodnik();
            klasaDoPrzetestowania.Wzrost = 180;
            klasaDoPrzetestowania.Waga = 90;
            
            //Act
            double wynikRzeczywisty = klasaDoPrzetestowania.BMI;

            //Assert 
            string oczekiwanyWynik = "27,78";
            string actual = string.Format("{0:0.00}", wynikRzeczywisty);

            Assert.AreEqual(oczekiwanyWynik, actual);


        }

        [TestMethod]
        public void TestBMI2()
        {
            //Arrange
            Zawodnik klasaDoPrzetestowania = new Zawodnik();
            klasaDoPrzetestowania.Wzrost = 180;
            klasaDoPrzetestowania.Waga = 80;

            //Act
            double wynikRzeczywisty = klasaDoPrzetestowania.BMI;

            //Assert 
            string oczekiwanyWynik = "27,78";
            string actual = string.Format("{0:0.00}", wynikRzeczywisty);

            Assert.AreEqual(oczekiwanyWynik, actual);


        }
    }
}
