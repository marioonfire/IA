using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Perfil {

    private static string nombreUsuario, nombre;
    private static int edad, fallos,acierto,juegos;

    public static string NombreUsuario { get { return nombreUsuario; } set { nombreUsuario = value; } }
    public static string Nombre { get { return nombre; } set { nombre = value; } }
    public static int Edad { get { return edad; } set { edad = value; } }
    public static int Fallos { get { return fallos; } set { fallos = value; } }
    public static int Aciertos { get { return acierto; } set { acierto = value; } }
}
