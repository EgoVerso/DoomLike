using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnCollision : MonoBehaviour
{
    // Nombre de la escena que se cargará
    public string sceneName;

    // Detecta la colisión con otro GameObject
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        // Aquí puedes agregar condiciones adicionales si es necesario
        // Por ejemplo, verificar el tag del objeto que colisiona
        if (collision.gameObject.tag == "Player") // Suponiendo que el jugador tiene el tag "Player"
        {
            Debug.Log("Player detected. Loading scene: " + sceneName);
            SceneManager.LoadScene(sceneName);
        }
    }
}
