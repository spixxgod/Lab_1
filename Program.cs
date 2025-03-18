// Program.cs
using System;
using System.Windows.Forms;

namespace Lab1_Denisov_Rodionov
{
    /// <summary>
    /// Содержит главную точку входа для приложения.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///  Главная точка входа для приложения.
        /// </summary>
        [STAThread] // Указывает, что метод должен выполняться в однопоточном подразделении (STA)
        static void Main()
        {
            Application.EnableVisualStyles(); // Включает визуальные стили для приложения (если поддерживается операционной системой)
            Application.SetCompatibleTextRenderingDefault(false); // Устанавливает механизм отрисовки текста по умолчанию для приложения.
            Application.Run(new InterfaceWindow()); // Запускает приложение, используя InterfaceWindow (главную форму) в качестве основного окна.
        }
    }
}