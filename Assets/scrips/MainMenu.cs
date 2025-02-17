using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Método para iniciar el juego
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene"); // Escena a cambiar 
    }

    // Método para salir del juego
    public void QuitGame()
    {
        Debug.Log("Saliendo del juego..."); 
        Application.Quit();
    }
}