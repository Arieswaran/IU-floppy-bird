using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;

    private void Start() {
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver() {
        AnimationHelper.OpenPopupAnimation(gameOverCanvas.transform,delegate(){
            Time.timeScale = 0;
        });
    }

    public void Restart() {
        ScoreController.instance.ResetScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
