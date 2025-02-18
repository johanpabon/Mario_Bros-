using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    // Variables del juego
    public int Score { get; private set; } // Puntuación del jugador
    public float TimeElapsed { get; private set; } // Tiempo transcurrido en el nivel
    public int Lives { get; private set; } // Vidas del jugador

    private void Awake()
    {
        // Implementación del Singleton
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
        Lives = 3; // Puedes ajustar el número de vidas
    }

    private void Update()
    {
        // Actualiza el tiempo transcurrido
        TimeElapsed += Time.deltaTime;
    }

    // Método para aumentar la puntuación
    public void AddScore(int points)
    {
        Score += points;
        Debug.Log($"Puntuación actual: {Score}");
    }

    // Método para restar vidas
    public void LoseLife()
    {
        Lives--;
        Debug.Log($"Vidas restantes: {Lives}");

        if (Lives <= 0)
        {
            GameOver();
        }
    }

    // Método para manejar el fin del juego
    private void GameOver()
    {
        Debug.Log("¡Game Over!");
        // Aquí puedes cargar una escena de Game Over o reiniciar el nivel
    }
}