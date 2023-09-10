using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LivesManager : MonoBehaviour
{
	public int currentLives = 3;
	
	public TMP_Text nyawa;
	public void LoseLife()
	{
		nyawa.text = currentLives.ToString();
		currentLives -= 1;
		if(currentLives < 1)
		{
			SceneManager.LoadScene("gameOver");
		}
	}
 
}
