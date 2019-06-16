using gametop.Interface;

namespace gametop.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "Teste chuta e pula \n";
        }

        public string Corre()
        {
            return "Teste Corre e salta \n";
        }

        public string Passe()
        {
            return "Teste passa e joga \n";
        }
    }
}