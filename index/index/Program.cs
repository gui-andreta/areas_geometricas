using calculos;

internal class Program {
    private static void Main(string[] args) {
        Console.WriteLine("Vamos calcular areas geometricas: ");
        Console.WriteLine("Digite o primeiro numero: ");
        string n1 = Console.ReadLine();

        Console.WriteLine("Digite o segundo numero: ");
        string n2 = Console.ReadLine();

        Console.WriteLine("Digite o terceiro numero: ");
        string n3 = Console.ReadLine();

        AreasGeometricas ag = new AreasGeometricas();

        ag.valor1 = double.Parse(n1);
        ag.valor2 = double.Parse(n2);
        ag.valor3 = double.Parse(n3);

        double triangulo = ag.Triangulo(ag.valor1, ag.valor2, ag.valor3);
        double circulo = ag.Circulo(ag.valor1, ag.valor2, ag.valor3);
        double trapezio = ag.Trapezio(ag.valor1, ag.valor2, ag.valor3);
        double quadrado = ag.Quadrado(ag.valor1, ag.valor2, ag.valor3);
        double retangulo = ag.Retangulo(ag.valor1, ag.valor2, ag.valor3);

        Console.WriteLine("As Areas são: ");
        Console.WriteLine("Triangulo: " + triangulo.ToString("F3"));
        Console.WriteLine("Circulo: " + circulo.ToString("F3"));
        Console.WriteLine("Trapezio: " + trapezio.ToString("F3"));
        Console.WriteLine("Quadrado: " + quadrado.ToString("F3"));
        Console.WriteLine("Reatangulo: " + retangulo.ToString("F3"));
    }
}