using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_1205
{
    public class Futebol : Equipe
    {
        public void PontuacaoCasa()
        {
            PontoCasa += 1;
            Console.WriteLine($"\nPonto do time {NomeTimeCasa} \nPlacar final: {PontoCasa} X {PontoVisitante}");
        }
        public void PontuacaoVisitante()
        {
            PontoVisitante += 1;
            Console.WriteLine($"\nPonto do time {NomeTimeVisitante} \nPlacar final: {PontoCasa} X {PontoVisitante} ");
        }
        public void Resultado()
        {
            if (PontoCasa > PontoVisitante)
            {
                Console.WriteLine($"\nO time {NomeTimeCasa} venceu \nPlacar final: {PontoCasa} X {PontoVisitante}");
            }
            else if (PontoVisitante > PontoCasa)
            {
                Console.WriteLine($"\nO time {NomeTimeVisitante} venceu \nPlacar final: {PontoCasa} X {PontoVisitante}");
            }
            else if (PontoCasa == PontoVisitante)
            {
                Console.WriteLine($"\nO time {NomeTimeVisitante} e o {NomeTimeCasa} empataram \nPlacar final: {PontoCasa} X {PontoVisitante}");
            }
        }
    }
}
