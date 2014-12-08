using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	/// <summary>
	/// Simply moves the current game object
	/// </summary>
		// 1 - Designer variables
		
		/// <summary>
		/// Object speed
		/// </summary>
		public Vector2 speed = new Vector2(4, 4);
		
		/// <summary>
		/// Moving direction
		/// </summary>
		public Vector2 direction = new Vector2(3, 3);
		
		private Vector2 movement;
		
		void Update()
		{
			// 2 - Movement
			movement = new Vector2(
				speed.x * direction.x,
				speed.y * direction.y);
		}
		
		void FixedUpdate()
		{
			// Apply movement to the rigidbody
			rigidbody2D.velocity = movement;
		}
	}
