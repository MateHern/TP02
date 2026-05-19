namespace tp2.Models;

public class Receta
{
    public string? NombreCocinero { get; set; }
    public DateTime FechaDeNacimiento { get; set; }
    public string? TipoComida { get; set; }
    public int Presupuesto { get; set; }
    public int CantidadPersonas { get; set; }

    public int CalcularEdad()
    {
        int edad = DateTime.Today.Year - FechaDeNacimiento.Year;
        if (FechaDeNacimiento.Month > DateTime.Today.Month)
        {
            edad = edad - 1;
        }
        if (FechaDeNacimiento.Month == DateTime.Today.Month && FechaDeNacimiento.Day > DateTime.Today.Day)
        {
            edad = edad - 1;
        }
        return edad;
    }

    public string DeterminarPlato()
    {
        if (TipoComida == "Caliente" && Presupuesto < 3000)
        {
            return "Fideos con manteca";

        }

        if (TipoComida == "Caliente" && Presupuesto >= 3000 && Presupuesto <= 7000)
        {
            return "Arroz con verduras salteadas";
        }
        if (TipoComida == "Caliente" && Presupuesto > 7000)
        {

            return "Pollo al horno con guarnicion";
        }
        if (TipoComida == "Fría" && Presupuesto < 3000)
        {
            return "Ensalada simple";
        }
        if (TipoComida == "Fría" && Presupuesto >= 3000 && Presupuesto <= 7000)
        {
            return "Ensalada completa con proteina";
        }
        if (TipoComida == "Fría" && Presupuesto > 7000)
        {
            return "Tabla de fiambres y quesos";


        }
        return "Sin plato";
    }

    public int CalcularTiempo()
    {
        if (TipoComida == "Caliente" && CantidadPersonas <= 3)
        {
            return 20;
        }
        if (TipoComida == "Caliente" && CantidadPersonas >= 4 && CantidadPersonas <= 7)
        {
            return 40;
        }
        if (TipoComida == "Caliente" && CantidadPersonas >= 8)
        {

            return 80;
        }

        if (TipoComida == "Fría" && CantidadPersonas <= 3)
        {
            return 10;
        }
        if (TipoComida == "Fría" && CantidadPersonas >= 4 && CantidadPersonas <= 7)
        {
            return 20;
        }
        if (TipoComida == "Fría" && CantidadPersonas >= 8)
        {
            return 40;
        }
        return 0;
    }

    public string DeterminarDificultad()
    {
        if (Presupuesto < 3000 && CantidadPersonas <= 3)
        {
            return "Principiante";
        }
        if (Presupuesto < 3000 && CantidadPersonas >= 4)
        {
            return "Intermedio";
        }
        if (Presupuesto >= 3000 && Presupuesto <= 7000)
        {
            return "Intermedio";
        }
        if (Presupuesto > 7000 && CantidadPersonas <= 7)
        {
            return "Intermedio";
        }
        if (Presupuesto > 7000 && CantidadPersonas >= 8)
        {
            return "Avanzado";
        }
        return "Principiante";
    }

    public string GenerarSaludo()
    {
        int horaActual = DateTime.Now.Hour;
        if (horaActual >= 6 && horaActual < 12)
        {
            return "Buenos días";
        }
        else if (horaActual >= 12 && horaActual < 20)
        {
            return "Buenas tardes";
        }
        else
        {
            
            return "Buenas noches";
        }
    }
}