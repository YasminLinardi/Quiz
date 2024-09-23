
namespace quizshowdomilhao

{
    public class Gerenciador
 {
    List <Questao> ListaQuestoes = new List <Questao> ();
    List <int> ListaQuestoesRespondidas = new List <int> ();
    Questao QuestaoCorrente;

    public Gerenciador (Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05 )
     {
        CriaPerguntas ( labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05 );
     }

    void CriaPerguntas (Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05 )
    {
        
    }

 public async void VerificaCorreta (int RespostaEscolhida)
       {
        if (QuestaoCorrente.VerificaResposta(RespostaEscolhida))
        {
            await Task.Delay(1000);
            ProximaQuestao();
        }
       }

       void ProximaQuestao()
       {
        var nAleat = Random.Shared.Next(0, ListaQuestoes.Count);
        while (ListaQuestoesRespondidas.Contains(nAleat))
               nAleat= Random.Shared.Next (0, ListaQuestoes.Count);

        ListaQuestoesRespondidas.Add(nAleat);
        QuestaoCorrente = ListaQuestoes [nAleat];
        QuestaoCorrente.Desenhar ();
       }


 }

}
