using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameEnd = false;
    public Text GameOverText;
    public Text RestartButton;
    public UpdateScore Score;
    public Text Scoretext;

    public void Start()
    {
        GameOverText.enabled = false;
        RestartButton.enabled = false;
    }


    public void GameOver()
    {
        if (gameEnd == false)
        {
            gameEnd = true;
            GameOverText.enabled = true;
            RestartButton.enabled = true;
            Score.enabled = false;
            Scoretext.enabled = false;
            GameOverText.text = "Game Over! Score: " + Scoretext.text;
        }
    }

    public void Update()
    {
        if (Input.GetKey("space"))
        {
            Restart();
        }
    }

    void Restart() 
    {
        SceneManager.LoadScene("Level1");
    }

}
