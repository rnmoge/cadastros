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
using CadastrosBaseClient.CadastrosBaseReference;

namespace CadastrosBaseClient.View.CadastrosBase
{
    /// <summary>
    /// Interaction logic for CstCofinsPrincipal.xaml
    /// </summary>
    public partial class CstCofinsPrincipal : UserControl
    {
        private CstCofinsViewModel viewModel;
        public CstCofinsPrincipal()
        {
            InitializeComponent();
            viewModel = new CstCofinsViewModel();
            this.DataContext = viewModel;
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (viewModel.cstcofinsSelected != null)
                {
                    viewModel.excluirCstCofins();
                    MessageBox.Show("Exclusão efetuada com sucesso!", "Informação do sistema");

                    viewModel.atualizarListaCstCofins(0);
                }
                else
                    MessageBox.Show("Selecione um elemento na lista.", "Alerta do sistema");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema");
            }
        }

        private void btnIncluir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                viewModel.cstcofinsSelected = new CstCofinsDTO();
                viewModel.IsEditar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema");
            }
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (viewModel.cstcofinsSelected != null)
                    viewModel.IsEditar = true;
                else
                    MessageBox.Show("Selecione um elemento na lista.", "Alerta do sistema");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta do sistema");
            }
        }
    }
}
