using quizshowdomilhao;

public class RetiraErradas : IAjuda
{
    public override void RealizaAjuda (Questao q)
    {
        switch (Questao.RespostaCerta)
        {
            case 1:
            btnResp02.IsVisible= false;
            btnResp03.IsVisible= false;
            btnResp04.IsVisible= false;
            break;

            case 2:
            btnResp03.IsVisible= false;
            btnResp04.IsVisible= false;
            btnResp05.IsVisible= false;
            break;

            case 3:
            btnResp01.IsVisible= false;
            btnResp02.IsVisible= false;
            btnResp04.IsVisible= false;
            break;

            case 4:
            btnResp01.IsVisible= false;
            btnResp02.IsVisible= false;
            btnResp03.IsVisible= false;
            break;

            case 5:
            btnResp02.IsVisible= false;
            btnResp03.IsVisible= false;
            btnResp04.IsVisible= false;
            break;

        }
    }

    internal void ConfigurarDesenho(Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05)
    {
        throw new NotImplementedException();
    }
}

public interface IAjuda
{
}