// HotelTests.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab1_Denisov_Rodionov
{
    /// <summary>
    /// Класс тестов для проверки функциональности класса Hotel.
    /// </summary>
    [TestClass] // Атрибут, указывающий, что это класс, содержащий тестовые методы.
    public class HotelTests
    {
        /// <summary>
        /// Тест проверяет, что метод DisplayName возвращает правильное название отеля.
        /// </summary>
        [TestMethod] // Атрибут, указывающий, что это тестовый метод.
        public void DisplayName_ReturnsCorrectName()
        {
            // Arrange - Подготовка данных для теста.
            Hotel hotel = new Hotel("", "Test Hotel"); // Создаем экземпляр класса Hotel с названием "Test Hotel".

            // Act - Выполнение тестируемого кода.
            string name = hotel.DisplayName(); // Вызываем метод DisplayName и сохраняем результат в переменную name.

            // Assert - Проверка результата.
            Assert.AreEqual("Название: Test Hotel", name); // Проверяем, что возвращенное значение name равно ожидаемому значению.
        }

        /// <summary>
        /// Тест проверяет, что метод CheckSufficientVisitors выбрасывает исключение InsufficientVisitorsException,
        /// когда недостаточно посетителей для достижения требуемого дохода.
        /// </summary>
        [TestMethod] // Атрибут, указывающий, что это тестовый метод.
        [ExpectedException(typeof(InsufficientVisitorsException))] // Указывает, что метод должен выбросить исключение InsufficientVisitorsException.
        public void CheckSufficientVisitors_ThrowsException_WhenNotEnoughVisitors()
        {
            // Arrange - Подготовка данных для теста.
            Hotel hotel = new Hotel("", "Test Hotel"); // Создаем экземпляр класса Hotel с названием "Test Hotel".
            hotel.NumberOfLuxe = 10; // Устанавливаем количество номеров Luxe в 10.
            hotel.PriceforLuxe = 50; // Устанавливаем цену за номер Luxe в 50.
            double requiredRevenuePerVisitor = 100; // Устанавливаем требуемый доход на одного посетителя в 100.

            // Act - Выполнение тестируемого кода.
            hotel.CheckSufficientVisitors(requiredRevenuePerVisitor); // Вызываем метод CheckSufficientVisitors.
        }

        /// <summary>
        /// Тест проверяет, что метод CheckSufficientVisitors возвращает true,
        /// когда достаточно посетителей для достижения требуемого дохода.
        /// </summary>
        [TestMethod] // Атрибут, указывающий, что это тестовый метод.
        public void CheckSufficientVisitors_ReturnsTrue_WhenEnoughVisitors()
        {
            // Arrange - Подготовка данных для теста.
            Hotel hotel = new Hotel("", "Test Hotel"); // Создаем экземпляр класса Hotel с названием "Test Hotel".
            hotel.NumberOfLuxe = 100; // Устанавливаем количество номеров Luxe в 100.
            hotel.PriceforLuxe = 100; // Устанавливаем цену за номер Luxe в 100.
            double requiredRevenuePerVisitor = 1; // Устанавливаем требуемый доход на одного посетителя в 1.

            // Act - Выполнение тестируемого кода.
            bool result = hotel.CheckSufficientVisitors(requiredRevenuePerVisitor); // Вызываем метод CheckSufficientVisitors.

            // Assert - Проверка результата.
            Assert.IsTrue(result); // Проверяем, что возвращенное значение result равно true.
        }
    }
}