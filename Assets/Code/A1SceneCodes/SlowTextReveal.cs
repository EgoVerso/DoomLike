using System.Collections;
using UnityEngine;
using TMPro;

public class SlowTextReveal : MonoBehaviour
{
    public TextMeshProUGUI textComponent; // Componente del primer texto
    public float revealSpeed = 0.05f; // Velocidad de revelado
    public Slow2 nextTextScript; // Referencia al script Slow2 para el segundo texto

    void Start()
    {
        StartCoroutine(RevealText());
    }

    IEnumerator RevealText()
    {
        string fullText = textComponent.text; // Guarda el texto completo
        textComponent.text = ""; // Limpia el texto en pantalla

        foreach (char c in fullText)
        {
            textComponent.text += c; // Añade la siguiente letra
            yield return new WaitForSeconds(revealSpeed); // Espera según la velocidad de revelado
        }

        // Después de revelar el primer texto, activa y revela el segundo
        if (nextTextScript != null)
        {
            nextTextScript.ActivateAndRevealText();
        }
    }
}
