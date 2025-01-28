using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondo : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadMovimiento;
    [SerializeField] private Rigidbody2D jugadorRB; // Ahora se asigna directamente desde el inspector
    private Vector2 offset;
    private Material material;

    private void Awake()
    {
        // Obtenemos el material del SpriteRenderer
        material = GetComponent<SpriteRenderer>().material;
    }

    private void Update()
    {
        // Calculamos el desplazamiento del fondo basado en la velocidad del jugador
        offset = jugadorRB.velocity.x * 0.1f * velocidadMovimiento * Time.deltaTime;

        // Actualizamos la posición del material para crear el efecto de movimiento
        material.mainTextureOffset += offset;
    }
}