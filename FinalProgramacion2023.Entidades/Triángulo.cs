namespace FinalProgramacion2023.Entidades
{
    public class Triangulo
    {
        //Atributos de la clase
        private const int _CantidadLados = 3;
        private int _medidaLado;
        private TipoDeBorde tipoDeBorde;
        public double LadoA { get; private set; }
        public double LadoB { get; private set; }
        public double LadoC { get; private set; }

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            if (!EsTriangulo(ladoA, ladoB, ladoC))
                throw new Exception("No es un triángulo");

            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
            
        }
        private bool EsTriangulo(double ladoA, double ladoB, double ladoC)
        {
            return ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA;
        }
        public TipoDeBorde TipoDeBorde
        {
            get { return tipoDeBorde; }
            set { tipoDeBorde = value; }
        }

        private Color colorRelleno;

        public Color ColorRelleno
        {
            get { return colorRelleno; }
            set { colorRelleno = value; }
        }

        //Constructores
        public Triangulo()
        {

        }
        public Triangulo(int MedidaLado, TipoDeBorde borde, Color color)
        {

            _medidaLado = MedidaLado;
            TipoDeBorde = borde;
            ColorRelleno = color;
            //if (MedidaLado>0)
            //{

            //}
            //else
            //{
            //    throw new ArgumentException("Medida del lado no válida");
            //}
        }
        //Métodos acceden a atributos
        public bool Validar()
        {
            return _medidaLado > 0;
        }
        public int GetLado() => _medidaLado;
        public void SetLado(int medida)
        {
            if (medida > 0)
            {
                _medidaLado = medida;
            }
        }

        //Métodos de información
        public double GetPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }
        public string TipoTriangulo()
        {
            if (LadoA == LadoB && LadoB == LadoC)
                return "Equilátero";
            else if (LadoA == LadoB || LadoA == LadoC || LadoB == LadoC)
                return "Isósceles";
            else
                return "Escaleno";
        }

        public double GetArea()
        {
            double p = GetPerimetro() / 2;
            return Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC));
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
