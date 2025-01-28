using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public Transform personaje; 
    public float offsetX; // Ajuste horizontal para la posici�n de la c�mara

    private void Update()
    {
        // Verifica si el personaje est� asignado
        if (personaje != null)
        {
            // Actualiza la posici�n de la c�mara en el eje X
            transform.position = new Vector3(personaje.position.x + offsetX, transform.position.y, transform.position.z);
        }
       
    }
}