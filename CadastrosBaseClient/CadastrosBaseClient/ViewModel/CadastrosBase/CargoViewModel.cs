using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CadastrosBaseClient.CadastrosBaseReference;
using CadastrosBaseClient.Command;

namespace CadastrosBaseClient.ViewModel.CadastrosBase
{
	/// 
	/// The MIT License
	///
	/// Copyright: Copyright (C) 2010 T2Ti.COM
	///
	/// Permission is hereby granted, free of charge, to any person
	/// obtaining a copy of this software and associated documentation
	/// files (the "Software"), to deal in the Software without
	/// restriction, including without limitation the rights to use,
	/// copy, modify, merge, publish, distribute, sublicense, and/or sell
	/// copies of the Software, and to permit persons to whom the
	/// Software is furnished to do so, subject to the following
	/// conditions:
	///
	/// The above copyright notice and this permission notice shall be
	/// included in all copies or substantial portions of the Software.
	///
	/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
	/// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
	/// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
	/// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
	/// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
	/// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
	/// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
	/// OTHER DEALINGS IN THE SOFTWARE.
	///
	///        The author may be contacted at:
	///            t2ti.com@gmail.com
	///
	/// Autor: Albert Eije (t2ti.com@gmail.com)
	/// Version: 1.0
    public class CargoViewModel : ERPViewModelBase
    {
        public ObservableCollection<CargoDTO> ListaCargo { get; set; }
        private CargoDTO _CargoSelected;
        private int primeiroResultado;
        protected ICommand seguinteCommand;
        protected ICommand anteriorCommand;
        private bool _isEditar { get; set; }


        public CargoViewModel()
        {
            try
            {
                ListaCargo = new ObservableCollection<CargoDTO>();
                primeiroResultado = 0;
                this.atualizarListaCargo(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CargoDTO CargoSelected
        {
            get { return _CargoSelected; }
            set
            {
                _CargoSelected = value;
                notifyPropertyChanged("CargoSelected");
            }
        }

        public ICommand paginaSeguinteCommand
        {
            get
            {
                if (seguinteCommand == null)
                {
                    seguinteCommand = new RelayCommand
                    (
                        param =>
                        {
                            this.atualizarListaCargo(1);
                        },
                        param =>
                        {
                            return true;
                        }
                    );
                }
                return seguinteCommand;
            }
        }

        public ICommand paginaAnteriorCommand
        {
            get
            {
                if (anteriorCommand == null)
                {
                    anteriorCommand = new RelayCommand
                    (
                        param =>
                        {
                            this.atualizarListaCargo(-1);
                        },
                        param =>
                        {
                            return true;
                        }
                    );
                }
                return anteriorCommand;
            }
        }

        public void salvarAtualizarCargo()
        {
            try
            {
                using (ServicoCadastrosBaseClient serv = new ServicoCadastrosBaseClient())
                {
                    CargoSelected.Empresa = Empresa;
                    serv.salvarAtualizarCargo(CargoSelected);
                    CargoSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void atualizarListaCargo(int pagina)
        {
            try
            {
                using (ServicoCadastrosBaseClient serv = new ServicoCadastrosBaseClient())
                {
                    if (pagina == 0)
                        primeiroResultado = 0;
                    else if (pagina > 0)
                        primeiroResultado += QUANTIDADE_PAGINA;
                    else if (pagina < 0)
                        primeiroResultado -= QUANTIDADE_PAGINA;

                    List<CargoDTO> listaServ = serv.selectCargoPagina(primeiroResultado, QUANTIDADE_PAGINA, new CargoDTO());

                    ListaCargo.Clear();

                    foreach (CargoDTO objAdd in listaServ)
                    {
                        ListaCargo.Add(objAdd);
                    }
                    CargoSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void excluirCargo()
        {
            try
            {
                using (ServicoCadastrosBaseClient serv = new ServicoCadastrosBaseClient())
                {
                    serv.deleteCargo(CargoSelected);
                    CargoSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool IsEditar
        {
            get { return _isEditar; }
            set
            {
                _isEditar = value;
                notifyPropertyChanged("IsEditar");
                notifyPropertyChanged("IsListar");
            }
        }

        public bool IsListar
        {
            get { return !_isEditar; }
            set
            {
                _isEditar = !value;
                notifyPropertyChanged("IsEditar");
                notifyPropertyChanged("IsListar");
            }
        }
    }
}
