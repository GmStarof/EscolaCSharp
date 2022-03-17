using System;






namespace AppaiEstude
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MenuPrincipalPrintFService       menu       = new MenuPrincipalPrintFService();
            GestaoDeAlunosPrintMenuService      aluno      = new GestaoDeAlunosPrintMenuService();
            GestaoDeProfessoresPrintMenuService profe      = new GestaoDeProfessoresPrintMenuService();
            CurriculoEscolar    curriculo       = new CurriculoEscolar();
            GestaofinanceiraPrintMenu    fina       = new GestaofinanceiraPrintMenu();

            menu.printMenu();

            switch (Console.ReadLine())
            {
                case "1":

                    aluno.gestaoDeAlunos();

                    break;

                case "2":

                    profe.gestaoDeProfessor();

                    break;

                case "3":

                    curriculo.curriculoEscolar();

                    break;

                case "4":

                    fina.gestaofinanceira();

                    break;
            }
            Console.Clear();



            Console.Write("Pressione Enter para terminar a aplicação.");
            Console.ReadKey();

        }

       
    }
}
