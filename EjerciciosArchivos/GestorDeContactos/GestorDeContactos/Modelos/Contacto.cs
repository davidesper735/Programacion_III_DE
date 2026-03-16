namespace GestorDeContactos.Modelos
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public string ToCSV() => $"{Nombre};{Telefono};{Correo}";
    }
}
