namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario(nome: "Jedson Marque", salarioBase: 1991.11, valorHorasExtra:12.62 ,quantidadeHorasExtra: 7);
            funcionario1.GerarRelatorio();
            funcionario1.ModificarCampos();
        }     
    }
}
