using Pim.Patriot.ClassLibrary.ClassesDAO;
using Pim.Patriot.DataAccess.ClassesDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Pim.Patriot.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LocacaoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LocacaoService.svc or LocacaoService.svc.cs at the Solution Explorer and start debugging.
    public class LocacaoService : ILocacaoService
    {
        public DataTable selAllLoca(string _cli, string _loc, string _vec)
        {
            LocacaoDAO locDAO = new LocacaoDAO();
            return locDAO.selAllLoca(_cli, _loc, _vec);
        }

        public string selCliLoc(int _codLoc, int _codfun)
        {
            LocacaoDAO locDAO = new LocacaoDAO();
            return locDAO.selCliLoc(_codLoc, _codfun);
        }

        public List<string> selLocaParaDev(int _codLoc)
        {
            LocacaoDAO locDAO = new LocacaoDAO();
            return locDAO.selLocaParaDev(_codLoc);
        }

        public string selPlacaLoc(int _codLoc, int _codfun)
        {
            LocacaoDAO locDAO = new LocacaoDAO();
            return locDAO.selPlacaLoc(_codLoc, _codfun);
        }

        public void updateStVeiculoD(string _placa)
        {
            VeiculoDAO vecDAO = new VeiculoDAO();
            vecDAO.updateStDis(_placa);
        }
    }
}
