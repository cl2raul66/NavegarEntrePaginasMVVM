﻿using CommunityToolkit.Mvvm.DependencyInjection;
using PaginasMVVM.VistasModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginasMVVM.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Operaciones2 : ContentPage
    {
        public Operaciones2()
        {
            InitializeComponent();
            BindingContext = Ioc.Default.GetService<Operaciones2VistaModelo>();
        }
    }
}