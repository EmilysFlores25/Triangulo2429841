using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo2429841.ViewsModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double _Lad1;

        [ObservableProperty]
        private double _Lad2;
        [ObservableProperty]
        private double _Lad3;
        [ObservableProperty]
        private double _Area;

        [ObservableProperty]
        private string? _Areares;

        [RelayCommand]
        public void CalArea()
        {
            double resultado = (Lad1 + Lad2 + Lad3) / 2;
            double area = Math.Sqrt(resultado * (resultado - Lad1) * (resultado - Lad2) * (resultado - Lad3));
            Areares = area.ToString("F2");
        }
    }
}
