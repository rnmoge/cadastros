﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CadastrosBaseClient.ViewModel.CadastrosBase;

namespace CadastrosBaseClient.View.CadastrosBase
{
    /// <summary>
    /// Interaction logic for Cbo.xaml
    /// </summary>
    public partial class Cbo : UserControl
    {
        public Cbo()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btSair_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ((CboViewModel)this.DataContext).IsEditar= false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema");
            }
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ((CboViewModel)this.DataContext).salvarAtualizarCbo();
                MessageBox.Show("Salvo com sucesso!", "Informação do sistema");
                ((CboViewModel)this.DataContext).atualizarListaCbo(0);
                ((CboViewModel)this.DataContext).IsEditar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema");
            }
        }

    }
}
