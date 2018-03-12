using System;
using System.IO;
using System.Windows;
using System.Text;

namespace AnkiNotes
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string front = Text1.Text;
            string back = Text2.Text;
            string path = Directory.GetCurrentDirectory() + "\\export.txt";
            //string path = @"C:\Users\Pawel\Desktop\export.txt";
            StringBuilder sb = new StringBuilder("");
            sb.Append(front).Append(";").Append(back);
            byte[] bytes = Encoding.GetEncoding(1250).GetBytes(sb.ToString());
            File.AppendAllText(path, Encoding.GetEncoding(1250).GetString(bytes) + Environment.NewLine);
            Text1.Text = "";
            Text2.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
