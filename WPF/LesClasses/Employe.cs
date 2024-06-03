using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE2._01
{
    public class Employe
    {
        private int numEmploye;
        private int numMagasin;
        private string login;
        private string mdp;

        public int NumEmploye { get => numEmploye; set => numEmploye = value; }
        public int NumMagasin { get => numMagasin; set => numMagasin = value; }
        public string Login { get => login; set => login = value; }
        public string Mdp { get => mdp; set => mdp = value; }

        public Employe(int numEmploye, int numMagasin, string login, string mdp)
        {
            NumEmploye = numEmploye;
            NumMagasin = numMagasin;
            Login = login;
            Mdp = mdp;
        }
    }
}
