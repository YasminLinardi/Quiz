
namespace quizshowdomilhao

public class Gerenciador
{
    List <Questao> ListaQuestoes = Now List <Questao> ();
    List <int> ListaQuestoesRespondidas = Now List <int> ();
    Questao QustaoCorrente;
        
public Gerenciador (Label labelPerg, Button btnResposta01, Button btnResposta02, Button btnResposta03, Button btnResposta04, Button btnResposta05)
{
    CriaPerguntas (labelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05)
}

void CriaPerguntas (Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05)
{
    var Q1 = new Questao();
    Q1. ConfigurarDesenho (labelPerg)
}
}

