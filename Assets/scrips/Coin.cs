using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 10; // Puntos que da la moneda

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Entered by: " + other.name); // Esto te dirá qué objeto está colisionando con la moneda

        if (other.name == "mario") // Verifica si el objeto se llama "Mario"
        {
            GameManager.Instance.AddScore(value); // Aumenta la puntuación
            Destroy(gameObject); // Destruye la moneda
        }
    }
}