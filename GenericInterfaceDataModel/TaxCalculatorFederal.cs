using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaceDataModel
{
    public class TaxCalculatorFederal:ITaxRepository<FederalRequest,FederalResponse>
    {
        public FederalResponse GetVat(FederalRequest request)
        {
            return new FederalResponse { TaxRate = request.TaxRate };
        }
    }
}
