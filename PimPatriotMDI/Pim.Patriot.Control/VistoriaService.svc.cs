using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Pim.Patriot.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "VistoriaService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select VistoriaService.svc or VistoriaService.svc.cs at the Solution Explorer and start debugging.
    public class VistoriaService : IVistoriaService
    {
        public void MudaStatus(int _st, int _codLoc)
        {
            Vistoria vist = new Vistoria();
            
            vist.MudaStatus(_st, _codLoc);
        }
    }
}
