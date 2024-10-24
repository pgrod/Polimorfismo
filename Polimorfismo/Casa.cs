namespace Polimorfismo
{
    public class Casa : Inmueble
    {
        public void Vender(string tipoInmueble) 
        {
            Console.WriteLine($"Casa de tipo {tipoInmueble}, con ubicación en {Ubicacion}, con un área de {AreaTerreno} ha sido vendido por el precio de {precio}");
        }
    }
}
