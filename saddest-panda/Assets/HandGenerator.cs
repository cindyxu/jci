using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGenerator : MonoBehaviour {

	public int numHands;

	// Use this for initialization
	void Start () {
		Collider2D collider = GetComponent<Collider2D> ();
		Bounds bounds = collider.bounds;
		Random random = new Random();
		for (int i = 0; i < numHands; i++) {
			float x = Random.Range (bounds.min.x, bounds.max.x);
			float y = Random.Range (bounds.min.y, bounds.max.y);
			GameObject.Instantiate (Resources.Load ("hand"), new Vector2 (x, y), Quaternion.identity);
		}
	}
}
