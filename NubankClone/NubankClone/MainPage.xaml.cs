using NubankClone.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NubankClone
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private bool showingConfig = false;
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }

        private void ToggleConfig(object sender, EventArgs e)
        {
            // Animação do ícone de flecha

            AngleIcon.FadeTo(0, 75);
            AngleIcon.RotateXTo(90, 75);
            AngleIcon.FadeTo(1, 75);

            if (showingConfig)
                AngleIcon.RotateXTo(0, 75);
            else
                AngleIcon.RotateXTo(180, 75);

            showingConfig = !showingConfig;
        }
    }
}
