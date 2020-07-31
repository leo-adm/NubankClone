using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NubankClone.ViewModels
{
    public class FaturaViewModel : BaseViewModel
    {
        private bool Visivel = true;
        public Color CorFatura => Visivel ? Color.LightSeaGreen : Color.FromHex("F2F2F2");
        public Color CorFundoFatura => Visivel ? Color.White : Color.FromHex("F2F2F2");
        public Color CorTextoLimite => Visivel ? Color.Default : Color.FromHex("F2F2F2");
        public Color CorValorLimite => Visivel ? Color.LightGreen : Color.FromHex("F2F2F2");
        public string IconeVisibilidade => Visivel ? "\uf070" : "\uf06e";
        public Command AlternarVisibilidade { get; set; }

        public FaturaViewModel()
        {
            AlternarVisibilidade = new Command(() =>
            {
                Visivel = !Visivel;
                OnPropertyChanged("CorFatura");
                OnPropertyChanged("CorFundoFatura");
                OnPropertyChanged("CorTextoLimite");
                OnPropertyChanged("CorValorLimite");
                OnPropertyChanged("IconeVisibilidade");
            });
        }
    }
}
