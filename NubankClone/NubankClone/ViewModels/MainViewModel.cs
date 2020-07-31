using NubankClone.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace NubankClone.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Aba> Abas { get; set; }
        public List<BaseViewModel> Frames { get; set; }
        public MainViewModel()
        {
            // Mock Data
            Aba Dividir = new Aba() { Nome = "Dividir valor", Icone = "\uf653", OnClick = () => { } };
            Aba Emprestimos = new Aba() { Nome = "Emprestimos", Icone = "\uf4c0", OnClick = () => { } };
            Aba Doacao = new Aba() { Nome = "Doação", Icone = "\uf4b9", OnClick = () => { } };
            Aba Depositar = new Aba() { Nome = "Depositar", Icone = "\uf0ab", OnClick = () => { } };
            Aba Pagar = new Aba() { Nome = "Pagar", Icone = "\uf02a", OnClick = () => { } };
            Aba Transferir = new Aba() { Nome = "Transferir", Icone = "\uf0aa", OnClick = () => { } };

            Abas = new ObservableCollection<Aba>() { Dividir, Emprestimos, Doacao, Depositar, Pagar, Transferir };

            // Main Frames
            Frames = new List<BaseViewModel>() { 
                new FaturaViewModel(), 
                new SaldoViewModel(), 
                new RewardsViewModel() 
            };
        }
    }
}
