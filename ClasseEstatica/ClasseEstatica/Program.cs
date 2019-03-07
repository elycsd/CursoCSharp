using System;

namespace ClasseEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Uma classe normal(nao estatica) deve ser instanciada para ser utilizada*/
            Normal objeto1 = new Normal();
            objeto1.Nome = "Ely Carlos";
            objeto1.MostrarNome();

            Normal objeto2 = new Normal();
            objeto2.Nome = "Ely Carlos Dias";
            objeto2.MostrarNome();

            /*Uma classe estatica nao pode ser instanciada
              Estatica objeto3 = new Estatica(); retornaria um erro
              Deve-se escrever o proprio nome da classe e sua propriedade ou método.
              Classes estaticas não são consideradas boas praticas.
            */
            Estatica.Nome = "Ely Dias";
            Estatica.MostrarNome();
        }
    }
}
