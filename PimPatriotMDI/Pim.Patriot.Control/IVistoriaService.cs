using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Pim.Patriot.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IVistoriaService" in both code and config file together.
    [ServiceContract]
    public interface IVistoriaService
    {
        [OperationContract]
        void MudaStatus(int _st, int _codLoc);
    }
}
