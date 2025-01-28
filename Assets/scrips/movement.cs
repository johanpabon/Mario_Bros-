using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento
    public float jumpForce = 10f; // Fuerza del salto
    public LayerMask groundLayer; // Selección de la capa "Ground"
    public Transform spawnPoint; // Punto de reaparición


    private Rigidbody2D rb;
    private bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      
    }

    private void Update()
    {
        // Movimiento horizontal
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // Detectar si está tocando el suelo con un Raycast
        CheckIfGrounded();

        // Salto
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0); // Asegura que se reinicie la velocidad en Y
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void CheckIfGrounded()
    {
        // Origen del Raycast un poco por debajo del personaje
        Vector2 rayOrigin = (Vector2)transform.position + Vector2.down * 0.1f;
        float rayLength = 0.2f;

        // Raycast hacia abajo para verificar el suelo
        RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.down, rayLength, groundLayer);
        isGrounded = hit.collider != null;

        // Dibujar el raycast en la ventana de escena para depuración
        Debug.DrawRay(rayOrigin, Vector2.down * rayLength, isGrounded ? Color.green : Color.red);
    }
    public void Respawn()
    {
        Debug.Log("Reapareciendo a Mario"); // Mensaje para depuración
        transform.position = spawnPoint.position; // Coloca a Mario en el SpawnPoint
        rb.velocity = Vector2.zero; // Reinicia la velocidad
    }

}