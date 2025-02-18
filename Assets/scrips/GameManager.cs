using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    // Variables del juego
    public int Score { get; private set; } // Puntuaci�n del jugador
    public float TimeElapsed { get; private set; } // Tiempo transcurrido en el nivel
    public int Lives { get; private set; } // Vidas del jugador

    private void Awake()
    {
        // Implementaci�n del Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persiste entre escenas
        }
        else
        {
            Destroy(gameObject); // Destruye cualquier duplicado
        }

        // Inicializa las variables del juego
        Score = 0;
        TimeElapsed = 0f;
        Lives = 3; // Puedes ajustar el n�mero de vidas
    }

    private void Update()
    {
        // Actualiza el tiempo transcurrido
        TimeElapsed += Time.deltaTime;
    }

    // M�todo para aumentar la puntuaci�n
    public void AddScore(int points)
    {
        Score += points;
        Debug.Log($"Puntuaci�n actual: {Score}");
    }

    // M�todo para restar vidas
    public void LoseLife()
    {
        Lives--;
        Debug.Log($"Vidas restantes: {Lives}");

        if (Lives <= 0)
        {
            GameOver();
        }
    }

    // M�todo para manejar el fin del juego
    private void GameOver()
    {
        Debug.Log("�Game Over!");
        // Aqu� puedes cargar una escena de Game Over o reiniciar el nivel
    }
}