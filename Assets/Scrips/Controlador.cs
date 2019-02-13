using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador : MonoBehaviour {

    public void irInicio(string nombre)
    {
        
        SceneManager.LoadScene(nombre);
    }
}
