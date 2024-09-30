using System.Collections.Generic;

public class ControladorTurno
{
    private List<Turno> turnos;
    private int contadorTurnos;

    public ControladorTurno()
    {
        turnos = new List<Turno>();
        contadorTurnos = 0;
    }

    public Turno SolicitarTurno()
    {
        contadorTurnos++;
        Turno nuevoTurno = new Turno(contadorTurnos);
        turnos.Add(nuevoTurno);
        return nuevoTurno;
    }

    public Turno LlamarTurno()
    {
        Turno turno = turnos.Find(t => t.Estado == "Pendiente");
        if (turno != null)
        {
            turno.Estado = "En proceso";
        }
        return turno;
    }

    public void DevolverTurno(Turno turno)
    {
        if (turno != null)
        {
            turno.Estado = "Pendiente";
        }
    }

    public void RetenerTurno(Turno turno)
    {
        if (turno != null)
        {
            turno.Estado = "Retenido";
        }
    }
}
