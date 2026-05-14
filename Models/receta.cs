public class receta 
{
public string nombreCocinero{get;set;}
public DateTime fechaDeNacimiento{get;set;}
public string tipoComida{get;set;}
public int presupuesto{get;set;}
public int cantidadPersonas{get;set;}

public int CalcularEdad(){
int edad =  DateTime.Today.Year - fechaDeNacimiento.Year;
if  (fechaDeNacimiento.Month > DateTime.Today.Month )
{
    edad = edad-1;
} 
if (fechaDeNacimiento.Month= DateTime.Today.Month && fechaDeNacimiento.Day > DateTime.Today.Day)
{
    edad = edad-1;
}
return edad;
}
public string DeterminarPlato()
{
    string plato;
    if (tipoComida == "caliente" && presupuesto<3000)
    {
        plato = "Fideos Con Manteca";
        return plato;
    }
    if (tipoComida == "caliente" && (presupuesto<7000 && presupuesto>3000))
    {
        plato = "Arroz con verduras salteadas";
        return plato;
    }
    if (tipoComida == "caliente" && presupuesto>7000)
    {
        plato = "Pollo Al horno con guarnicion";
        return plato;
    }
    if (tipoComida == "fria" && presupuesto<3000)
    {
        plato = "ensalada simple";
        return plato;
    }
    if (tipoComida == "fria" && (presupuesto>3000 && presupuesto<7000))
    {
        plato = "Ensalada completa con proteína";
        return plato;
    }
    if (tipoComida == "fria" && presupuesto>7000)
    {
        plato = "Tabla de fiambres y quesos";
        return plato;
    }
    

}
public int CalcularTiempo()
{
    int tiempoestimado;
    if (tipoComida == "Caliente" && cantidadPersonas=1)
    {
        tiempoestimado = 20;
        return tiempoestimado;
    }
    if (tipoComida == "Caliente" && (cantidadPersonas>=2 && cantidadPersonas<=3))
    {
        tiempoestimado= 20;
        return tiempoestimado;
    }
    if (tipoComida == "Caliente" && (cantidadPersonas>=4 && cantidadPersonas<=7))
    {
        tiempoestimado = 40;
        return tiempoestimado;
    }
    if (tipoComida == "Caliente" && cantidadPersonas>=8)
    {
        tiempoestimado = 80;
        return tiempoestimado;
    }  
    if (tipoComida == "Fria" && (cantidadPersonas>=1 && cantidadPersonas<=3 ))
    {
        tiempoestimado = 10;
        return tiempoestimado;
    }
    if (tipoComida == "Fria" && (cantidadPersonas>=4 && cantidadPersonas<=7))
    {
        tiempoestimado= 20;
        return tiempoestimado;
    }
    if (tipoComida == "Fria" && cantidadPersonas>=8)
    {
        tiempoestimado = 40;
        return tiempoestimado;
    }


}
public string DeterminarDificultad(){
    string dificultad;
    if ((presupuesto < 3000)  && (cantidadPersonas>=1 && cantidadPersonas <= 3))
    {
        dificultad = "Principiante";
        return dificultad;
    }
    if ((presupuesto < 3000)  && (cantidadPersonas>=4 && cantidadPersonas <= 7))
    {
        dificultad = "intermedio";
        return dificultad;
    }if ((presupuesto > 3000 && presupuesto < 7000)  && (cantidadPersonas>=1 && cantidadPersonas <= 3))
    {
        dificultad = "intermedio";
        return dificultad;
    }if ((presupuesto > 3000 && presupuesto < 7000) && (cantidadPersonas>=4))
    {
        dificultad = "intermedio";
        return dificultad;
    }

    if ((presupuesto > 7000 ) && (cantidadPersonas>1 && cantidadPersonas<7))
    {
        dificultad = "intermedio";
        return dificultad;
    }if ((presupuesto > 7000 ) && (cantidadPersonas>= 8))
    {
        dificultad = "avanzado";
        return dificultad;
    }


   
}
public string GenerarSaludo(){
    int horaActual= DateTime.Now.Hour;
    if (horaActual >= 6 && horaActual < 12)
    {
        return "Buenos días ";
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






