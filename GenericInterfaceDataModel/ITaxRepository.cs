using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaceDataModel
{
    public interface ITaxRepository<TRequest,TResponse>
    {
        TResponse GetVat(TRequest request);
    }
}
