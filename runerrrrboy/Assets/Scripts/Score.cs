using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public int bestScore;
    public Text scoreText;
    public Text bestText;
    public int scorebest;
    public Text bestScoreText;

    public GameObject sound;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        bestText.text = "Best score: " + PlayerPrefs.GetInt("Best score: ", 0).ToString();
        bestScoreText.text = "Best score: " + PlayerPrefs.GetInt("Best score: ", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();

        if(score > PlayerPrefs.GetInt("Best score: ", 0))
        {
            PlayerPrefs.SetInt("Best score: ", bestScore);
            bestText.text = "Best score: " + bestScore;
        }

        else if(score > PlayerPrefs.GetInt("Best score: ", 0))
        {
            PlayerPrefs.SetInt("Best score: ", scorebest);
            bestScoreText.text = "Best score: " + scorebest;
        }
        //bestText.text = "Best score: " + bestScore;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Score")
        {
            GameObject soundss =  Instantiate(sound, transform.position, Quaternion.identity);
            Destroy(soundss, 3);
            score++;
            bestScore++;
            
           
        }
    }
}
