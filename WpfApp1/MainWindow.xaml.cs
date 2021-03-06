﻿using DasBessereDIscord.Server.Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly ViewModelMessageing viewModel;

        public MainWindow()
        {
            this.InitializeComponent();
            viewModel = new ViewModelMessageing{window = this};
        }
        private void LogOffButton_Click(object sender, RoutedEventArgs e)
        {
            LogINScreen.Visibility = Visibility.Visible;
            Chatroom.Visibility = Visibility.Hidden;
            viewModel.LogOut();
        }
        public void PrintMessage()
        {
            ChatroomTextBlock.Text += "\n" + viewModel.ReturnServerMessageInViewModel();
        }
        private void SendMessageButton_Click(object sender, RoutedEventArgs e)
        {
            string userMessage;
            userMessage = SendMessageTextBox.Text;
            SendMessageTextBox.Text = "";
            viewModel.SendMessage(userMessage);
        }
        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.LogIn(UserNameTextBox.Text);
            LogINScreen.Visibility = Visibility.Hidden;
            Chatroom.Visibility = Visibility.Visible;
        }
    }
}
