using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone1 : MonoBehaviour
{
    public Transform marioTransform;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Intentamos obtener el componente "movement" de Mario
        movement mario = collision.GetComponent<movement>();
        if (mario != null)
        {
            Debug.Log("Mario ha entrado en la DeathZone");

            // Guardamos la referencia al transform de Mario si no está asignada
            if (marioTransform == null)
            {
                marioTransform = mario.transform;
            }

            // Llamamos al método Respawn de Mario
            mario.Respawn();
        }
    }

    private void Update()
    {
        // actualizamos la posición de este objeto solo en el eje X, sigiendo a Mario 
        if (marioTransform != null)
        {
            transform.position = new Vector3(marioTransform.position.x, transform.position.y, transform.position.z);
        }
    }
}