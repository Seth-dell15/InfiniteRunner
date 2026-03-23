using UnityEngine;
using UnityEngine.SceneManagement; // Obligatoire pour recharger la scène

public class GameOver : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // On cherche le ScoreManager pour arrêter le chrono
            FindObjectOfType<ScoreManager>().StopScore();

            // On peut ajouter un petit délai avant de recharger pour voir son score final
            Invoke("Reload", 0.5f);
        }
    }

    void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}