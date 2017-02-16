using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public Text scoreText;

	private int score1;
	private int score2;

	public Text winScreen;
	public int scoreTarget;

	public GameObject ball;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if(score1 >= scoreTarget)
		{
			winScreen.gameObject.SetActive(true);
			winScreen.text = "Player 1 Wins";
			ball.SetActive(false);
		}

		if(score2 >= scoreTarget)
		{
			winScreen.gameObject.SetActive(true);
			winScreen.text = "Player 2 Wins";
			ball.SetActive(false);
		}

		if(Input.GetKeyDown(KeyCode.R))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}

		if(Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene("Main Menu");
		}

	}

	public void UpdateScore(int player)
	{
		if(player == 1)
		{
			score1 += 1;
		}

		if(player == 2)
		{
			score2 += 1;
		}

		scoreText.text = score1 + " - " + score2;
	}
}