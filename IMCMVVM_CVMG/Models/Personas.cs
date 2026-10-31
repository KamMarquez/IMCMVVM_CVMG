namespace IMCMVVM_CVMG.Models
{
	public class Personas
	{
		//Datos necesarios para el cálculo
		public double Peso { get; set; }
		public double Estatura { get; set; }

		//Método que devuelve el IMC de la persona
		public double CalcularIMC()
		{
			return Peso / (Estatura * Estatura);
		}
	}
}