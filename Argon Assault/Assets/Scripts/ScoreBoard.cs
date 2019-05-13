using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    
    int score;
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
    }

    public void ScoreHit(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = score.ToString();
    }
}
