using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
	public TMP_Text scoreText;
	public int currentScore; 
	private int nextScene;
	
	public void ChangeScore(int points)
	{
		currentScore += points;
		scoreText.text = currentScore.ToString();
		nextScene = SceneManager.GetActiveScene().buildIndex+1;
		if (currentScore > 95)
		{
			SceneManager.LoadScene(nextScene);
		}
	}
}
