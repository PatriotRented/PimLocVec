using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Pim.Patriot.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILocacaoService" in both code and config file together.
    [ServiceContract]
    public interface ILocacaoService
    {
        [OperationContract]
        DataTable selAllLoca(string _cli, string _loc, string _vec);

        [OperationContract]
        string selCliLoc(int _codLoc, int _codfun);

        [OperationContract]
        string selPlacaLoc(int _codLoc, int _codfun);

        [OperationContract]
        List<string> selLocaParaDev(int _codLoc);

        [OperationContract]
        void updateStVeiculoD(string _placa);

    }
}
