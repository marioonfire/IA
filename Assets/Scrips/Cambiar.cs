using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cambiar : MonoBehaviour {

    public AudioClip[] audiopregunta;
    public AudioClip[] aciertos;
    public GameObject[] arreglo;
    public Transform Fruta;
    public Transform Juguetes;
    public Transform Cubiertos;
    public Transform Original;
    public Transform Espatulaespacio;
    public Transform Naranjaespacio;
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
        transform.GetComponent<AudioSource>().PlayOneShot(audiopregunta[contadorau]);
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
                if (contadorau < 36)
                {
                    if (arreglo[numero].transform.position == Juguetes.position && arreglo[numero].transform.rotation == Juguetes.rotation)
                    {

                        arreglo[numero].transform.position = Cubiertos.position;
                        arreglo[numero].transform.rotation = Cubiertos.rotation;
                        Texto.text = "El " + arreglo[numero].name + " es un Util Escolar?";
                        transform.GetComponent<AudioSource>().PlayOneShot(audiopregunta[contadorau]);
                        contadorau = safe;

                    }
                    else
                        if (arreglo[numero].transform.position == Cubiertos.position && arreglo[numero].transform.rotation == Cubiertos.rotation)
                        {
                            arreglo[numero].transform.position = Original.position;
                            arreglo[numero].transform.rotation = Original.rotation;
                            Texto.text = "Que es el " + arreglo[numero].name + " ?";
                            transform.GetComponent<AudioSource>().PlayOneShot(audiopregunta[contadorau]);
                            contadorau++;
                        }
                        else
                            if (arreglo[numero].transform.position == Fruta.position && arreglo[numero].transform.rotation == Fruta.rotation)
                            {
                                arreglo[numero].transform.position = Juguetes.position;
                                arreglo[numero].transform.rotation = Juguetes.rotation;
                                Texto.text = "El " + arreglo[numero].name + " es un Juguete?";
                                transform.GetComponent<AudioSource>().PlayOneShot(audiopregunta[contadorau]);
                                contadorau++;
                            }
                            else
                            {
                                arreglo[numero].transform.position = Fruta.position;
                                arreglo[numero].transform.rotation = Fruta.rotation;
                                Texto.text = "El " + arreglo[numero].name + " es una Fruta?";
                                transform.GetComponent<AudioSource>().PlayOneShot(audiopregunta[contadorau]);
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

                    if (arreglo[numero].transform.position == Juguetes.position && arreglo[numero].transform.rotation == Juguetes.rotation)
                    {
                        if (arreglo[numero].layer == 9)
                        {
                            
                            if (arreglo[numero].name == "Carro Rojo")
                            {
                                Texto.text = "El " + arreglo[numero].name + " es un Juguete Correcto ";
                                Contador = 1;
                                numero = numero + 1;
                                transform.GetComponent<AudioSource>().PlayOneShot(aciertos[1]);
                                safe = safe + 4;
                                contadorau = safe+1;
                                Acierto = Acierto + 1;
                            }
                            else if (arreglo[numero].name == "Osito")
                            {
                                Texto.text = "El " + arreglo[numero].name + " es un Juguete Correcto ";
                                Contador = 1;
                                numero = numero + 1;
                                transform.GetComponent<AudioSource>().PlayOneShot(aciertos[4]);
                                safe = safe + 4;
                                contadorau = safe + 1;
                                Acierto = Acierto + 1;
                            }
                            else if (arreglo[numero].name == "Barbie")
                            {
                                Texto.text = "La " + arreglo[numero].name + " es un Juguete Correcto ";
                                Contador = 1;
                                numero = numero + 1;
                                transform.GetComponent<AudioSource>().PlayOneShot(aciertos[7]);
                                safe = safe + 4;
                                contadorau = safe + 1;
                                Acierto = Acierto + 1;
                            }
                        }
                        else
                        {
                            if (arreglo[numero].name == "Plumas")
                            {
                                Texto.text = "Las " + arreglo[numero].name + " no son un Juguete ";
                                Contador = Contador + 1;
                                Fallos = Fallos + 1;
                                transform.GetComponent<AudioSource>().PlayOneShot(aciertos[10]);

                            }
                            else if (arreglo[numero].name == "Borrador")
                            {
                                Texto.text = "El " + arreglo[numero].name + " no es un Juguete ";
                                Contador = Contador + 1;
                                Fallos = Fallos + 1;
                                transform.GetComponent<AudioSource>().PlayOneShot(aciertos[13]);

                            }
                            else if (arreglo[numero].name == "sacapuntas")
                            {
                                Texto.text = "El " + arreglo[numero].name + " no es un Juguete ";
                                Contador = Contador + 1;
                                Fallos = Fallos + 1;
                                transform.GetComponent<AudioSource>().PlayOneShot(aciertos[16]);
                            }
                            else
                            if (arreglo[numero].name == "Pera")
                            {
                                Texto.text = "El " + arreglo[numero].name + " no es un Juguete ";
                                Contador = Contador + 1;
                                Fallos = Fallos + 1;
                                transform.GetComponent<AudioSource>().PlayOneShot(aciertos[19]);

                            }
                            else if (arreglo[numero].name == "banana")
                            {
                                Texto.text = "El " + arreglo[numero].name + " no es un Juguete ";
                                Contador = Contador + 1;
                                Fallos = Fallos + 1;
                                transform.GetComponent<AudioSource>().PlayOneShot(aciertos[22]);

                            }
                            else if (arreglo[numero].name == "Naranja")
                            {
                                Texto.text = "El " + arreglo[numero].name + " no es un Juguete ";
                                Contador = Contador + 1;
                                Fallos = Fallos + 1;
                                transform.GetComponent<AudioSource>().PlayOneShot(aciertos[25]);
                            }
                          
                        }


                    }
                    else
                        if (arreglo[numero].transform.position == Cubiertos.position && arreglo[numero].transform.rotation == Cubiertos.rotation)
                        {
                            if (arreglo[numero].layer == 11)
                            {

                                if (arreglo[numero].name == "Plumas")
                                {
                                    Texto.text = "Las " + arreglo[numero].name + " son un Util Escolar Correcto ";
                                    Contador = 1;
                                    numero = numero + 1;
                                    transform.GetComponent<AudioSource>().PlayOneShot(aciertos[11]);
                                    safe = safe + 4;
                                    contadorau = safe + 1;
                                    Acierto = Acierto + 1;
                                }
                                else if (arreglo[numero].name == "Borrador")
                                {
                                    Texto.text = "El " + arreglo[numero].name + " es un Util Escolar Correcto ";
                                    Contador = 1;
                                    numero = numero + 1;
                                    transform.GetComponent<AudioSource>().PlayOneShot(aciertos[14]);
                                    safe = safe + 4;
                                    contadorau = safe + 1;
                                    Acierto = Acierto + 1;
                                }
                                else if (arreglo[numero].name == "sacapuntas")
                                {
                                    Texto.text = "El " + arreglo[numero].name + " es un Util Escolar Correcto ";
                                    Contador = 1;
                                    numero = numero + 1;
                                    transform.GetComponent<AudioSource>().PlayOneShot(aciertos[17]);
                                    safe = safe + 4;
                                    contadorau = safe + 1;
                                    Acierto = Acierto + 1;
                                }
                            }
                            else
                            {
                                if (arreglo[numero].name == "Carro Rojo")
                                {
                                    Texto.text = "El " + arreglo[numero].name + " no es un Util Escolar Incorrecto ";
                                    Contador = Contador + 1;
                                    Fallos = Fallos + 1;
                                    transform.GetComponent<AudioSource>().PlayOneShot(aciertos[2]);

                                }
                                else if (arreglo[numero].name == "Osito")
                                {
                                    Texto.text = "El " + arreglo[numero].name + " no es un Util Escolar Incorrecto ";
                                    Contador = Contador + 1;
                                    Fallos = Fallos + 1;
                                    transform.GetComponent<AudioSource>().PlayOneShot(aciertos[5]);

                                }
                                else if (arreglo[numero].name == "Barbie")
                                {
                                    Texto.text = "La " + arreglo[numero].name + " no es un Util Escolar Incorrecto ";
                                    Contador = Contador + 1;
                                    Fallos = Fallos + 1;
                                    transform.GetComponent<AudioSource>().PlayOneShot(aciertos[8]);
                                }
                                else
                                if (arreglo[numero].name == "Pera")
                                {
                                    Texto.text = "La " + arreglo[numero].name + " no es un Util Escolar Incorrecto ";
                                    Contador = Contador + 1;
                                    Fallos = Fallos + 1;
                                    transform.GetComponent<AudioSource>().PlayOneShot(aciertos[20]);

                                }
                                else if (arreglo[numero].name == "banana")
                                {
                                    Texto.text = "La " + arreglo[numero].name + " no es un Util Escolar Incorrecto ";
                                    Contador = Contador + 1;
                                    Fallos = Fallos + 1;
                                    transform.GetComponent<AudioSource>().PlayOneShot(aciertos[23]);

                                }
                                else if (arreglo[numero].name == "Naranja")
                                {
                                    Texto.text = "La " + arreglo[numero].name + " no es un Util Escolar Incorrecto ";
                                    Contador = Contador + 1;
                                    Fallos = Fallos + 1;
                                    transform.GetComponent<AudioSource>().PlayOneShot(aciertos[26]);
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
                                        transform.GetComponent<AudioSource>().PlayOneShot(aciertos[18]);
                                        safe = safe + 4;
                                        contadorau = safe + 1;
                                        Acierto = Acierto + 1;
                                    }
                                    else if (arreglo[numero].name == "banana")
                                    {
                                        Texto.text = "La " + arreglo[numero].name + " es una Fruta Correcto ";
                                        Contador = 1;
                                        numero = numero + 1;
                                        transform.GetComponent<AudioSource>().PlayOneShot(aciertos[21]);
                                        safe = safe + 4;
                                        contadorau = safe + 1;
                                        Acierto = Acierto + 1;
                                    }
                                    else if (arreglo[numero].name == "Naranja")
                                    {
                                        Texto.text = "La " + arreglo[numero].name + " es una Fruta Correcto ";
                                        Contador = 1;
                                        numero = numero + 1;
                                        transform.GetComponent<AudioSource>().PlayOneShot(aciertos[24]);
                                        safe = safe + 4;
                                        contadorau = safe + 1;
                                        Acierto = Acierto + 1;
                                    }
                                }
                                else
                                {
                                     
                                    if (arreglo[numero].name == "Carro Rojo")
                                    {
                                        Texto.text = "El " + arreglo[numero].name + " no es una Fruta Incorrecto ";
                                        Contador = Contador + 1;
                                        Fallos = Fallos + 1;
                                        transform.GetComponent<AudioSource>().PlayOneShot(aciertos[0]);

                                    }
                                    else if (arreglo[numero].name == "Osito")
                                    {
                                        Texto.text = "El " + arreglo[numero].name + " no es una Fruta Incorrecto ";
                                        Contador = Contador + 1;
                                        Fallos = Fallos + 1;
                                        transform.GetComponent<AudioSource>().PlayOneShot(aciertos[3]);

                                    }
                                    else if (arreglo[numero].name == "Barbie")
                                    {
                                        Texto.text = "El " + arreglo[numero].name + " no es una Fruta Incorrecto ";
                                        Contador = Contador + 1;
                                        Fallos = Fallos + 1;
                                        transform.GetComponent<AudioSource>().PlayOneShot(aciertos[6]);
                                    }
                                    else
                                    if (arreglo[numero].name == "Plumas")
                                    {
                                        Texto.text = "Las " + arreglo[numero].name + " no son una Fruta Incorrecto ";
                                        Contador = Contador + 1;
                                        Fallos = Fallos + 1;
                                        transform.GetComponent<AudioSource>().PlayOneShot(aciertos[9]);

                                    }
                                    else if (arreglo[numero].name == "Borrador")
                                    {
                                        Texto.text = "El " + arreglo[numero].name + " no es una Fruta Incorrecto ";
                                        Contador = Contador + 1;
                                        Fallos = Fallos + 1;
                                        transform.GetComponent<AudioSource>().PlayOneShot(aciertos[12]);

                                    }
                                    else if (arreglo[numero].name == "sacapuntas")
                                    {
                                        Texto.text = "El " + arreglo[numero].name + " no es una Fruta Incorrecto ";
                                        Contador = Contador + 1;
                                        Fallos = Fallos + 1;
                                        transform.GetComponent<AudioSource>().PlayOneShot(aciertos[15]);
                                    }
                                   
                                  
                                }

                            }


                }
                else
                {
                    
                    if (arreglo[numero].layer == 9)
                    {
                        if (arreglo[numero].name == "Carro Rojo")
                        {
                           
                            transform.GetComponent<AudioSource>().PlayOneShot(aciertos[1]);
                            safe = safe + 4;
                            contadorau = safe + 1;

                        }
                        else if (arreglo[numero].name == "Osito")
                        {
                            Texto.text = "El " + arreglo[numero].name + " es un Juguete";
                            transform.GetComponent<AudioSource>().PlayOneShot(aciertos[4]);
                            safe = safe + 4;
                            contadorau = safe + 1;

                        }
                        else if (arreglo[numero].name == "Barbie")
                        {
                            Texto.text = "La " + arreglo[numero].name + " es un Juguete";
                            transform.GetComponent<AudioSource>().PlayOneShot(aciertos[7]);
                            safe = safe + 4;
                            contadorau = safe + 1;

                        }
                        arreglo[numero].transform.position = Juguetes.position;
                        arreglo[numero].transform.rotation = Juguetes.rotation;
                       

                        Contador = 1;
                        numero = numero + 1;
                       
                        
                    }
                    else
                        if (arreglo[numero].layer == 10)
                        {
                            if (arreglo[numero].name == "Pera")
                            {
                                Texto.text = "El " + arreglo[numero].name + " es una Fruta";
                               
                                transform.GetComponent<AudioSource>().PlayOneShot(aciertos[18]);
                                safe = safe + 4;
                                contadorau = safe + 1;

                            }
                            else if (arreglo[numero].name == "banana")
                            {
                                Texto.text = "El " + arreglo[numero].name + " es una Fruta";
                               
                                transform.GetComponent<AudioSource>().PlayOneShot(aciertos[21]);
                                safe = safe + 4;
                                contadorau = safe + 1;

                            }
                            else if (arreglo[numero].name == "Naranja")
                            {
                                Texto.text = "La " + arreglo[numero].name + " es una Fruta";
                               
                                transform.GetComponent<AudioSource>().PlayOneShot(aciertos[24]);
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
                                if (arreglo[numero].name == "Plumas")
                                {
                                    Texto.text = "Las " + arreglo[numero].name + " son utiles Escolar";
                                    transform.GetComponent<AudioSource>().PlayOneShot(aciertos[11]);
                                    safe = safe + 4;
                                    contadorau = safe + 1;

                                }
                                else if (arreglo[numero].name == "Borrador")
                                {
                                    Texto.text = "El " + arreglo[numero].name + " es un util Escolar";
                                    transform.GetComponent<AudioSource>().PlayOneShot(aciertos[14]);
                                    safe = safe + 4;
                                    contadorau = safe + 1;

                                }
                                else if (arreglo[numero].name == "sacapuntas")
                                {
                                    Texto.text = "El " + arreglo[numero].name + " es un util Escolar";
                                    transform.GetComponent<AudioSource>().PlayOneShot(aciertos[17]);
                                    safe = safe + 4;
                                    contadorau = safe + 1;

                                }
                                arreglo[numero].transform.position = Cubiertos.position;
                                arreglo[numero].transform.rotation = Cubiertos.rotation;
                                Texto.text = "El " + arreglo[numero].name + " es un util Escolar";

                                Contador = 1;
                                numero = numero + 1;
                              
                               
                            }
                }
            }
        }
    }
}
