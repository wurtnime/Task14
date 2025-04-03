using System;
using System.Windows;
using System.Windows.Controls;

// Арчо Моррис, вернись в семью, прошу!!!!!!!!!!!!!!

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 1; i <= 30; i++)
            {
                TaskComboBox.Items.Add($"Задание {i}");
            }

            TaskComboBox.SelectedIndex = 0;
        }

        private void SolveButton_Click(object sender, RoutedEventArgs e)
        { 
            if (TaskComboBox.SelectedIndex == -1) return;

            int taskNumber = TaskComboBox.SelectedIndex + 1;

            string result = ExecuteTask(taskNumber);

            ResultTextBox.Text = result;
        }

        private string ExecuteTask(int taskNumber)
        {
            switch (taskNumber)
            {
                case 1:
                    return Class1.Task1();
                case 2:
                    return Class2.Task2();
                case 3:
                    return Class3.Task3();
                case 4:
                    return Class4.Task4();
                case 5:
                    return Class5.Task5();
                case 6:
                    return Class6.Task6();
                case 7:
                    return Class7.Task7();
                case 8:
                    return Class8.Task8();
                case 9:
                    return Class9.Task9();
                case 10:
                    return Class10.Task10();
                case 11:
                    return Class11.Task11();
                case 12:
                    return Class12.Task12();
                case 13:
                    return Class13.Task13();
                case 14:
                    return Class14.Task14();
                case 15:
                    return Class15.Task15();
                case 16:
                    return Class16.Task16();
                case 17:
                    return Class17.Task17();
                case 18:
                    return Class18.Task18();
                case 19:
                    return Class19.Task19();
                case 20:
                    return Class20.Task20();
                case 21:
                    return Class21.Task21();
                case 22:
                    return Class22.Task22();
                case 23:
                    return Class23.Task23();
                case 24:
                    return Class24.Task24();
                case 25:
                    return Class25.Task25();
                case 26:
                    return Class26.Task26();
                case 27:
                    return Class27.Task27();
                case 28:
                    return Class28.Task28();
                case 29:
                    return Class29.Task29();
                case 30:
                    return Class30.Task30();
                default:
                    return "Задание не реализовано.";
            }
        }
    }
}