using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public Transform personaje; 
    public float offsetX; // Ajuste horizontal para la posición de la cámara

    private void Update()
    {
        // Verifica si el personaje está asignado
        if (personaje != null)
        {
            // Actualiza la posición de la cámara en el eje X
            transform.position = new Vector3(personaje.position.x + offsetX, transform.position.y, transform.position.z);
        }
       
    }
}