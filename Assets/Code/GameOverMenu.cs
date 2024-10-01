using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    public GameObject gameOverScreen; // Assign the GameObject with the black screen, square, and text in the Inspector
    public string sceneToLoad;        // Scene to load when Escape is pressed

    private bool isGameOver = false;

    void Update()
    {
        if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene(sceneToLoad); // Load the specified scene
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                ReloadCurrentScene(); // Reload current scene
            }
        }
    }

    public void TriggerGameOver()
    {
        isGameOver = true;
        gameOverScreen.SetActive(true); // Show the game over screen
    }

    void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene
    }
}
