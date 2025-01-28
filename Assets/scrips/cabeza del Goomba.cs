using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabezadelGoomba : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verificar si Mario toca la cabeza del Goomba
        movement mario = collision.GetComponent<movement>();
        if (mario != null)
        {
            Debug.Log("Mario ha golpeado la cabeza del Goomba");

            // Destruir el objeto padre del "Head" (Goomba completo)
            Destroy(transform.parent.gameObject);
        }
    }
}