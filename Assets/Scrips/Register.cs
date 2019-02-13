using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;

public class Register : MonoBehaviour {
    public GameObject usernameOrEmail;
    public GameObject name;
    public GameObject age;
    public GameObject password;
    public GameObject confPassword;
    public Text errorusuarioname;
    public Text errorname;
    public Text errorage;
    public Text errorpassword;
    public Text errorconfpass;
    private string UsernameOrEmail;
    private string Name;
    private int Age;
    private string Password;
    private string ConfPassword;
    private string form;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (usernameOrEmail.GetComponent<InputField>().isFocused)
            {
                name.GetComponent<InputField>().Select();
            }
            if (name.GetComponent<InputField>().isFocused)
            {
                age.GetComponent<InputField>().Select();
            }
            if (age.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }
            if (password.GetComponent<InputField>().isFocused)
            {
                confPassword.GetComponent<InputField>().Select();
            }
            if (confPassword.GetComponent<InputField>().isFocused)
            {
                usernameOrEmail.GetComponent<InputField>().Select();
            }
        }
    }

    public void SaveUser()
    {
        errorusuarioname.text = "";
        errorname.text = "";
        errorage.text = "";
        errorpassword.text = "";
        errorconfpass.text="";
        bool UN = false;
        bool N = false;
        bool A = false;
        bool PW = false;
        bool CPW = false;

        UsernameOrEmail = usernameOrEmail.GetComponent<InputField>().text;
        Name = name.GetComponent<InputField>().text;
        Age = int.Parse(age.GetComponent<InputField>().text);
        Password = password.GetComponent<InputField>().text;
        ConfPassword = confPassword.GetComponent<InputField>().text;


        //Validaciones Temporales (Malas)
        if (UsernameOrEmail != "")
        {
            if (!System.IO.File.Exists(Application.persistentDataPath + "/" + UsernameOrEmail + ".txt"))
            {
                UN = true;
            }
            else
            {
                errorusuarioname.text="El usuario ya existe.";
            }
        }
        else
        {
            errorusuarioname.text="El campo Usuario o Email está vacio.";
        }

        if (Name != "")
            N = true;
        else
            errorname.text="El campo Nombre está vacio.";
        if (Age != null)
            N = true;
        else
            errorage.text = "El campo Edad esta vacio";

        if (Age > 0 && Age < 99)
            A = true;
        else
            errorage.text="Edad Incorrecta.";

        if (Password != "")
        {
            if (Password.Length > 5)
                PW = true;
            else
                errorpassword.text="La contraseña debe tener al menos 6 caracteres.";
        }
        else
            errorpassword.text="El campo Contraseña está vacio.";

        if (ConfPassword != "")
        {
            if (ConfPassword == Password)
                CPW = true;
            else
                errorconfpass.text="Las contraseñas no son iguales.";
        }
        else
            errorconfpass.text="El campo Confirmar Contraseña está vacio.";

        if (UN == true && N == true && A == true && PW == true && CPW == true)
        {
            bool Clear = true;
            int i = 1;
            foreach (char c in Password)
            {
                if (Clear)
                {
                    Password = "";
                    Clear = false;
                }
                i++;
                char Encrypted = (char)(c * i);
                Password += Encrypted.ToString();
            }
            form = (UsernameOrEmail + Environment.NewLine + Name + Environment.NewLine + Age + Environment.NewLine + Password + Environment.NewLine + 0 + Environment.NewLine + 0 + Environment.NewLine );
            System.IO.File.WriteAllText(Application.persistentDataPath + "/" + UsernameOrEmail + ".txt", form);
            usernameOrEmail.GetComponent<InputField>().text = "";
            name.GetComponent<InputField>().text = "";
            age.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";
            confPassword.GetComponent<InputField>().text = "";
            SceneManager.LoadScene("Login");
        }
    }
}
