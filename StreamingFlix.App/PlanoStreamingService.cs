namespace StreamingFlix.App;

public class PlanoStreamingService
{
    public string ObterClassificacaoPorQualidade(int telasSimultaneas)
    {
        if (telasSimultaneas == 1)
        {
            return "BÁSICO";
        }

        if (telasSimultaneas == 2)
        {
            return "PADRÃO";
        }

        if (telasSimultaneas >= 4)
        {
            return "PREMIUM";
        }

        return "INVÁLIDO";
    }

    public double CalcularMensalidadeComDesconto(int valorBase, int mesesContratados)
{
    if (mesesContratados >= 12)
    {
        return valorBase * 0.80;
    }

    if (mesesContratados >= 6)
    {
        return valorBase * 0.90;
    }

    return valorBase;
}
public bool PodeAcessarConteudoAdulto(int idade, bool controleParentalAtivo)
{
    if (idade >= 18 && controleParentalAtivo == false)
    {
        return true;
    }

    return false;
}

}