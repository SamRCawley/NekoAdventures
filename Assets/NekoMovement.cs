using UnityEngine;
using System.Collections;

public class NekoMovement : MonoBehaviour {

	public float maxVelocity;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mousePosition = Input.mousePosition;
		
		mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
		
		//transform.position = Vector2.Lerp(transform.position, mousePosition, maxVelocity);

		rigidbody2D.velocity = Vector2.ClampMagnitude (new Vector2 (mousePosition.x - transform.position.x, mousePosition.y - transform.position.y)*10, maxVelocity);

	}
}
