using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NubankClone.ViewModels
{
    public class SaldoViewModel : BaseViewModel
    {
        private bool Visivel = true;
        public Color CorSaldo => Visivel ? Color.Black : Color.FromHex("F2F2F2");
        public Color CorFundoSaldo => Visivel ? Color.White : Color.FromHex("F2F2F2");
        public string IconeVisibilidade => Visivel ? "\uf070" : "\uf06e";
        public Command AlternarVisibilidade { get; set; }

        public SaldoViewModel()
        {
            AlternarVisibilidade = new Command(() =>
            {
                Visivel = !Visivel;
                OnPropertyChanged("CorSaldo");
                OnPropertyChanged("CorFundoSaldo");
                OnPropertyChanged("IconeVisibilidade");
            });
        }
    }
}
