using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    private int score = 0;

    [SerializeField]
    private TextMeshProUGUI scoreText;

    public static ScoreController instance;

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }


    private void Update() {
        scoreText.text = "Score: " + score;
    }

    public void AddScore(int amount = 1) {
        score += amount;
    }

    public int GetScore() {
        return score;
    }

    public void ResetScore() {
        score = 0;
    }
}
