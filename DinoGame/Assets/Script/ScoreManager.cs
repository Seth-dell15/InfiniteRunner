using UnityEngine;
using TMPro; // Obligatoire pour utiliser TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    // Ajoute cette variable pour régler la vitesse (ex: 1 ou 2)
    public float scoreSpeed = 2f;

    private float score = 0f;
    private bool isAlive = true;

    void Update()
    {
        if (isAlive)
        {
            // On utilise maintenant scoreSpeed au lieu de 10f
            score += Time.deltaTime * scoreSpeed;
            scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
        }
    }

    public void StopScore()
    {
        isAlive = false;
    }
}