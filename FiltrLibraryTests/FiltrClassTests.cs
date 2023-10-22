using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FiltrLibrary;

namespace FiltrLibraryTests
{
    [TestClass]
    public class FiltrClassTests
    {
       
            /// <summary>
            /// Простая проерка
            /// </summary>
            [TestMethod]

            public void Censore_Prostoe_Star3()
            {

                // Arrange
                string str = "редиска поле";
                string expected = "*** поле";
                //Act
                string action = FiltrClass.Censore(str);
                //Assert
                Assert.AreEqual(expected, action);

            }
            /// <summary>
            /// Пустое поле
            /// </summary>
            [TestMethod]
            public void Censore_Pustoe_Star0()
            {

                // Arrange
                string str = "";
                string expected = "";
                //Act
                string action = FiltrClass.Censore(str);
                //Assert
                Assert.AreEqual(expected, action);

            }
            /// <summary>
            /// Проверка на регистр
            /// </summary>
            [TestMethod]
            public void Censore_Registr_Star3()
            {

                // Arrange
                string str = "редиска КОЛЬЦО";
                string expected = "*** кольцо";
                //Act
                string action = FiltrClass.Censore(str);
                //Assert
                Assert.AreEqual(expected, action);

            }
            /// <summary>
            /// Сложная проверка
            /// </summary>
            [TestMethod]
            public void Censore_Slognoe_Star15()
            {

                // Arrange
                string str = "редиска редиска редиска редиска редиска";
                string expected = "*** *** *** *** ***";
                //Act
                string action = FiltrClass.Censore(str);
                //Assert
                Assert.AreEqual(expected, action);

            }
        }
}
