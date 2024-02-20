using FinalProgramacion2023.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProgramacion2023.Datos
{
    internal class Repositorio
    {
        private readonly string _archivo = Environment.CurrentDirectory + "\\Cuadrados.txt";
        private readonly string _archivoCopia = Environment.CurrentDirectory + "\\Cuadrados.bak";

        private List<Triangulo> listaTriangulo;

        public Repositorio()
        {
            listaTriangulo = new List<Triangulo>();
            LeerDatos();
        }
        public List<Triangulo> GetLista()
        {
            return listaTriangulo;
        }
        private void LeerDatos()
        {
            if (File.Exists(_archivo))
            {
                var lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    string lineaLeida = lector.ReadLine();
                    Triangulo triangulo = ConstruirTriangulo(lineaLeida);
                    listaTriangulo.Add(triangulo);
                }
                lector.Close();

            }
        }
        public void Editar(Triangulo TrianguloEnArchivo, Triangulo TrianguloEditar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Triangulo cuadrado = ConstruirTriangulo(lineaLeida);
                        if (TrianguloEnArchivo.GetLado() != cuadrado.GetLado())
                        {
                            escritor.WriteLine(lineaLeida);
                        }
                        else
                        {
                            lineaLeida = ConstruirLinea(TrianguloEditar);
                            escritor.WriteLine(lineaLeida);
                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
        }
        private Triangulo ConstruirTriangulo (string? lineaLeida)
        {
            //"10"
            var campos = lineaLeida.Split('|');
            //campos[0]="10"
            int lado = int.Parse(campos[0]);
            TipoDeBorde borde = (TipoDeBorde)int.Parse(campos[1]);
            Color color = (Color)int.Parse(campos[2]);
            Triangulo c = new Triangulo(lado, borde, color);
            return c;

        }

        public void Agregar(Triangulo triangulo)
        {
            //using (var escritor = new StreamWriter(_archivo, true))
            //{
            //    string lineaEscribir = ConstruirLinea(cuadrado);
            //    escritor.WriteLine(lineaEscribir);

            //}
            var escritor = new StreamWriter(_archivo, true);

            string lineaEscribir = ConstruirLinea(triangulo);
            escritor.WriteLine(lineaEscribir);
            escritor.Close();


            listaTriangulo.Add(triangulo);

        }
        private Triangulo ConstuirCuadrado(string? lineaLeida)
        {
            //"10"
            var campos = lineaLeida.Split('|');
            //campos[0]="10"
            int lado = int.Parse(campos[0]);
            TipoDeBorde borde = (TipoDeBorde)int.Parse(campos[1]);
            Color color = (Color)int.Parse(campos[2]);
            Triangulo c = new Triangulo(lado, borde, color);
            return c;

        }

        private string ConstruirLinea(Triangulo cuadrado)
        {
            return $"{cuadrado.GetLado()}|{cuadrado.TipoDeBorde.GetHashCode()}|{cuadrado.ColorRelleno.GetHashCode()}";
        }
        /// <summary>
        /// Metodo para informar la cantidad de datos del repo
        /// </summary>
        /// <returns></returns>
        public int GetCantidad(int valorFiltro = 0)
        {
            if (valorFiltro > 0)
            {
                return listaTriangulo
                    .Count(c => c.GetLado() >= valorFiltro);
            }
            return listaTriangulo.Count;
        }
        public void Borrar(Triangulo cuadradoBorrar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Triangulo cuadradoLeido = ConstuirCuadrado(lineaLeida);
                        if (cuadradoBorrar.GetLado() != cuadradoLeido.GetLado())
                        {
                            escritor.WriteLine(lineaLeida);
                        }

                    }
                }

            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
            listaTriangulo.Remove(cuadradoBorrar);
        }

        public List<Triangulo> Filtrar(int intValor)
        {
            return listaTriangulo
                .Where(c => c.GetLado() >= intValor)
                .ToList();
        }

        public List<Triangulo> OrdenarAsc()
        {
            return listaTriangulo.OrderBy(c => c.GetLado()).ToList();
        }

        public List<Triangulo> OrdenarDesc()
        {
            return listaTriangulo.OrderByDescending(c => c.GetLado()).ToList();

        }

        public bool Existe(Triangulo cuadrado)
        {
            listaTriangulo.Clear();
            LeerDatos();
            foreach (var itemCuadrado in listaTriangulo)
            {
                if (itemCuadrado.GetLado() == cuadrado.GetLado() &&
                    itemCuadrado.ColorRelleno == cuadrado.ColorRelleno &&
                    itemCuadrado.TipoDeBorde == cuadrado.TipoDeBorde)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Triangulo> Filtrar(TipoDeBorde bordeFiltro)
        {
            return listaTriangulo
                .Where(c => c.TipoDeBorde == bordeFiltro).ToList();
        }
    }
}

