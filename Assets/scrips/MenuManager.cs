using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // M�todo p�blico para cargar el men� principal
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); 
    }
}