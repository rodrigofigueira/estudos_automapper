namespace estudos_automapper.Extensions
{
    public static class DateTimeExtension
    {
        public static int CalcularIdade(this DateTime dataNascimento){
            
            int idade = DateTime.Now.Year - dataNascimento.Year;

            if(DateTime.Now.DayOfYear < dataNascimento.DayOfYear){
                idade--;
            }

            return idade;

        }
    }
}