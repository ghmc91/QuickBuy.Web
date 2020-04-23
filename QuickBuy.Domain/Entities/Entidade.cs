using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBuy.Domain.Entities
{
    public abstract class Entidade
    {
     
        private List<string> _mensagemValidacao { get; set; }

        public List<string> Mensagem 
        {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); } 
        }

        protected void LimparMensagemValidacao()
        {
            _mensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem) => _mensagemValidacao.Add(mensagem);

        public abstract void Validate();
        protected bool EhValido
        {
            get { return !_mensagemValidacao.Any(); }
        }

    }
}
