﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ServerLega.Dominio;

namespace ServerLega.InterfacceController
{

    public interface ICaricaListaController
    {
        Lega CaricaLista(Lega lega);
    }
}
