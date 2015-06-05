﻿using System;
using System.Windows;
using System.Windows.Controls;
using CadastrosBaseClient.ViewModel.CadastrosBase;

namespace CadastrosBaseClient.View.CadastrosBase
{
    /// <summary>
    /// Interaction logic for CadastrosBasePrincipal.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public static Boolean logado;
        private UsuarioViewModel viewModelUsuario;

        public Login()
        {
            InitializeComponent();
            viewModelUsuario = new UsuarioViewModel();
            logado = false;
            textBoxLogin.Focus();
        }

        private void btConfirmar_Click(object sender, RoutedEventArgs e)
        {
            if (viewModelUsuario.login(textBoxLogin.Text, textBoxSenha.Password))
            {
                logado = true;
                ERPClient.JanelaLogin.Close();
            }
            else
            {
                MessageBox.Show("Login e/ou Senha Incorretos", "Erro no Login", MessageBoxButton.OK, MessageBoxImage.Error);
                textBoxLogin.Focus();
            }
        }

        private void btSair_Click(object sender, RoutedEventArgs e)
        {
            ERPClient.JanelaLogin.Close();
        }

        
    }
}
