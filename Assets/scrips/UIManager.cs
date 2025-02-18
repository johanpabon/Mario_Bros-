using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText; 
    public Text timeText; 

    private void Update()
    {
        // Actualiza los textos con los valores del GameManager
        scoreText.text = $"Puntuación: {GameManager.Instance.Score}";
        timeText.text = $"Tiempo: {GameManager.Instance.TimeElapsed:F2}"; // Formato con 2 decimales
    }
}
