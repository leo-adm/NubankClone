using System;
using System.Collections.Generic;
using System.Text;

namespace NubankClone.Models
{
    public class Aba
    {
        public String Icone { get; set; }
        public String Nome { get; set; }
        public Action OnClick { get; set; }
    }
}
