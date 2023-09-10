using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void ChangeSceneMainMenu()
	{
		SceneManager.LoadScene("Main Menu");
	}
	public void ChangeSceneGameplay()
	{
		SceneManager.LoadScene("Gameplay");
	}
}
