using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cambiar : MonoBehaviour {

   // public AudioClip[] audiopregunta;
   // public AudioClip[] aciertos;
    public GameObject[] arreglo;
    public Transform Fruta;
    public Transform Verduras;
    public Transform Original;
    public int Contador = 1;
    public int Fallos = 0;
    public int Acierto = 1;
    public Text Texto;
    private int numero=0;
    public string nombre;
    private int contadorau= 0;
    private int safe = 0;
    private string[] form;

    void Start()
    {
        arreglo[numero].transform.position = Original.position;
        arreglo[numero].transform.rotation = Original.rotation;
        Texto.text = "Que es " + arreglo[numero].name + " ?";
       // transform.GetComponent<AudioSource>().PlayOneShot(audiopregunta[contadorau]);
        contadorau++;
    }



    void Update()
    {
        
        if (numero > 8)
        {
            form = System.IO.File.ReadAllLines(Application.persistentDataPath + "/" + Perfil.NombreUsuario + ".txt");
            Fallos = Convert.ToInt32(form[4]) + Fallos;
            Perfil.Fallos = Fallos;
            form[4] = Fallos.ToString();
            Acierto = Convert.ToInt32(form[5]) + Acierto;
            Perfil.Aciertos = Acierto;
            form[5] = Acierto.ToString();
            System.IO.File.WriteAllLines(Application.persistentDataPath + "/" + Perfil.NombreUsuario + ".txt", form);
            SceneManager.LoadScene(nombre);

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                if (contadorau < 24)
                {
                    if (arreglo[numero].transform.position == Fruta.position && arreglo[numero].transform.rotation == Fruta.rotation)
                    {

                        arreglo[numero].transform.position = Verduras.position;
                        arreglo[numero].transform.rotation = Verduras.rotation;
                        Texto.text = "El " + arreglo[numero].name + " es un Verdura?";
                    //    transform.GetComponent<AudioSource>().PlayOneShot(audiopregunta[contadorau]);
                        contadorau = safe;

                    }
                    else
                        if (arreglo[numero].transform.position == Verduras.position && arreglo[numero].transform.rotation == Verduras.rotation)
                        {
                            arreglo[numero].transform.position = Original.position;
                            arreglo[numero].transform.rotation = Original.rotation;
                            Texto.text = "Que es el " + arreglo[numero].name + " ?";
                     //       transform.GetComponent<AudioSource>().PlayOneShot(audiopregunta[contadorau]);
                            contadorau++;
                        }
                        else
                            
                            {
                                arreglo[numero].transform.position = Fruta.position;
                                arreglo[numero].transform.rotation = Fruta.rotation;
                                Texto.text = "El " + arreglo[numero].name + " es una Fruta?";
                              //  transform.GetComponent<AudioSource>().PlayOneShot(audiopregunta[contadorau]);
                                contadorau++;
                            }

                }
                else
                { 
                
                }
                
               
               

            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                if (Contador <= 2)
                {

                   
                        if (arreglo[numero].transform.position == Verduras.position && arreglo[numero].transform.rotation == Verduras.rotation)
                        {
                            if (arreglo[numero].layer == 11)
                            {

                                if (arreglo[numero].name == "Elote")
                                {
                                    Texto.text = "El " + arreglo[numero].name + " son una Verdura Correcto ";
                                    Contador = 1;
                                    numero = numero + 1;
                                   // transform.GetComponent<AudioSource>().PlayOneShot(aciertos[11]);
                                    safe = safe + 4;
                                    contadorau = safe + 1;
                                    Acierto = Acierto + 1;
                                }
                                else if (arreglo[numero].name == "Tomate")
                                {
                                    Texto.text = "El " + arreglo[numero].name + " es una Verdura Correcto ";
                                    Contador = 1;
                                    numero = numero + 1;
                                   // transform.GetComponent<AudioSource>().PlayOneShot(aciertos[14]);
                                    safe = safe + 4;
                                    contadorau = safe + 1;
                                    Acierto = Acierto + 1;
                                }
                                else if (arreglo[numero].name == "Calabaza")
                                {
                                    Texto.text = "La " + arreglo[numero].name + " es una Verdura Correcto ";
                                    Contador = 1;
                                    numero = numero + 1;
                                  //  transform.GetComponent<AudioSource>().PlayOneShot(aciertos[17]);
                                    safe = safe + 4;
                                    contadorau = safe + 1;
                                    Acierto = Acierto + 1;
                                }
                            }
                            else
                            {
                                
                                if (arreglo[numero].name == "Pera")
                                {
                                    Texto.text = "La " + arreglo[numero].name + " no es una Verdura Incorrecto ";
                                    Contador = Contador + 1;
                                    Fallos = Fallos + 1;
                                   // transform.GetComponent<AudioSource>().PlayOneShot(aciertos[20]);

                                }
                                else if (arreglo[numero].name == "Banana")
                                {
                                    Texto.text = "La " + arreglo[numero].name + " no es una Verdura Incorrecto ";
                                    Contador = Contador + 1;
                                    Fallos = Fallos + 1;
                                  //  transform.GetComponent<AudioSource>().PlayOneShot(aciertos[23]);

                                }
                                else if (arreglo[numero].name == "Naranja")
                                {
                                    Texto.text = "La " + arreglo[numero].name + " no es una Verdura Incorrecto ";
                                    Contador = Contador + 1;
                                    Fallos = Fallos + 1;
                                   // transform.GetComponent<AudioSource>().PlayOneShot(aciertos[26]);
                                }
                                
                            }

                        }
                        else
                            if (arreglo[numero].transform.position == Fruta.position && arreglo[numero].transform.rotation == Fruta.rotation)
                            {
                                if (arreglo[numero].layer == 10)
                                {
                                   
                                    if (arreglo[numero].name == "Pera")
                                    {
                                        Texto.text = "La " + arreglo[numero].name + " es una Fruta Correcto ";
                                        Contador = 1;
                                        numero = numero + 1;
                                     //   transform.GetComponent<AudioSource>().PlayOneShot(aciertos[18]);
                                        safe = safe + 4;
                                        contadorau = safe + 1;
                                        Acierto = Acierto + 1;
                                    }
                                    else if (arreglo[numero].name == "Banana")
                                    {
                                        Texto.text = "La " + arreglo[numero].name + " es una Fruta Correcto ";
                                        Contador = 1;
                                        numero = numero + 1;
                                     //   transform.GetComponent<AudioSource>().PlayOneShot(aciertos[21]);
                                        safe = safe + 4;
                                        contadorau = safe + 1;
                                        Acierto = Acierto + 1;
                                    }
                                    else if (arreglo[numero].name == "Naranja")
                                    {
                                        Texto.text = "La " + arreglo[numero].name + " es una Fruta Correcto ";
                                        Contador = 1;
                                        numero = numero + 1;
                                   //     transform.GetComponent<AudioSource>().PlayOneShot(aciertos[24]);
                                        safe = safe + 4;
                                        contadorau = safe + 1;
                                        Acierto = Acierto + 1;
                                    }
                                }
                                else
                                {
                                     
                                    if (arreglo[numero].name == "Elote")
                                    {
                                        Texto.text = "El " + arreglo[numero].name + " no es una Fruta Incorrecto ";
                                        Contador = Contador + 1;
                                        Fallos = Fallos + 1;
                                    //    transform.GetComponent<AudioSource>().PlayOneShot(aciertos[0]);

                                    }
                                    else if (arreglo[numero].name == "Calabaza")
                                    {
                                        Texto.text = "La " + arreglo[numero].name + " no es una Fruta Incorrecto ";
                                        Contador = Contador + 1;
                                        Fallos = Fallos + 1;
                                     //   transform.GetComponent<AudioSource>().PlayOneShot(aciertos[3]);

                                    }
                                    else if (arreglo[numero].name == "Tomate")
                                    {
                                        Texto.text = "El " + arreglo[numero].name + " no es una Fruta Incorrecto ";
                                        Contador = Contador + 1;
                                        Fallos = Fallos + 1;
                                     //   transform.GetComponent<AudioSource>().PlayOneShot(aciertos[6]);
                                    }
                                  
                                   
                                  
                                }

                            }


                }
                else
                {
                    
                   
                        if (arreglo[numero].layer == 10)
                        {
                            if (arreglo[numero].name == "Pera")
                            {
                                Texto.text = "El " + arreglo[numero].name + " es una Fruta";
                               
                          //      transform.GetComponent<AudioSource>().PlayOneShot(aciertos[18]);
                                safe = safe + 4;
                                contadorau = safe + 1;

                            }
                            else if (arreglo[numero].name == "Banana")
                            {
                                Texto.text = "La " + arreglo[numero].name + " es una Fruta";
                               
                           //     transform.GetComponent<AudioSource>().PlayOneShot(aciertos[21]);
                                safe = safe + 4;
                                contadorau = safe + 1;

                            }
                            else if (arreglo[numero].name == "Naranja")
                            {
                                Texto.text = "La " + arreglo[numero].name + " es una Fruta";
                               
                           //     transform.GetComponent<AudioSource>().PlayOneShot(aciertos[24]);
                                safe = safe + 4;
                                contadorau = safe + 1;

                            }
                            arreglo[numero].transform.position = Fruta.position;
                            arreglo[numero].transform.rotation = Fruta.rotation;
                            Texto.text = "El " + arreglo[numero].name + " es una Fruta";

                            Contador = 1;
                            numero = numero + 1;
                          
                            
                        }
                        else
                            if (arreglo[numero].layer == 11)
                            {
                                if (arreglo[numero].name == "Elotes")
                                {
                                    Texto.text = "El " + arreglo[numero].name + " es una Verdura";
                                //    transform.GetComponent<AudioSource>().PlayOneShot(aciertos[11]);
                                    safe = safe + 4;
                                    contadorau = safe + 1;

                                }
                                else if (arreglo[numero].name == "Calabaza")
                                {
                                    Texto.text = "La " + arreglo[numero].name + " es una Verdura";
                                 //   transform.GetComponent<AudioSource>().PlayOneShot(aciertos[14]);
                                    safe = safe + 4;
                                    contadorau = safe + 1;

                                }
                                else if (arreglo[numero].name == "Tomate")
                                {
                                    Texto.text = "El " + arreglo[numero].name + " es una Verdura";
                                 //   transform.GetComponent<AudioSource>().PlayOneShot(aciertos[17]);
                                    safe = safe + 4;
                                    contadorau = safe + 1;

                                }
                                arreglo[numero].transform.position = Verduras.position;
                                arreglo[numero].transform.rotation = Verduras.rotation;
                                Texto.text = "El " + arreglo[numero].name + " es una Verdura";

                                Contador = 1;
                                numero = numero + 1;
                              
                               
                            }
                }
            }
        }
    }
}
