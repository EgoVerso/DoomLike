using System.Collections;
using UnityEngine;
using TMPro;

public class Slow2 : MonoBehaviour
{
    public TextMeshProUGUI textComponent; // Componente del segundo texto
    public float revealSpeed = 0.05f; // Velocidad de revelado

    public void ActivateAndRevealText()
    {
        textComponent.gameObject.SetActive(true); // Activa el segundo texto
        StartCoroutine(RevealText()); // Comienza a revelar el texto lentamente
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
    }
}
