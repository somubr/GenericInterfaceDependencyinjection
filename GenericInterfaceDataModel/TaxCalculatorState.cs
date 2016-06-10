using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaceDataModel
{
    public class TaxCalculatorState:ITaxRepository<StateRequest,StateResponse>
    {

        public StateResponse GetVat(StateRequest request)
        {
            return new StateResponse { TaxRate = request.TaxRate };
        }
    }
}
