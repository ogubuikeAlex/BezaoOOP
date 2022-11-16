using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezaoOOP
{
    internal class LearningAccessModifiers
    {
    }

    public class Baller
    {
         protected internal decimal Money { get; set; }

        private protected string Bitcoin { get; set; }
    }

    public class Mechanic : Baller
    {
        public void MyOwn()
        {
            Baller baller = new Baller();
            Bitcoin = "More Bitcoin";
        }
    }
}
