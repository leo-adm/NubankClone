using NubankClone.ViewModels;
using NubankClone.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NubankClone
{
    public class MyDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TemplateSaldo { get; set; }
        public DataTemplate TemplateFatura { get; set; }
        public DataTemplate TemplateRewards { get; set; }

        public MyDataTemplateSelector()
        {
            TemplateSaldo = new DataTemplate(typeof(Saldo));
            TemplateFatura = new DataTemplate(typeof(Fatura));
            TemplateRewards = new DataTemplate(typeof(Rewards));
        }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is FaturaViewModel)
                return TemplateFatura;
            else if (item is SaldoViewModel)
                return TemplateSaldo;
            else
                return TemplateRewards;
        }
    }
}
