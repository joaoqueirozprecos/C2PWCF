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
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IC2PService
    {
        // TODO: Adicione suas operações de serviço aqui

        [OperationContract]
        C2PPriceGeneral.NelsonSiegel RetornoNelsonSiegel();


        [OperationContract]
        C2PPriceGeneral.NelsonSiegel RetornoFitting();
        
        [OperationContract]
        string GetXMLInput();
    }

    
}
