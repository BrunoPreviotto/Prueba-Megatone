using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Prueba_Megatone
{
    public class Celular
    {
		private string marca;
		private string modelo;
		private string caracteristicas;
		private double precio;
		public ArrayList celulares = new ArrayList();
		

		public string Nombre
        {
			get { return marca; }
			set { marca = value; }
        }

		public string Modelo
		{
			get { return modelo; }
			set { modelo = value; }
		}

		public string Caracteristicas
        {
			get { return caracteristicas; }
			set { caracteristicas = value; }
        }

		public double Precio
        {
			get { return precio; }
			set { precio = value; }
        }

        public Celular(string marca, string modelo, string caracteristicas, double precio)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.caracteristicas = caracteristicas;
            this.precio = precio;
        }

        //agrega un celular a un arraylist
		public void AgregarCelular()
		{
			ArrayList lista = new ArrayList();
			if (ValidarDatos())
			{
				celulares.Add(marca.Trim().ToLower() + "," + modelo.Trim().ToLower() + "," + caracteristicas.Trim().ToLower() + "," + Convert.ToString(precio).Trim());
			}

		}
		
		//busca un celular en un arraylis
		public void BuscarCelular(string marca, string modelo, string precio)
		{
			foreach (string c in celulares)
            {
				string[] lista = c.Split(',');
				if(lista[0].Equals(marca.Trim().ToLower()) && lista[1].Equals(modelo.Trim().ToLower()) && lista[3].Equals(precio.Trim().ToLower()))
                {
					Console.WriteLine(c.ToString());
                }
            }
		}

		//hago una pequeña validacion de los datos
		public bool ValidarDatos()
		{
			if(marca != "" && modelo != "" && caracteristicas != "" && precio != null)
            {
				return true;
            }
            else
            {
				return false;
            }
		}

		

		
	}
}
