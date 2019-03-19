using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Newtonsoft.Json;

namespace UserColor
{
    public partial class Register : Window
    {
        string path = Environment.CurrentDirectory + @"\Users";
        Somebody somebody;
        
        public Register()
        {
            InitializeComponent();
        }
        
        private void ColorPickerSelectedColorChanged(object sender, EventArgs e)
        {
            color1.Text = colorPicker.SelectedColorText;
            var bc = new BrushConverter();
            window.Background = (Brush)bc.ConvertFrom(colorPicker.SelectedColor.ToString());
        }

        private void ColorPickerSelectedColorChanged2(object sender, EventArgs e)
        {
            color2.Text = colorPicker2.SelectedColorText;
            var bc = new BrushConverter();
            yourName.Foreground = (Brush)bc.ConvertFrom(colorPicker2.SelectedColor.ToString());
        }

        private void RegisterClick(object sender, RoutedEventArgs e)
        {
            RegisterUser();
        }

        private void YourNameKeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                RegisterUser();
            }
        }

        private void RegisterUser()
        {
            string filePath = path + @"\" + yourName.Text + ".json";

            if (color1.Text != colorPicker.SelectedColorText || color2.Text != colorPicker2.SelectedColorText || color1.Text == "" || color2.Text == "")
            {
                MessageBox.Show("Please, select colors!");
            }
            else
            {
                if (yourName.Text == null || yourName.Text == " " || yourName.Text == "")
                {
                    MessageBox.Show("Please, write your name!");
                }
                else
                {
                    if (File.Exists(filePath))
                    {
                        MessageBox.Show("Sorry, this name already exists!");
                    }
                    else
                    {
                        somebody = new Somebody
                        {
                            Name = yourName.Text,
                            Background = colorPicker.SelectedColor.ToString(),
                            ColorOfName = colorPicker2.SelectedColor.ToString()
                        };
                        File.WriteAllText(filePath, JsonConvert.SerializeObject(somebody));

                        if (MessageBox.Show("You're registered!", "Congrat", MessageBoxButton.OK) == MessageBoxResult.OK)
                        {
                            User user = new User();
                            Application.Current.MainWindow = user;
                            Close();
                            user.Show();
                        }
                    }
                }
            }
        }
    }
}
