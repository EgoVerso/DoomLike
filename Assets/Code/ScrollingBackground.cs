using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float scrollSpeed = 2.0f; // Velocidad del desplazamiento
    public float resetPositionX; // Posición X en la que se reseteará el fondo
    public float startPositionX; // Posición X inicial del fondo

    private void Update()
    {
        // Desplazar el fondo hacia la izquierda
        transform.position += Vector3.left * scrollSpeed * Time.deltaTime;

        // Resetear la posición cuando se sale de la pantalla
        if (transform.position.x < resetPositionX)
        {
            Vector3 newPos = new Vector3(startPositionX, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}
