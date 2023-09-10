using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBalok : MonoBehaviour
{
	public int pointValue;
	public ScoreManager scoreManager;
	
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnCollisionEnter2D(Collision2D collision)
	{
		scoreManager.ChangeScore(pointValue);
		Destroy(gameObject);
	}
}
