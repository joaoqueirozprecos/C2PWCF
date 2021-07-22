using C2P.WCF.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace C2P.WCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class C2PService : IC2PService
    {
        public C2P.WCF.C2PPriceGeneral.NelsonSiegel RetornoNelsonSiegel()
        {
            C2P.WCF.C2PPriceGeneral.NelsonSiegel teste = new C2PPriceGeneral.NelsonSiegel();
            try
            {
                Business.XMLParametroEntrada parametro = new XMLParametroEntrada();
                Consumer.ProcessaNelsonSiegel processaNelsonSiegel = new Consumer.ProcessaNelsonSiegel();
                parametro = Mock.ReturnMock();
                teste = processaNelsonSiegel.NelsonSiegel(parametro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return teste;
        }

        public C2P.WCF.C2PPriceGeneral.NelsonSiegel RetornoFitting()
        {
            C2P.WCF.C2PPriceGeneral.NelsonSiegel teste = new C2PPriceGeneral.NelsonSiegel();
            try
            {
                Business.XMLParametroEntrada parametro = new XMLParametroEntrada();
                Consumer.ProcessaNelsonSiegel processaNelsonSiegel = new Consumer.ProcessaNelsonSiegel();
                parametro = Mock.ReturnMock();
                teste = processaNelsonSiegel.NelsonSiegel(parametro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return teste;
        }

        public string GetXMLInput()
        {
            XMLParametroEntrada xmlParametros = Mock.ReturnMock();
            C2P.WCF.Business.Serializer serializer = new Serializer();
            string xmlEntrada = serializer.ObjectSerializer(xmlParametros);

            return xmlEntrada;
        }

        public XMLParametroEntrada ConvertXMLtoObject(string xml)
        {
            return new XMLParametroEntrada();
        }

        public string GetXMLOutPut()
        {
            return string.Empty;
        }
    }
}
