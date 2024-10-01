using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera; // Arrastra tu c�mara virtual aqu�
    public float mouseSensitivity = 1f; // Ajusta la sensibilidad del mouse
    private float xRotation = 0f;

    void Start()
    {
        // Ocultar el cursor y capturarlo en la ventana del juego
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Obtener el movimiento del mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // Aplicar la rotaci�n en el eje X (vertical)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -30f, 30f); // Limitar la rotaci�n

        // Rotar la c�mara
        virtualCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotar el objeto padre de la c�mara (o el personaje)
        transform.Rotate(Vector3.up * mouseX); // Eje Y
    }

    void OnDisable()
    {
        // Liberar el cursor al deshabilitar el script
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
