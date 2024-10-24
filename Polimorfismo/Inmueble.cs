namespace Polimorfismo
{
    public class Inmueble
    {
        public string TipoInmueble { get; set; }
        public string Ubicacion {  get; set; }
        public double AreaTerreno { get; set; }
        public double precio { get; set; }

        public Inmueble() { }

        public Inmueble(string TipoInmueble, string Ubicacion, double AreaTerreno, double precio )
        {
            this.TipoInmueble = TipoInmueble;
            this.Ubicacion = Ubicacion;
            this.AreaTerreno = AreaTerreno;
            this.precio = precio;
        }

        public void Vender()
        {
            Console.WriteLine($"Inmueble de tipo {TipoInmueble}, con ubicación en {Ubicacion}, con un área de {AreaTerreno} ha sido vendido por el precio de {precio}");
        }

        public void Vender(double areaTerreno)
        {
            Console.WriteLine($"Terreno de tipo {TipoInmueble}, con ubicación en {Ubicacion}, con un área de {areaTerreno} ha sido vendido por el precio de {precio}");
        }

        public void Vender(double areaTerreno, double Precio)
        {
            Console.WriteLine($"Terreno de tipo {TipoInmueble}, con ubicación en {Ubicacion}, con un área de {AreaTerreno} ha sido vendido por el precio de {Precio}");
        }
    }
}
