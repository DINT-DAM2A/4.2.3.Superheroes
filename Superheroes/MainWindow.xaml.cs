using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Superheroes
{
    public partial class MainWindow : Window
    {
        MainWindowsVM vm = new MainWindowsVM();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        private void Image_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            int num = Convert.ToInt32((sender as Image).Tag.ToString());

            if (num == 1 && (vm.ContadorActual + num) <= vm.TotalHeroes)
                vm.Avanzar();
            else if (num == -1 && (vm.ContadorActual + num) >= 1)
                vm.Retroceder();
        }

    }
}
