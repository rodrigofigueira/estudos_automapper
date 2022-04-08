namespace estudos_automapper
{
    public static class CalcularIdade
    {

        public static int Calcular(DateTime dataNascimento){
            
            int idade = DateTime.Now.Year - dataNascimento.Year;

            if(DateTime.Now.DayOfYear < dataNascimento.DayOfYear){
                idade--;
            }

            return idade;

        }

    }
}