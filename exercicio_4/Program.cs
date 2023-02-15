public class Guitarra
{


static void SeiLa()
{

afinacao = "SOL";


}

private static string afinacao;
private void TomAfinado()
{
    Console.WriteLine($"Está com afinação em {afinacao}");
}

public void Tocar()
{
    TomAfinado();
}


public void Tocar(string AfinacaoAtual)
{

afinacao = AfinacaoAtual;
TomAfinado();

}


}