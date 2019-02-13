using System.Collections;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour {



    public GameObject usernameOrEmail;
    public GameObject password;
    public string archivo;
    private string UsernameOrEmail;
    private string Password;
    private String[] Lines;
    private string DecryptedPass;

    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TryLogin()
    {
        bool UN = false;
        bool PW = false;

        UsernameOrEmail = usernameOrEmail.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;

        if (UsernameOrEmail != "")
        {
            if (Password != "")
            {
                if (System.IO.File.Exists(Application.persistentDataPath + "/" + UsernameOrEmail + ".txt"))
                {
                    UN = true;
                    Lines = System.IO.File.ReadAllLines(Application.persistentDataPath + "/" + UsernameOrEmail + ".txt");
                    int i = 1;
                    foreach (char c in Lines[3])
                    {
                        i++;
                        char Decrypted = (char)(c / i);
                        DecryptedPass += Decrypted.ToString();
                    }
                    if (Password == DecryptedPass)
                        PW = true;
                    else
                        Debug.LogWarning("Contraseña Incorrecta.");
                }
                else
                {
                    Debug.LogWarning("El usuario no existe.");
                }
            }
            else
                Debug.LogWarning("El campo Contraseña está vacio.");
        }
        else
        {
            Debug.LogWarning("El campo Usuario o Email está vacio.");
        }

        if (UN == true && PW == true)
        {
            usernameOrEmail.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";
            Perfil.NombreUsuario = Lines[0];
            Perfil.Nombre = Lines[1];
            Perfil.Edad = int.Parse(Lines[2]);
            Perfil.Fallos = int.Parse(Lines[4]);
            Perfil.Aciertos = int.Parse(Lines[5]);
            SceneManager.LoadScene("Inicio");
        }

    }
}
