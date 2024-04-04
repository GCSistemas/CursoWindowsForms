using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca
{
    public class Login
    {
        public bool VerificarLogin(string nome, string senha)
        {
            if (nome.Trim() == "RHAEL" && senha.Trim() == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
