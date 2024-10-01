using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Obtener la entrada horizontal y vertical
        float moveHorizontal = Input.GetAxis("Horizontal"); // A/D y flechas izquierda/derecha
        float moveVertical = Input.GetAxis("Vertical"); // W/S y flechas arriba/abajo

        // Crear un vector de movimiento
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical) * moveSpeed * Time.deltaTime;

        // Aplicar movimiento al objeto
        transform.Translate(movement);
    }
}
