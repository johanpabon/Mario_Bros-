using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaController : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Transform mario; // Referencia directa al transform de Mario

    private void Update()
    {
        if (mario != null)
        {
            float step = moveSpeed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(mario.position.x, transform.position.y), step);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Destruir a Mario si colisiona
        var marioController = collision.gameObject.GetComponent<movement>();
        if (marioController != null)
        {
            Destroy(marioController.gameObject);
        }
    }
}
