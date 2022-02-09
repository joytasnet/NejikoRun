using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        
    }
    int CalcScore() {
        return (int)nejiko.transform.position.z;
    }
}
