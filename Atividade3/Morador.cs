using static System.Console;
namespace Teste.Atividade3
{
    public class Morador
    {
    private string Telefone;
    private int NmrCasa;
    public Morador(string Tel,int NmrResidencia)
    {
        this.Telefone = Tel;
        this.NmrCasa = NmrResidencia;
    }
    public string TelefoneInfo()
    {
        return Telefone;
    }
    public int NmrCasaInfo()
    {
        return NmrCasa;
    }

    }
}