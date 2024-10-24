namespace Polimorfismo
{
    public class Departamento : Inmueble
    {
        public void Vender(string ubicacion)
        {
            Console.WriteLine($"Departamento de tipo {TipoInmueble}, con ubicación en {ubicacion}, con un área de {AreaTerreno} ha sido vendido por el precio de {precio}");
        }
    }
}
