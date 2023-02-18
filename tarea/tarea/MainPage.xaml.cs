﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace tarea
{
    public partial class MainPage : ContentPage
    {
        int numero_1;
        int numero_2;
        double operation_resul ;
    
        
        public MainPage()
        {
            InitializeComponent();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

    

        private void btnsumar_Clicked(object sender, EventArgs e)
        {
            numero_1 = int.Parse(txtn1.Text);
            numero_2 = int.Parse(txtn2.Text);
            operation_resul = numero_1 + numero_2;
            lblesltado.Text = operation_resul + "";
        }

        private void btnrestar_Clicked(object sender,EventArgs e)
        {
            numero_1 = int.Parse(txtn1.Text);
            numero_2 = int.Parse(txtn2.Text);
            operation_resul = numero_1 - numero_2;
            lblesltado.Text = operation_resul + "";
        }

        private void btnmultiplicar_Clicked(object sender, EventArgs e)
        {
            numero_1 = int.Parse(txtn1.Text);
            numero_2 = int.Parse(txtn2.Text);
            operation_resul = numero_1 * numero_2;
            lblesltado.Text = operation_resul + "";
        }

        private void btndividir_Clicked(object sender, EventArgs e)
        {
            numero_1 = int.Parse(txtn1.Text);
            numero_2 = int.Parse(txtn2.Text);
            operation_resul = numero_1 / numero_2;
            lblesltado.Text = operation_resul + "";
        }
         
    }

}
