using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Redirect : MonoBehaviour {

    public void GoToRegister()
    {
        SceneManager.LoadScene("Register");
    }

    public void GoToLogin()
    {
        SceneManager.LoadScene("Register");
    }
}
