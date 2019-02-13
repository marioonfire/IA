using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;

public class DatosUsuario : MonoBehaviour {

    public string UsernameOrEmail;

    private String[] Lines;
    private string DecryptedPass;
    public Text nombreU;
    public Text Edad;
    public Text nombre;
    public Text fallos;
    public Text aciertos;

    // Use this for initialization
    void Start()
    {
        nombreU.text = "Nombre de Usuario: " + Perfil.NombreUsuario;
        Edad.text = "Edad: " + Perfil.Edad.ToString();
        nombre.text = "Nombre: " + Perfil.Nombre;
        fallos.text = "Fallos: " + Perfil.Fallos.ToString();
        aciertos.text = "Aciertos: " + Perfil.Aciertos.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
