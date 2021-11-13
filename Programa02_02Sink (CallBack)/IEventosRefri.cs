using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_02Sink_CallBack
{
    interface IEventosRefri
    {
        void EReservasBajas(int pKilos);

        void EDescongelado(int pGrados);
    }
}
