namespace Polimorfismo
{
    public class Terreno : Inmueble
    {
        public Terreno() { }
        public Terreno(string TipoInmueble) {
        this.TipoInmueble = TipoInmueble;
        }

        public void Vender(string tipoInmueble, string ubicacion, double areaTerreno, double Precio)
        {
            Console.WriteLine($"Terreno de tipo {tipoInmueble}, con ubicación en {ubicacion}, con un área de {areaTerreno} ha sido vendido por el precio de {Precio}");
        }
    }
}
