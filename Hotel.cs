using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Lab1_Denisov_Rodionov
{
    #region Исключения

    /// <summary>
    ///   Представляет пользовательский тип исключения, который выбрасывается,
    ///   когда недостаточно посетителей для достижения необходимой ежемесячной прибыли.
    ///   Наследуется от класса <see cref="Exception" />.
    /// </summary>
    public class InsufficientVisitorsException : Exception
    {
        /// <summary>
        ///   Получает или задает количество посетителей, связанное с исключением.
        /// </summary>
        public int NumberOfVisitors { get; set; }

        public int NumberOfRooms { get; set; }

        public int NumberFreeRooms { get; set; }

        /// <summary>
        ///   Получает или задает ежемесячную прибыль, связанную с исключением.
        /// </summary>
        public double MonthlyRevenue { get; set; }

        /// <summary>
        ///   Получает или задает требуемую прибыль на одного посетителя, необходимую для предотвращения исключения.
        /// </summary>
        public double RequiredRevenuePerVisitor { get; set; }

        /// <summary>
        ///   Инициализирует новый экземпляр класса <see cref="InsufficientVisitorsException" /> с указанным сообщением об ошибке.
        /// </summary>
        /// <param name="message">Сообщение, описывающее причину возникновения исключения.</param>
        public InsufficientVisitorsException(string message) : base(message)
        {
        }

        /// <summary>
        ///   Инициализирует новый экземпляр класса <see cref="InsufficientVisitorsException" />
        ///   с указанным сообщением об ошибке и ссылкой на внутреннее исключение, которое является причиной этого исключения.
        /// </summary>
        /// <param name="message">Сообщение, описывающее причину возникновения исключения.</param>
        /// <param name="innerException">
        ///   Исключение, которое является причиной текущего исключения, или пустая ссылка,
        ///   если внутреннее исключение не задано.
        /// </param>
        public InsufficientVisitorsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    /// <summary>
    ///   Представляет пользовательский тип исключения, который выбрасывается, когда происходит недопустимое приведение типов.
    ///   Наследуется от класса <see cref="InvalidCastException" />.
    /// </summary>
    public class CustomInvalidCastException : InvalidCastException
    {
        /// <summary>
        ///   Получает или задает дополнительную информацию об исключении, например, контекст или подробности ошибки.
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        ///   Получает или задает значение, которое не удалось привести к ожидаемому типу.
        /// </summary>
        public string OffendingValue { get; set; }

        /// <summary>
        ///   Получает или задает ожидаемый тип, к которому пытались привести значение.
        /// </summary>
        public Type ExpectedType { get; set; }

        /// <summary>
        ///   Инициализирует новый экземпляр класса <see cref="CustomInvalidCastException" /> с указанным сообщением об ошибке.
        /// </summary>
        /// <param name="message">Сообщение, описывающее причину возникновения исключения.</param>
        public CustomInvalidCastException(string message) : base(message)
        {
        }

        /// <summary>
        ///   Инициализирует новый экземпляр класса <see cref="CustomInvalidCastException" />
        ///   с указанным сообщением об ошибке и ссылкой на внутреннее исключение, которое является причиной этого исключения.
        /// </summary>
        /// <param name="message">Сообщение, описывающее причину возникновения исключения.</param>
        /// <param name="innerException">
        ///   Исключение, которое является причиной текущего исключения, или пустая ссылка (Nothing в Visual Basic),
        ///   если внутреннее исключение не задано.
        /// </param>
        public CustomInvalidCastException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    #endregion Исключения

    #region Класс Hotel

    /// <summary>
    ///   Представляет отель с информацией о различных параметрах.
    /// </summary>
    internal class Hotel
    {
        #region Поля

        /// <summary>
        ///   Адрес отеля.
        /// </summary>
        private string _address;

        /// <summary>
        ///   Годовой доход.
        /// </summary>
        private double _annualRevenue;

        /// <summary>
        ///   Название Отеля.
        /// </summary>
        private string _name;

        /// <summary>
        ///   Число постояльцев в номерах Комфорт(за месяц).
        /// </summary>
        private int _numberOfComfort;

        /// <summary>
        ///   Число постояльцев в номерах Люкс(за месяц).
        /// </summary>
        private int _numberOfLuxe;

        /// <summary>
        ///   Число постояльцев в номерах Обычных(за месяц).
        /// </summary>
        private int _numberOfUsual;

        /// <summary>
        ///   Цена за комофрт.
        /// </summary>
        private double _priceForComfort;

        /// <summary>
        ///   Цена за Люкс.
        /// </summary>
        private double _priceForLuxe;

        /// <summary>
        ///   Цена за стандарт.
        /// </summary>
        private double _priceForUsual;

        #endregion Поля

        #region Константы

        /// <summary>
        ///   Константа для отображения значка ошибки в MessageBox.
        /// </summary>
        public const uint MB_ICONERROR = 0x00000010;

        /// <summary>
        ///   Константа для отображения кнопки "OK" в MessageBox.
        /// </summary>
        public const uint MB_OK = 0x00000000;

        #endregion Константы

        #region Статические поля и свойства

        /// <summary>
        ///   Статический счетчик количества созданных объектов <see cref="Hotel" />.
        /// </summary>
        private static int _objectCount;

        /// <summary>
        ///   Возвращает общее количество созданных объектов <see cref="Hotel" />.
        /// </summary>
        public static int ObjectCount => _objectCount;

        #endregion Статические поля и свойства

        #region Конструкторы

        /// <summary>
        ///   Инициализирует новый экземпляр класса <see cref="Hotel" /> с значениями по умолчанию.
        /// </summary>
        public Hotel()
        {
            _address = string.Empty;
            _name = string.Empty;
            _numberOfLuxe = 0;
            _numberOfComfort = 0;
            _numberOfUsual = 0;
            _priceForLuxe = 0;
            _priceForComfort = 0;
            _priceForUsual = 0;
            _annualRevenue = 0;

            _objectCount++;
        }

        /// <summary>
        ///   Инициализирует новый экземпляр класса <see cref="Hotel" /> с указанным именем.
        /// </summary>
        /// <param name="name">Название отеля.</param>
        public Hotel(string name)
        {
            _address = string.Empty;
            _name = name;
            _numberOfLuxe = 0;
            _numberOfComfort = 0;
            _numberOfUsual = 0;
            _priceForLuxe = 0;
            _priceForComfort = 0;
            _priceForUsual = 0;
            _annualRevenue = 0;

            _objectCount++;
        }

        /// <summary>
        ///   Инициализирует новый экземпляр класса <see cref="Hotel" /> с указанным адресом и именем.
        /// </summary>
        /// <param name="address">Адрес отеля.</param>
        /// <param name="name">Название отеля.</param>
        public Hotel(string address, string name)
        {
            _address = address;
            _name = name;
            _numberOfLuxe = 0;
            _numberOfComfort = 0;
            _numberOfUsual = 0;
            _priceForLuxe = 0;
            _priceForComfort = 0;
            _priceForUsual = 0;
            _annualRevenue = 0;

            _objectCount++;
        }

        /// <summary>
        ///   Инициализирует новый экземпляр класса <see cref="Hotel" /> со всеми параметрами.
        /// </summary>
        /// <param name="address">Адрес отеля.</param>
        /// <param name="name">Название отеля.</param>
        /// <param name="numberOfLuxe">Число постояльцев в номерах Люкс(за месяц).</param>
        /// <param name="numberOfComfort">Число постояльцев в номерах Комфорт(за месяц).</param>
        /// <param name="numberOfUsual">Число постояльцев в номерах Обычных(за месяц).</param>
        /// <param name="priceForLuxe">Цена за Люкс.</param>
        /// <param name="annualRevenue">Годовой доход.</param>
        /// <param name="priceForComfort">Цена за комофрт.</param>
        /// <param name="priceForUsual">Цена за стандарт.</param>
        public Hotel(string address, string name, int numberOfLuxe, int numberOfComfort, int numberOfUsual,
            double priceForLuxe, double annualRevenue, double priceForComfort, double priceForUsual)
        {
            _address = address;
            _name = name;
            _numberOfLuxe = numberOfLuxe;
            _numberOfComfort = numberOfComfort;
            _numberOfUsual = numberOfUsual;
            _priceForLuxe = priceForLuxe;
            _priceForComfort = priceForComfort;
            _priceForUsual = priceForUsual;
            _annualRevenue = annualRevenue;
            _objectCount++;
        }

        #endregion Конструкторы

        #region Свойства

        /// <summary>
        ///   Получает или задает адрес отеля.
        /// </summary>
        public string Address
        {
            get => _address;
            set => _address = value;
        }

        /// <summary>
        ///   Получает или задает годовой доход отеля.
        /// </summary>
        public double AnnualRevenue
        {
            get => _annualRevenue;
            set => _annualRevenue = value;
        }

        /// <summary>
        ///   Получает или задает название отеля.
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        /// <summary>
        ///   Получает или задает количество номеров Comfort.
        /// </summary>
        public int NumberOfComfort
        {
            get => _numberOfComfort;
            set => _numberOfComfort = value;
        }

        /// <summary>
        ///   Получает или задает количество номеров Luxe.
        /// </summary>
        public int NumberOfLuxe
        {
            get => _numberOfLuxe;
            set => _numberOfLuxe = value;
        }

        /// <summary>
        ///   Получает или задает количество номеров Usual.
        /// </summary>
        public int NumberOfUsual
        {
            get => _numberOfUsual;
            set => _numberOfUsual = value;
        }

        /// <summary>
        ///   Получает или задает цену за комфорт.
        /// </summary>
        public double PriceforComfort
        {
            get => _priceForComfort;
            set => _priceForComfort = value;
        }

        /// <summary>
        ///   Получает или задает цену проживания за ночь Luxe.
        /// </summary>
        public double PriceforLuxe
        {
            get => _priceForLuxe;
            set => _priceForLuxe = value;
        }

        /// <summary>
        ///   Получает или задает цену проживания за ночь Usual.
        /// </summary>
        public double PriceforUsual
        {
            get => _priceForUsual;
            set => _priceForUsual = value;
        }

        #endregion Свойства

        #region Методы

        /// <summary>
        /// Анализирует количество посетителей и обрабатывает исключение <see cref="InsufficientVisitorsException" />, если оно
        /// возникает.
        /// </summary>
        /// <param name="requiredRevenuePerVisitor">Требуемая прибыль на одного посетителя.</param>
        public string AnalyzeVisitors(double requiredRevenuePerVisitor)
        {
            try
            {
                if (CheckSufficientVisitors(requiredRevenuePerVisitor))
                {
                    return "Достаточно посетителей для достижения требуемого дохода.";
                }
            }
            catch (InsufficientVisitorsException ex)
            {
                return $"Ошибка: {ex.Message}\n" +
                       $"Общее количество номеров: {ex.NumberOfRooms}\n" +
                       $"Месячный доход: {ex.MonthlyRevenue:C}\n" +
                       $"Требуемый доход на номер: {ex.RequiredRevenuePerVisitor:C}";
            }

            return "Неизвестная ошибка.";
        }

        /// <summary>
        ///   Проверяет достаточность посетителей для требуемой прибыли.
        /// </summary>
        /// <param name="requiredRevenuePerVisitor">Требуемая прибыль на одного посетителя.</param>
        /// <returns>true, если достаточно посетителей, иначе выбрасывает исключение.</returns>
        /// <exception cref="InsufficientVisitorsException">Выбрасывается, если недостаточно посетителей.</exception>
        public bool CheckSufficientVisitors(double requiredRevenuePerVisitor)
        {
            if (_numberOfLuxe <= 0 && _numberOfComfort <= 0 && _numberOfUsual <= 0)
            {
                throw new InsufficientVisitorsException("Невозможно рассчитать доход, так как количество номеров равно нулю.");
            }

            double totalRevenue = _numberOfLuxe * _priceForLuxe + _numberOfComfort * _priceForComfort +
                                  _numberOfUsual * _priceForUsual;
            int totalRooms = _numberOfLuxe + _numberOfComfort + _numberOfUsual;
            double actualRevenuePerRoom = totalRevenue / totalRooms; // Adjusted to calculate revenue per room

            if (actualRevenuePerRoom < requiredRevenuePerVisitor)
            {
                InsufficientVisitorsException ex = new InsufficientVisitorsException(
                    $"Недостаточно посетителей для достижения требуемого дохода на номер. Требуется {requiredRevenuePerVisitor:C}, " +
                    $"фактический доход на номер {actualRevenuePerRoom:C}.");
                ex.NumberOfRooms = totalRooms; // Use the corrected variable
                ex.MonthlyRevenue = totalRevenue;
                ex.RequiredRevenuePerVisitor = requiredRevenuePerVisitor;
                throw ex;
            }

            return true;
        }

        /// <summary>
        ///   Выводит в консоль адрес отеля.
        /// </summary>
        public string DisplayAddress()
        {
            return $"Адрес: {_address}";
        }

        /// <summary>
        ///   Выводит в консоль годовой денежный оборот отеля.
        /// </summary>
        public string DisplayAnnualRevenue()
        {
            return $"Доход за год: {_annualRevenue:C}";
        }

        /// <summary>
        ///   Выводит название отеля.
        /// </summary>
        public string DisplayName()
        {
            return $"Название: {_name}";
        }

        /// <summary>
        ///   Выводит в консоль количество номеров Comfort.
        /// </summary>
        public string DisplayNumberOfComfort()
        {
            return $"Номера Comfort: {_numberOfComfort}";
        }

        /// <summary>
        ///   Выводит в консоль количество посетителей отеля.
        /// </summary>
        public string DisplayNumberOfLuxe()
        {
            return $"Номера Luxe: {_numberOfLuxe}";
        }

        /// <summary>
        ///   Выводит в консоль количество номеров Usual.
        /// </summary>
        public string DisplayNumberOfUsual()
        {
            return $"Номера Usual: {_numberOfUsual}";
        }

        /// <summary>
        ///   Возвращает сумму всех номеров отеля (Luxe, Comfort, Usual) в шестнадцатеричном представлении.
        /// </summary>
        /// <returns>Строка, представляющая сумму количества номеров в шестнадцатеричном формате.</returns>
        public string DisplayOfRoomsHex()
        {
            int totalRooms = _numberOfLuxe + _numberOfComfort + _numberOfUsual;
            return totalRooms.ToString("X");
      
        }

        /// <summary>
        ///   Выводит в консоль цену за ночь Comfort.
        /// </summary>
        public string DisplayPriceForComfort()
        {
            return $"Цена Comfort: {_priceForComfort:C}";
        }

        /// <summary>
        ///   Выводит в консоль цену за ночь Luxe.
        /// </summary>
        public string DisplayPriceForLuxe()
        {
            return $"Цена Luxe: {_priceForLuxe:C}";
        }

        /// <summary>
        ///   Выводит в консоль цену за ночь Usual.
        /// </summary>
        public string DisplayPriceForUsual()
        {
            return $"Цена Usual: {_priceForUsual:C}";
        }

        /// <summary>
        ///   Переопределяет метод <see cref="object.ToString" /> для возврата строкового представления объекта <see cref="Hotel" />,
        ///   включающего значения всех его полей.
        /// </summary>
        /// <returns>Строка, представляющая объект <see cref="Hotel" />.</returns>
        public override string ToString()
        {
            return $"Адрес: {_address}\n" +
                   $"Название: {_name}\n" +
                   $"Номера Luxe: {_numberOfLuxe}\n" +
                   $"Номера Comfort: {_numberOfComfort}\n" +
                   $"Номера Usual: {_numberOfUsual}\n" +
                   $"Цена Luxe: {_priceForLuxe:C}\n" + // Use currency format
                   $"Цена Comfort: {_priceForComfort:C}\n" +
                   $"Цена Usual: {_priceForUsual:C}\n" +
                   $"Годовой доход: {_annualRevenue:C}"; // Use currency format
        }

        #endregion Методы

        #region DllImports

        /// <summary>
        ///   Импортирует функцию MessageBox из user32.dll для отображения сообщений в Windows.
        /// </summary>
        /// <param name="hWnd">Дескриптор родительского окна.</param>
        /// <param name="text">Текст сообщения.</param>
        /// <param name="caption">Заголовок окна сообщения.</param>
        /// <param name="type">Тип сообщения (комбинация констант MB_OK, MB_ICONERROR и др.).</param>
        /// <returns>Результат работы функции MessageBox (например, ID нажатой кнопки).</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        #endregion DllImports
    }

    #endregion Класс Hotel
}