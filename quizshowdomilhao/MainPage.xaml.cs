﻿namespace quizshowdomilhao;

public partial class MainPage : ContentPage
{
  Gerenciador gerenciador;
        public MainPage()
        {
                InitializeComponent();
                gerenciador = new Gerenciador (labelPerg, A, B, C, D, E);
        }

    void OnButtonRep1Clicked (object sender, EventArgs args)
        {
                gerenciador.VerificaCorreta(1);
        }
    void OnButtonRep2Clicked (object sender, EventArgs args)
        {
                gerenciador.VerificaCorreta(2);
        }
    void OnButtonRep3Clicked (object sender, EventArgs args)
        {
                gerenciador.VerificaCorreta(3);
        }
    void OnButtonRep4Clicked (object sender, EventArgs args)
        {
                gerenciador.VerificaCorreta(4);
        }

        void OnButtonRep5Clicked (object sender, EventArgs args)
        {
                gerenciador.VerificaCorreta(5);
        }

}
