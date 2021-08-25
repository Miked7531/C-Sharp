using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class GameManager : MonoBehaviour {

	[Header("Score Elements")]
	public int score;
	public int highscore;
	public Text scoreText;
	public Text highscoreText;


	[Header("GameOver")]
	public GameObject gameOverPanel;
	public Text gameOverPanelScoreText;
	public Text gameOverPanelHighScoreText;

	[Header("Sounds")]
	public AudioClip[] sliceSounds;

    public AudioClip[] bombSounds;

	private AudioSource audioSource;

	public void Awake()
    {
		//Advertisement.Initialize("4018081");
        audioSource = GetComponent<AudioSource>();
		gameOverPanel.SetActive(false);
		GetHighScore();
    }

	public void GetHighScore()
    {
		highscore = PlayerPrefs.GetInt("High Score");
		highscoreText.text = "High Score: " + highscore;
	}

	public void IncreaseScore(int points)
    {
		score += points;
		scoreText.text = score.ToString();

        if (score > highscore)
        {
			PlayerPrefs.SetInt("High Score", score);
			highscoreText.text = score.ToString();
        }
    }

	public void OnBombHit()
    {
		//Advertisement.Show();
		Time.timeScale = 0;

		gameOverPanelScoreText.text = "Score: " + score.ToString();
		gameOverPanelHighScoreText.text = "High Score: " + PlayerPrefs.GetInt("High Score").ToString();

		gameOverPanel.SetActive(true);

		Debug.Log("Bomb hit!");
    }

	public void RestartGame()
    {
		score = 0;
		scoreText.text = score.ToString();

		gameOverPanel.SetActive(false);
		

        foreach (GameObject g in GameObject.FindGameObjectsWithTag("Interactable"))
        {
			Destroy(g);
        }
		Time.timeScale = 1;
    }

    public void PlayRandomSliceSound()
    {
        AudioClip randomSound = sliceSounds[Random.Range(0, sliceSounds.Length)];
		audioSource.PlayOneShot(randomSound);
    }

    public void PlayBombSound()
    {
        AudioClip bombSound = bombSounds[Random.Range(0, bombSounds.Length)];
		audioSource.PlayOneShot(bombSound);
    }
}
