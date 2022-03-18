using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MobAvaliacao.Controll
{
    public interface ISave
    {
        //salvar o documento como um arquivo e abrir ele
        Task SaveAndView(string filename, string contentType, MemoryStream stream);
    }
}
