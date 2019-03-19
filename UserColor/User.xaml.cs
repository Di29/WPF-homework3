using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace UserColor
{
    public partial class User : Window
    {
        string userPath = Environment.CurrentDirectory + @"\Users";
        string userName;
        static string message = "User doesn't found! Do you want to register?";
        static string title = "Sorry";
        static MessageBoxButton button = MessageBoxButton.YesNo;
        
        public User()
        {
            InitializeComponent();
        }
        
        private void TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            userName = @"\" + userNameText.Text + ".json";
            if (e.Key == Key.Enter)
            {
                if (!File.Exists(userPath + userName))
                {
                    if(MessageBox.Show(message, title, button) == MessageBoxResult.Yes)
                    {
                        Register register = new Register();
                        Application.Current.MainWindow = register;
                        Close();
                        register.Show();
                    }   
                }
                else
                {
                    MainWindow main = new MainWindow();
                    TextBlock name = (TextBlock)main.FindName("you");
                    MainWindow window = (MainWindow)main.FindName("main");
                    
                    string json = File.ReadAllText(userPath + userName, Encoding.UTF8);
                    JsonSerializer serializer = new JsonSerializer();
                    Somebody somebody = JsonConvert.DeserializeObject<Somebody>(json);

                    name.Text = somebody.Name;
                    var bc = new BrushConverter();
                    name.Foreground = (Brush)bc.ConvertFrom(somebody.ColorOfName);

                    var bc2 = new BrushConverter();
                    window.Background = (Brush)bc2.ConvertFrom(somebody.Background);

                    Application.Current.MainWindow = main;
                    Close();
                    main.Show();
                    
                }
            }
        }

        private void RegisterClick(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            Application.Current.MainWindow = register;
            Close();
            register.Show();
        }
    }
}
