using System;
using System.IO;
using System.Net.Mail;

namespace CursoFoop_SRP_Violacao
{
    class Pedido
    {
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }
        public void IncluirPedido()
        {
            try
            {
                // Codigo para incluir o pedido
                // Após incluir então envia o email
                MailMessage mailMessage =
                    new MailMessage("EMailFrom", "EMailTo", 
                              "EMailSubject", "EMailBody");

                this.EnviaEmailPedido(mailMessage);
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\dados\ErrorLog.txt", ex.ToString());
            }
        }
        public void DeletaPedido()
        {
            try
            {
                //Codigo para deletar o pedido gerado
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\dados\ErrorLog.txt", ex.ToString());
            }
        }
        public void EnviaEmailPedido(MailMessage mailMessage)
        {
            try
            {
                // Código para enviar configurar 
                // email e enviar o email do pedido
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\dados\ErrorLog.txt", ex.ToString());
            }
        }
    }
}
