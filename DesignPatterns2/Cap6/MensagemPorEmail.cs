using System;

namespace DesignPatterns2.Cap6
{
    public class MensagemPorEmail:IMensagem
    {
        public IEnviador Enviador { get; set; }
        private string nome;
        public MensagemPorEmail(string nome)
        {
            this.nome = nome;
        }

       
        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando a mensagem para o cliente {0}", nome);
        }
    }
}