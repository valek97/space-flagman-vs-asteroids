using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float score, points = 0;
    public Text ScoreText;

    public void ScorePoints(float points)
    {
        score += points; 
    }
    private void  FixedUpdate()
    {
        ScoreText.text = score.ToString();
    }
}
