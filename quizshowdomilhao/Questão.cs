using System.Security.AccessControl;
using Vision;

namespace quizshowdomilhao
{
  public class Questao
  {
    public string Pergunta;
    public string Resposta1;
    public string Resposta2;
    public string Resposta3;
    public string Resposta4;
    public string Resposta5;
    public int RespostaCerta;
    public int Nivel;

    private Label labelPergunta;
    private Button btResposta1;
    private Button btResposta2;
    private Button btResposta3;
    private Button btResposta4;
    private Button btResposta5;
    public Questao ()
    {
0
    }
    public void Desenhar ()
    {
        labelPergunta.Text= Pergunta;
        btResposta1.Text= Resposta1;
        btResposta2.Text= Resposta2;
        btResposta3.Text= Resposta3;
        btResposta4.Text= Resposta4;
        btResposta5.Text= Resposta5;
    
    public Questao (Label LP, Button bt1, Button bt2, Button bt3, Button bt4, Button bt5)
    {
        labelPergunta=LP;
        btResposta1= bt01;
        btResposta2= bt02;
        btResposta3= bt03;
        btResposta4= bt04;
        btResposta5= bt05;
    }
     public void ConfiguraDesenho (Label LP, Button bt1, Button bt2, Button bt3, Button bt4, Button bt5)
    {
        labelPergunta=LP;
        btResposta1= bt01;
        btResposta2= bt02;
        btResposta3= bt03;
        btResposta4= bt04;
        btResposta5= bt05;
    }

    public bool VerificaResposta (int RespostaRespondida)
    {
        if (RespostaEscolhida == RespostaCerta)
        {
          var b = Qual (RespostaEscolhida);
              b.BackgroundColor = Color.Green;
        return true;
        }

        else
        {
          var bcerto = Qual (RespostaCerta);
          var berrado = Qual (RespostaEscolhida);
          bcerto.BackgroundColor = Color.Green;
          berrado.Background = Color.Red;
          return false;

        }
    }
    private Button Qual (int RespostaEscolhida)
    {
      if (RespostaEscolhida == 1)
      return buttonRespostaUm;
      if (RespostaEscolhida == 2)
      return buttonRespostaDois;
      if (RespostaEscolhida == 3)
      return buttonRespostaTres;
      if (RespostaEscolhida == 4)
      return buttonRespostaQuatro;
      if (RespostaEscolhida == 5)
      return buttonRespostaCinco;
    }
  }
  }