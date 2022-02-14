using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public NejikoController nejiko;
    public Text scoreText;
    public LifePanel lifePanel;
    void Update()
    {
        int score = CalcScore();
        scoreText.text = $"Score:{score}m";
        lifePanel.UpdateLife(nejiko.Life());
        if(nejiko.Life() <= 0) {
            enabled = false;
            if(PlayerPrefs.GetInt("HighScore") < score) {
                PlayerPrefs.SetInt("HighScore", score);
            }
            Invoke("ReturnToTitle", 2.0f);
        }
    }
    int CalcScore() {
        return (int)nejiko.transform.position.z;
    }
    void ReturnToTitle() {
        SceneManager.LoadScene("Title");
    }
}
