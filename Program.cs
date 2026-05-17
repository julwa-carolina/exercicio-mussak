using Exercicio_1205;
using System;

using static Exercicio_1205.Futebol;
class Program
{
    static void Main()
    {
        Futebol TimeUm = new Futebol();
        TimeUm.NomeTimeCasa = "Flamengo";
        TimeUm.NomeTimeVisitante = "Palmeiras";
        TimeUm.PontoVisitante = 0;
        TimeUm.PontoCasa = 0;
        TimeUm.PontuacaoVisitante();
        TimeUm.PontuacaoVisitante();
        TimeUm.PontuacaoVisitante();
        TimeUm.PontuacaoCasa();
        TimeUm.Resultado();

        Basquete TimeDois = new Basquete();
        TimeDois.NomeTimeCasa = "Vasco";
        TimeDois.NomeTimeVisitante = "Botafogo";
        TimeDois.PontoVisitante = 0;
        TimeDois.PontoCasa = 0;
        TimeDois.PontuacaoVisitanteBasquete();
        TimeDois.PontuacaoVisitanteBasquete();
        TimeDois.PontuacaoCasaBasquete();
        TimeDois.PontuacaoCasaBasquete();
        TimeDois.PontuacaoCasaBasquete();
        TimeDois.PontuacaoCasaBasquete();
        TimeDois.PontuacaoCasaBasquete();
        TimeDois.Resultado();

    }
}
