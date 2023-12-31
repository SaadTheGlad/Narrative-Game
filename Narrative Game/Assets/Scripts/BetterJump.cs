﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour
{
	public float fallMultiplier = 2.5f;
	public float lowJumpMultiplier = 2f;

	Rigidbody2D rb;

	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();

	}
	//private void FixedUpdate()
	//{
	//	if(rb.velocity.y < 0)
	//	{
	//		rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
	//	}
	//	else if(rb.velocity.y > 0 && !Input.GetKeyDown(KeyCode.Space))
	//	{
	//		rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
	//	}
	//}
	private void FixedUpdate()
	{
		if (rb.velocity.y < 0)
		{
			rb.gravityScale = fallMultiplier;
		}
		else if (rb.velocity.y > 0 && !Input.GetKeyDown(KeyCode.Space))
		{
			rb.gravityScale = lowJumpMultiplier;
		}
		else
		{
			rb.gravityScale = 1f;
		}
	}
}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class BetterJump : MonoBehaviour
//{
//    public float fallMultiplier = 2.5f;
//    public float lowJumpMultiplier = 2f;
//	public float startJumpMultiplier = 2f;

//    Rigidbody2D rb;
//	public float jumpVelocity;





//	private void Awake()
//	{
//		rb = GetComponent<Rigidbody2D>();

//	}

//	private void Update()
//	{
//		if(rb.velocity.y < 0)
//		{
//			rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
//		} else if(rb.velocity.y > 0 && !Input.GetButton("Jump"))
//		{
//			rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
//		} else if(rb.velocity.y > 0 && Input.GetButton("Jump"))
//		{
//			rb.velocity += Vector2.up * Physics2D.gravity.y * (startJumpMultiplier - 1) * Time.deltaTime;

//		}
//	}


//}
