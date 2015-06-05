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
    /// Interaction logic for AtividadeForCli.xaml
    /// </summary>
    public partial class AtividadeForCli : UserControl
    {
        public AtividadeForCli()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ((AtividadeForCliViewModel)this.DataContext).salvarAtualizarAtividadeForCli();
                MessageBox.Show("Salvo com sucesso!", "Informação do sistema");
                ((AtividadeForCliViewModel)this.DataContext).atualizarListaAtividadeForCli(0);
                ((AtividadeForCliViewModel)this.DataContext).IsEditar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema");
            }
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ((AtividadeForCliViewModel)this.DataContext).IsEditar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema");
            }
        }
    }
}
