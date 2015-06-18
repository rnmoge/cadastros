using CadastrosBaseClient.CadastrosBaseReference;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace CadastrosBaseClient.ViewModel.CadastrosBase
{
    class NivelFormacaoViewModel : ERPViewModelBase
    {
        public ObservableCollection<NivelFormacaoDTO> ListaNivelFormacao { get; set; }
        private NivelFormacaoDTO _NivelFormacaoSelected;
        private int primeiroResultado;
        protected ICommand seguinteCommand;
        protected ICommand anteriorCommand;

        public NivelFormacaoViewModel()
        {
            try
            {
                ListaNivelFormacao = new ObservableCollection<NivelFormacaoDTO>();
                primeiroResultado = 0;
                this.atualizarListaNivelFormacao(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public NivelFormacaoDTO NivelFormacaoSelected
        {
            get { return _NivelFormacaoSelected; }
            set
            {
                _NivelFormacaoSelected = value;
                notifyPropertyChanged("NivelFormacaoSelected");
            }
        }


        public void atualizarListaNivelFormacao(int pagina)
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

                    List<NivelFormacaoDTO> listaServ = serv.selectNivelFormacaoPagina(primeiroResultado, QUANTIDADE_PAGINA, new NivelFormacaoDTO());

                    ListaNivelFormacao.Clear();

                    foreach (NivelFormacaoDTO objAdd in listaServ)
                    {
                        ListaNivelFormacao.Add(objAdd);
                    }
                    NivelFormacaoSelected = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
