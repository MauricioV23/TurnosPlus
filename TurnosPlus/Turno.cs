public class Turno
{
    public int Numero { get; set; }
    public string Estado { get; set; }

    public Turno(int numero)
    {
        Numero = numero;
        Estado = "Pendiente";
    }
}
