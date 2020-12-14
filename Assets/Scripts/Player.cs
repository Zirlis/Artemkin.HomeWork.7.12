using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField] private float speed = 10;
	[SerializeField] private float backSpeed = -10;

	void Start()
	{
		
	}

	
	void Update()
	{
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(transform.forward * Time.deltaTime * speed);
		}

		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(transform.forward * Time.deltaTime * backSpeed);
		}

		if (Input.GetKey(KeyCode.A))
		{
			transform.Rotate(0, -1, 0);
		}

		if (Input.GetKey(KeyCode.D))
		{
			transform.Rotate(0, 1, 0);
		}
	}
}
