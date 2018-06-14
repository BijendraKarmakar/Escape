using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    public Text highScore;

    public void Start()
    {
        highScore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString("0");

    }


    void Update () {
        float number = player.position.z;
        scoreText.text = number.ToString("0");

        if (number > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", number);
        }

        
	}
}
