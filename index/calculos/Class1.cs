namespace calculos {
    public class AreasGeometricas {
        public double valor1, valor2, valor3;

        public double Triangulo(double v1, double v2, double v3) {
            double area;

            area = v1 * v3 / 2;

            return area;
        }

        public double Circulo(double v1, double v2, double v3) {
            double area;
            double pi = 3.14159;

            area = pi * v3 * v3;

            return area;
        }

        public double Trapezio(double v1, double v2, double v3) {
            double area;

            area = (v1 + v2) * v3 / 2;

            return area;
        }

        public double Quadrado(double v1, double v2, double v3) {
            double area;

            area = v2 * v2;

            return area;
        }

        public double Retangulo(double v1, double v2, double v3) {
            double area;

            area = v1 * v2;

            return area;
        }
    }
}