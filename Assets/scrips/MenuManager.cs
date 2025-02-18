using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Método público para cargar el menú principal
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); 
    }
}