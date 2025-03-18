// ExceptionTests.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab1_Denisov_Rodionov
{ 
    /// <summary>
    /// Класс тестов для проверки функциональности класса CustomInvalidCastException.
    /// </summary>
    [TestClass] // Атрибут, указывающий, что это класс, содержащий тестовые методы.
    public class ExceptionTests
    {
        /// <summary>
        /// Тест проверяет, что свойства класса CustomInvalidCastException устанавливаются и возвращаются корректно.
        /// </summary>
        [TestMethod] // Атрибут, указывающий, что это тестовый метод.
        public void CustomInvalidCastException_PropertiesSetCorrectly()
        {
            // Arrange - Подготовка данных для теста.
            string expectedMessage = "Test message"; // Определяем ожидаемое сообщение об ошибке.
            string expectedAdditionalInfo = "Test info"; // Определяем ожидаемую дополнительную информацию.
            string expectedOffendingValue = "123"; // Определяем ожидаемое значение, которое не удалось привести.
            Type expectedType = typeof(int); // Определяем ожидаемый тип.

            // Создаем экземпляр класса CustomInvalidCastException с ожидаемым сообщением.
            CustomInvalidCastException ex = new CustomInvalidCastException(expectedMessage)
            {
                AdditionalInfo = expectedAdditionalInfo, // Устанавливаем свойство AdditionalInfo.
                OffendingValue = expectedOffendingValue, // Устанавливаем свойство OffendingValue.
                ExpectedType = expectedType // Устанавливаем свойство ExpectedType.
            };

            // Assert - Проверка результата.
            Assert.AreEqual(expectedMessage, ex.Message); // Проверяем, что свойство Message равно ожидаемому значению.
            Assert.AreEqual(expectedAdditionalInfo, ex.AdditionalInfo); // Проверяем, что свойство AdditionalInfo равно ожидаемому значению.
            Assert.AreEqual(expectedOffendingValue, ex.OffendingValue); // Проверяем, что свойство OffendingValue равно ожидаемому значению.
            Assert.AreEqual(expectedType, ex.ExpectedType); // Проверяем, что свойство ExpectedType равно ожидаемому значению.
        }
    }
}