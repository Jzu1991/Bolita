using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    public void comenzarnivel(string nivel)
    {
        SceneManager.LoadScene(nivel);
        Debug.Log("Le dio a jugar");
    }


    public void salir()
    {
        Application.Quit();
        Debug.Log("Salio del juego");
    }
}
