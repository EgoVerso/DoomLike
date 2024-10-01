using System.Collections; // Para usar IEnumerator y Coroutines
using UnityEngine;
using UnityEngine.SceneManagement; // Para el manejo de escenas

public class A1CS : MonoBehaviour
{
    public AudioSource audioSource; // Asigna el AudioSource en el Inspector
    public string nextSceneName; // Nombre de la próxima escena a cargar

    void Start()
    {
        StartCoroutine(CheckIfAudioFinished());
    }

    IEnumerator CheckIfAudioFinished()
    {
        // Espera hasta que el audio haya terminado de reproducirse
        while (audioSource.isPlaying)
        {
            yield return null;
        }

        // Espera 10 segundos después de que el audio termine
        yield return new WaitForSeconds(2f);

        // Cambia a la siguiente escena
        SceneManager.LoadScene(nextSceneName);
    }
}
