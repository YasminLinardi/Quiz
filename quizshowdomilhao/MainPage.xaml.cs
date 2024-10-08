﻿namespace quizshowdomilhao;

public partial class MainPage : ContentPage
{
  Gerenciador gerenciador;
	public MainPage()
	{
		InitializeComponent();
		gerenciador = new Gerenciador (labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05, labelPoints, labellvl );
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

	int pula = 0;

void OnAjudaPulaClicked (object s, EventArgs e)
	{
		if (pula == 2)
			(s as Button).IsVisible=false;
			else
			{
				gerenciador.ProximaQuestao();
					pula ++;
			}
			if (pulou == 1)
			Pulou3X.Text="Pular 2X";
			else
			Pulou3X.Text="Pular 2X";

		}
	}


	void OnAjudaRetirarClicked (object s, EventArgs e) 
	{
		var ajuda= new RetiraErradas ();
		ajuda.ConfigurarDesenho(btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
		(s as Button).IsVisible=true;
	}

}