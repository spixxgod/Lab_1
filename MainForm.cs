using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Lab1_Denisov_Rodionov
{
    /// <summary>
    ///   Представляет основную форму приложения для управления информацией об отеле.
    /// </summary>
    public partial class InterfaceWindow : Form
    {
        #region Поля

        /// <summary>
        ///   Требуемая прибыль на одного посетителя.
        /// </summary>
        private const double RequiredRevenuePerVisitor = 1500;

      
        /// <summary>
        ///   Значение по умолчанию для названия отеля.
        /// </summary>
        private const string DefaultName = "Элеон";

        /// <summary>
        ///   Значение по умолчанию для количества номеров Comfort.
        /// </summary>
        private const int DefaultNumberOfComfort = 100;

        /// <summary>
        ///   Значение по умолчанию для количества номеров Luxe.
        /// </summary>
        private const int DefaultNumberOfLuxe = 50;

        /// <summary>
        ///   Значение по умолчанию для количества номеров Usual.
        /// </summary>
        private const int DefaultNumberOfUsual = 200;

        /// <summary>
        /// Значение по умолчанию для цены Comfort.
        /// </summary>
        private const double DefaultPriceForComfort = 1500;

        /// <summary>
        ///   Значение по умолчанию месячного дохода Luxe.
        /// </summary>
        private const double DefaultPriceForLuxe = 3000;

        /// <summary>
        ///   Значение по умолчанию для цены номеров Usual.
        /// </summary>
        private const double DefaultPriceForUsual = 1000;

        /// <summary>
        /// Значение по умолчанию адреса отеля.
        /// </summary>
        private const string DefaultAddress = "Красная 40";

        /// <summary>
        ///   Значение по умолчанию для годовой прибыли отеля
        /// </summary>
        private const double DefaultAnnualRevenue = 12*(1000 * 200 + 3000 * 50 + 1500 * 100);

        /// <summary>
        /// Объект класса Hotel, представляющий отель.
        /// </summary>
        private Hotel hotel = new Hotel(DefaultAddress, DefaultName, DefaultNumberOfLuxe, DefaultNumberOfComfort,
            DefaultNumberOfUsual, DefaultPriceForLuxe, DefaultAnnualRevenue, DefaultPriceForComfort,
            DefaultPriceForUsual);

        #endregion

        #region Конструктор

        /// <summary>
        ///   Конструктор класса InterfaceWindow.
        /// </summary>
        public InterfaceWindow()
        {
            InitializeComponent();
        }

        #endregion

        #region Обработчики событий

        /// <summary>
        ///   Обработчик события нажатия на кнопку, вызывает метод AnalyzeVisitors и
        ///   обрабатывает исключение InsufficientVisitorsException.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void ControlButton_Click(object sender, EventArgs e)
        {
            string result = hotel.AnalyzeVisitors(RequiredRevenuePerVisitor);
            MessageBox.Show(result, "Анализ посетителей", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        ///   Обработчик события нажатия на кнопку, вызывает искусственное исключение InvalidCastException
        ///   и отображает информацию об исключении в MessageBox.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void CallErrorButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Имитация неверного приведения типов при установке свойства NumberOfLuxe
                object invalidValue = "Luxe_err"; // Строка, которую нельзя преобразовать в int
                hotel.NumberOfLuxe = (int)invalidValue; // Это вызовет исключение InvalidCastException
            }
            catch (InvalidCastException ex)
            {
                // Создаем пользовательское исключение для хранения дополнительной информации
                CustomInvalidCastException customEx = new CustomInvalidCastException("Ошибка приведения типов", ex);
                customEx.AdditionalInfo = "Попытка присвоить строковое значение свойству NumberOfLuxe";
                customEx.OffendingValue = "Luxe_err";
                customEx.ExpectedType = typeof(int);

                // Строим строку сообщения для MessageBox
                string message = "Произошла ошибка приведения типов:\n" +
                                 "Сообщение: " + customEx.Message + "\n" +
                                 "Дополнительная информация: " + customEx.AdditionalInfo + "\n" +
                                 "Значение: " + customEx.OffendingValue + "\n" +
                                 "Тип: " + customEx.ExpectedType;

                // Отображаем MessageBox
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///   Обработчик события нажатия на кнопку ChangeButton_Click, обновляет информацию
        ///   об отеле на основе введенных данных в текстовые поля.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            string address = hotel.Address;
            string name = hotel.Name;
            int numberOfLuxe = hotel.NumberOfLuxe;
            int numberOfComfort = hotel.NumberOfComfort;
            int numberOfUsual = hotel.NumberOfUsual;
            double priceForLuxe = hotel.PriceforLuxe;
            double priceForComfort = hotel.PriceforComfort;
            double priceForUsual = hotel.PriceforUsual;
            double annualRevenue = 12*(priceForComfort*numberOfComfort+priceForLuxe*numberOfLuxe+priceForUsual*numberOfUsual);

            
            if (!string.IsNullOrEmpty(this.FounderTextBox.Text)) address = this.FounderTextBox.Text;
            if (!string.IsNullOrEmpty(this.StoreNameTextBox.Text)) name = this.StoreNameTextBox.Text;

            if (int.TryParse(this.NumderOfVisitorsTextBox.Text, out int luxe)) numberOfLuxe = luxe;
            if (int.TryParse(this.NumberOfProductsTextBox.Text, out int comfort)) numberOfComfort = comfort;
            if (int.TryParse(this.NumberOfPurcashesTextBox.Text, out int usual)) numberOfUsual = usual;

            
            if (!string.IsNullOrEmpty(this.MonthlyTurnoverTextBox.Text))
            {
                string textToParse = this.MonthlyTurnoverTextBox.Text.Replace(',', '.');
                if (double.TryParse(textToParse, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
                {
                    priceForLuxe = value;
                }
                else
                {
                    MessageBox.Show("Некорректный формат для цены за Luxe.");
                    return;
                }
            }

            if (!string.IsNullOrEmpty(this.YearTurnoverTextBox.Text))
            {
                MessageBox.Show("Нельзя изменять годовую прибыль вручную, она рассчитывается автоматически.");
                YearTurnoverTextBox.Text = ""; // Clear the text box
                return; // Exit the method early
            }

            if (!string.IsNullOrEmpty(this.ComfortPriceTextBox.Text))
            {
                string textToParse = this.ComfortPriceTextBox.Text.Replace(',', '.');
                if (double.TryParse(textToParse, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
                {
                    priceForComfort = value;
                }
                else
                {
                    MessageBox.Show("Некорректный формат для цены comfort.");
                    return;
                }
            }

            if (!string.IsNullOrEmpty(this.UsualPriceTextBox.Text))
            {
                string textToParse = this.UsualPriceTextBox.Text.Replace(',', '.');
                if (double.TryParse(textToParse, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
                {
                    priceForUsual = value;
                }
                else
                {
                    MessageBox.Show("Некорректный формат для цены usual.");
                    return;
                }
            }

            hotel.Address = address;
            hotel.Name = name;
            hotel.NumberOfLuxe = numberOfLuxe;
            hotel.NumberOfComfort = numberOfComfort;
            hotel.NumberOfUsual = numberOfUsual;
            hotel.PriceforLuxe = priceForLuxe;
            hotel.PriceforComfort = priceForComfort;
            hotel.PriceforUsual = priceForUsual;
            hotel.AnnualRevenue = annualRevenue;

            OutputField.Text = hotel.ToString();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку, закрывает форму MainForm.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Обработчик события загрузки формы InterfaceWindow, инициализирует текст MainInformation и OutputField.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            MainInformation.Text = "Лабораторная работа №1. Группа 23ВП1. Предмет. область: Отель Денисов и Родионов";
            OutputField.Text = hotel.ToString();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку, выводит количество номеров Luxe в шестнадцатеричном формате в label11.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void ConversionTo16Format_Click(object sender, EventArgs e)
        {
            label11.Text = hotel.DisplayOfRoomsHex();
        }

        /// <summary>
        ///  Обработчик события TextChanged для текстового поля FounderTextBox.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void FounderTextBox_TextChanged(object sender, EventArgs e)
        {
            //Заполнитель
        }

        /// <summary>
        /// Сбрасывает значения в исходное состояние
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            hotel = new Hotel(DefaultAddress, DefaultName, DefaultNumberOfLuxe, DefaultNumberOfComfort, DefaultNumberOfUsual, DefaultPriceForLuxe, DefaultAnnualRevenue, DefaultPriceForComfort, DefaultPriceForUsual);
            OutputField.Text = hotel.ToString();
            FounderTextBox.Text = "";
            StoreNameTextBox.Text = "";
            NumderOfVisitorsTextBox.Text = "";
            NumberOfProductsTextBox.Text = "";
            NumberOfPurcashesTextBox.Text = "";
            MonthlyTurnoverTextBox.Text = "";
            YearTurnoverTextBox.Text = "";
            ComfortPriceTextBox.Text = "";
            UsualPriceTextBox.Text = "";
            label11.Text = "";
        }

        #endregion
    }
}