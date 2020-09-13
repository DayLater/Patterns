using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AdapterService: IService
    {
        private NeededService _neededService;
        public AdapterService(NeededService neededService)
        {
            this._neededService = neededService;
        }
        public string GetInfo()
        {
            return _neededService.GetSuperImportantInfo();
        }
    }
}
