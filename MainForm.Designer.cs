using OOP_Lab1_Shalygin_Korsunov.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1_Denisov_Rodionov
{
    partial class InterfaceWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CountOfProducts = new Label();
            CountOfPurcashes = new Label();
            MonthlyTurnover = new Label();
            YearTurnover = new Label();
            FounderTextBox = new TextBox();
            StoreNameTextBox = new TextBox();
            NumderOfVisitorsTextBox = new TextBox();
            NumberOfProductsTextBox = new TextBox();
            NumberOfPurcashesTextBox = new TextBox();
            MonthlyTurnoverTextBox = new TextBox();
            YearTurnoverTextBox = new TextBox();
            ChangeInformation = new Label();
            label11 = new Label();
            MainInformation = new Label();
            CallErrorButton = new Button();
            ControlButton = new Button();
            ConversionTo16Format = new Button();
            ExitButton = new Button();
            ChangeButton = new Button();
            label1 = new Label();
            label2 = new Label();
            ComfortPriceTextBox = new TextBox();
            UsualPriceTextBox = new TextBox();
            ResetButton = new Button();
            SuspendLayout();
            //
            // OutputField
            //
            //outputfield.backcolor = color.linen;
            //outputfield.borderstyle = borderstyle.fixedsingle;
            //outputfield.flatstyle = flatstyle.flat;
            //outputfield.font = new font("microsoft yahei", 12f, fontstyle.regular, graphicsunit.point);
            //outputfield.location = new point(6, 112);
            //outputfield.name = "outputfield";
            //outputfield.size = new size(679, 438);
            //outputfield.tabindex = 0;
            //
            // StoreInformation
            //
            //StoreInformation.AutoSize = true;
            //StoreInformation.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            //StoreInformation.Location = new Point(12, 82);
            //StoreInformation.Name = "StoreInformation";
            //StoreInformation.Size = new Size(307, 24);
            //StoreInformation.TabIndex = 1;
            //StoreInformation.Text = "Информация о начальном отеле:";
            //
            // Founder
            //
            //Founder.AutoSize = true;
            //Founder.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            //Founder.Location = new Point(687, 137);
            //Founder.Name = "Founder";
            //Founder.Size = new Size(110, 19);
            //Founder.TabIndex = 2;
            //Founder.Text = "Адрес отеля:";
            //
            // NameOfStore
            //
            //NameOfStore.AutoSize = true;
            //NameOfStore.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            //NameOfStore.Location = new Point(687, 185);
            //NameOfStore.Name = "NameOfStore";
            //NameOfStore.Size = new Size(138, 19);
            //NameOfStore.TabIndex = 3;
            //NameOfStore.Text = "Название отеля:";
            //
            // CountOfVisitors
            //
            //CountOfVisitors.AutoSize = true;
            //CountOfVisitors.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            //CountOfVisitors.Location = new Point(687, 236);
            //CountOfVisitors.Name = "CountOfVisitors";
            //CountOfVisitors.Size = new Size(168, 19);
            //CountOfVisitors.TabIndex = 4;
            //CountOfVisitors.Text = "Число постояльцев Luxe:";
            //
            // CountOfProducts
            //
            CountOfProducts.AutoSize = true;
            CountOfProducts.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CountOfProducts.Location = new Point(687, 286);
            CountOfProducts.Name = "CountOfProducts";
            CountOfProducts.Size = new Size(180, 19);
            CountOfProducts.TabIndex = 5;
            CountOfProducts.Text = "Число постояльцев Comfort:";
            //
            // CountOfPurcashes
            //
            CountOfPurcashes.AutoSize = true;
            CountOfPurcashes.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CountOfPurcashes.Location = new Point(687, 337);
            CountOfPurcashes.Name = "CountOfPurcashes";
            CountOfPurcashes.Size = new Size(269, 19);
            CountOfPurcashes.TabIndex = 6;
            CountOfPurcashes.Text = "Число постояльцев Usual";
            //
            // MonthlyTurnover
            //
            MonthlyTurnover.AutoSize = true;
            MonthlyTurnover.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MonthlyTurnover.Location = new Point(687, 391);
            MonthlyTurnover.Name = "MonthlyTurnover";
            MonthlyTurnover.Size = new Size(223, 19);
            MonthlyTurnover.TabIndex = 7;
            MonthlyTurnover.Text = "Цена проживания Luxe:";
            //
            // YearTurnover
            //
            YearTurnover.AutoSize = true;
            YearTurnover.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            YearTurnover.Location = new Point(687, 557);
            YearTurnover.Name = "YearTurnover";
            YearTurnover.Size = new Size(157, 19);
            YearTurnover.TabIndex = 8;
            YearTurnover.Text = "Доход отеля в год:";
            //
            // FounderTextBox
            //
            FounderTextBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FounderTextBox.Location = new Point(968, 133);
            FounderTextBox.Name = "FounderTextBox";
            FounderTextBox.Size = new Size(137, 27);
            FounderTextBox.TabIndex = 9;
            FounderTextBox.TextChanged += FounderTextBox_TextChanged;
            //
            // StoreNameTextBox
            //
            StoreNameTextBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            StoreNameTextBox.Location = new Point(968, 177);
            StoreNameTextBox.Name = "StoreNameTextBox";
            StoreNameTextBox.Size = new Size(137, 27);
            StoreNameTextBox.TabIndex = 10;
            //
            // NumderOfVisitorsTextBox
            //
            NumderOfVisitorsTextBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NumderOfVisitorsTextBox.Location = new Point(968, 228);
            NumderOfVisitorsTextBox.Name = "NumderOfVisitorsTextBox";
            NumderOfVisitorsTextBox.Size = new Size(137, 27);
            NumderOfVisitorsTextBox.TabIndex = 11;
            //
            // NumberOfProductsTextBox
            //
            NumberOfProductsTextBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NumberOfProductsTextBox.Location = new Point(968, 282);
            NumberOfProductsTextBox.Name = "NumberOfProductsTextBox";
            NumberOfProductsTextBox.Size = new Size(137, 27);
            NumberOfProductsTextBox.TabIndex = 12;
            //
            // NumberOfPurcashesTextBox
            //
            NumberOfPurcashesTextBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NumberOfPurcashesTextBox.Location = new Point(968, 329);
            NumberOfPurcashesTextBox.Name = "NumberOfPurcashesTextBox";
            NumberOfPurcashesTextBox.Size = new Size(137, 27);
            NumberOfPurcashesTextBox.TabIndex = 13;
            //
            // MonthlyTurnoverTextBox
            //
            MonthlyTurnoverTextBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MonthlyTurnoverTextBox.Location = new Point(968, 383);
            MonthlyTurnoverTextBox.Name = "MonthlyTurnoverTextBox";
            MonthlyTurnoverTextBox.Size = new Size(137, 27);
            MonthlyTurnoverTextBox.TabIndex = 14;
            //
            // YearTurnoverTextBox
            //
            YearTurnoverTextBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            YearTurnoverTextBox.Location = new Point(968, 553);
            YearTurnoverTextBox.Name = "YearTurnoverTextBox";
            YearTurnoverTextBox.Size = new Size(137, 27);
            YearTurnoverTextBox.TabIndex = 15;
            //
            // ChangeInformation
            //
            ChangeInformation.AutoSize = true;
            ChangeInformation.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ChangeInformation.Location = new Point(703, 82);
            ChangeInformation.Name = "ChangeInformation";
            ChangeInformation.Size = new Size(260, 19);
            ChangeInformation.TabIndex = 18;
            ChangeInformation.Text = "Изменение информации отеля:";
            //
            // label11
            //
            label11.BackColor = Color.SeaShell;
            label11.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(248, 553);
            label11.Name = "label11";
            label11.Size = new Size(208, 62);
            label11.TabIndex = 20;
            //
            // MainInformation
            //
            MainInformation.BackColor = Color.Moccasin;
            MainInformation.BorderStyle = BorderStyle.Fixed3D;
            MainInformation.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainInformation.Location = new Point(417, 9);
            MainInformation.Name = "MainInformation";
            MainInformation.Size = new Size(418, 58);
            MainInformation.TabIndex = 21;
            //
            // CallErrorButton
            //
            CallErrorButton.BackColor = Color.MediumTurquoise;
            CallErrorButton.Font = new Font("Microsoft YaHei", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            CallErrorButton.Location = new Point(2, 9);
            CallErrorButton.Name = "CallErrorButton";
            CallErrorButton.Size = new Size(153, 58);
            CallErrorButton.TabIndex = 24;
            CallErrorButton.Text = "Вызывать исключение";
            CallErrorButton.UseVisualStyleBackColor = false;
            CallErrorButton.Click += CallErrorButton_Click;
            //
            // ControlButton
            //
            ControlButton.BackColor = Color.MediumTurquoise;
            ControlButton.Font = new Font("Microsoft YaHei", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            ControlButton.Location = new Point(170, 9);
            ControlButton.Name = "ControlButton";
            ControlButton.Size = new Size(153, 58);
            ControlButton.TabIndex = 25;
            ControlButton.Text = "Проверить посетителей";
            ControlButton.UseVisualStyleBackColor = false;
            ControlButton.Click += ControlButton_Click;
            //
            // ConversionTo16Format
            //
            ConversionTo16Format.BackColor = Color.MediumTurquoise;
            ConversionTo16Format.Font = new Font("Microsoft YaHei", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            ConversionTo16Format.Location = new Point(6, 557);
            ConversionTo16Format.Name = "ConversionTo16Format";
            ConversionTo16Format.Size = new Size(200, 58);
            ConversionTo16Format.TabIndex = 26;
            ConversionTo16Format.Text = "Число номеров в 16-ом формате";
            ConversionTo16Format.UseVisualStyleBackColor = false;
            ConversionTo16Format.Click += ConversionTo16Format_Click;
            //
            // ExitButton
            //
            ExitButton.BackColor = Color.LightSalmon;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.Location = new Point(968, 586);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(122, 45);
            ExitButton.TabIndex = 27;
            ExitButton.Text = "Выйти";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            //
            // ChangeButton
            //
            ChangeButton.BackColor = Color.MediumTurquoise;
            ChangeButton.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ChangeButton.Location = new Point(713, 582);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(154, 56);
            ChangeButton.TabIndex = 28;
            ChangeButton.Text = "Внести изменения";
            ChangeButton.UseVisualStyleBackColor = false;
            ChangeButton.Click += ChangeButton_Click;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(687, 445);
            label1.Name = "label1";
            label1.Size = new Size(234, 19);
            label1.TabIndex = 29;
            label1.Text = "Цена проживания Comfort:";
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(687, 499);
            label2.Name = "label2";
            label2.Size = new Size(220, 19);
            label2.TabIndex = 30;
            label2.Text = "Цена проживания Usual:";
            //
            // ComfortPriceTextBox
            //
            ComfortPriceTextBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ComfortPriceTextBox.Location = new Point(968, 437);
            ComfortPriceTextBox.Name = "ComfortPriceTextBox";
            ComfortPriceTextBox.Size = new Size(137, 27);
            ComfortPriceTextBox.TabIndex = 31;
            //
            // UsualPriceTextBox
            //
            UsualPriceTextBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UsualPriceTextBox.Location = new Point(968, 495);
            UsualPriceTextBox.Name = "UsualPriceTextBox";
            UsualPriceTextBox.Size = new Size(137, 27);
            UsualPriceTextBox.TabIndex = 32;
            //
            // ResetButton
            //
            ResetButton.BackColor = Color.LightSalmon;
            ResetButton.FlatStyle = FlatStyle.Flat;
            ResetButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ResetButton.Location = new Point(841, 9);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(122, 45);
            ResetButton.TabIndex = 33;
            ResetButton.Text = "Сброс";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            //
            // InterfaceWindow
            //
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1121, 643);
            Controls.Add(ResetButton);
            Controls.Add(UsualPriceTextBox);
            Controls.Add(ComfortPriceTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ChangeButton);
            Controls.Add(ExitButton);
            Controls.Add(ConversionTo16Format);
            Controls.Add(ControlButton);
            Controls.Add(CallErrorButton);
            Controls.Add(MainInformation);
            Controls.Add(label11);
            Controls.Add(ChangeInformation);
            Controls.Add(YearTurnoverTextBox);
            Controls.Add(MonthlyTurnoverTextBox);
            Controls.Add(NumberOfPurcashesTextBox);
            Controls.Add(NumberOfProductsTextBox);
            Controls.Add(NumderOfVisitorsTextBox);
            Controls.Add(StoreNameTextBox);
            Controls.Add(FounderTextBox);
            Controls.Add(YearTurnover);
            Controls.Add(MonthlyTurnover);
            Controls.Add(CountOfPurcashes);
            Controls.Add(CountOfProducts);
           // Controls.Add(CountOfVisitors);
            //Controls.Add(NameOfStore);
            //Controls.Add(Founder);
            //Controls.Add(StoreInformation);
            //Controls.Add(OutputField);
            Name = "InterfaceWindow";
            Text = "Отель";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OutputField=new Label();
        private Label StoreInformation = new Label();
        private Label Founder = new Label();
        private Label NameOfStore = new Label();
        private Label CountOfVisitors = new Label();
        private Label CountOfProducts = new Label();
        private Label CountOfPurcashes = new Label();
        private Label MonthlyTurnover;
        private Label YearTurnover;
        private TextBox FounderTextBox;
        private TextBox StoreNameTextBox;
        private TextBox NumderOfVisitorsTextBox;
        private TextBox NumberOfProductsTextBox;
        private TextBox NumberOfPurcashesTextBox;
        private TextBox MonthlyTurnoverTextBox;
        private TextBox YearTurnoverTextBox;
        private Label ChangeInformation;
        private Label label11;
        private Label MainInformation;
        private Button CallErrorButton;
        private Button ControlButton;
        private Button ConversionTo16Format;
        private Button ExitButton;
        private Button ChangeButton;
        private Label label1;
        private Label label2;
        private TextBox ComfortPriceTextBox;
        private TextBox UsualPriceTextBox;
        private Button ResetButton;
    }
}