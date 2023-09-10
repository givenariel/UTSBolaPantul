using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
	private Rigidbody2D ballRB;
	private double minY = -11 ;
	public float minVelocity;
	public float maxVelocity;
	
	public LivesManager livesManager;
	
    // Start is called before the first frame update
    void Start()
    {
        ballRB = GetComponent<Rigidbody2D>();
		
		ballRB.velocity = new Vector2(0, -minVelocity);
    }

    // Update is called once per frame
    void Update()
    {
		
        if(ballRB.velocity.magnitude > maxVelocity)
		{
			ballRB.velocity = Vector2.ClampMagnitude(ballRB.velocity, maxVelocity);
		}
		
		if(ballRB.velocity.magnitude < minVelocity)
		{
			if(ballRB.velocity.y < 0)
			{
				ballRB.velocity = new Vector2(ballRB.velocity.x, -minVelocity);
			}
			if(ballRB.velocity.y > 0)
			{
				ballRB.velocity = new Vector2(ballRB.velocity.x, minVelocity);
			}
		}
		
		if(transform.position.y < minY)
		{
			livesManager.LoseLife();
			transform.position = new Vector2(0, -7);
			ballRB.velocity = new Vector2(0, -minVelocity);
		}
    }
}
