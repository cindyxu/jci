using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {

	public float minAngle;
	public float maxAngle;
	public float speed;

	private float mCurrFrac;

	// Use this for initialization
	void Start () {
		mCurrFrac = Random.value;
	}
	
	// Update is called once per frame
	void Update () {
		mCurrFrac = (mCurrFrac + Time.deltaTime * speed) % 1.0f;
		float angle = minAngle + Mathf.Abs (mCurrFrac - 0.5f) * 2 * (maxAngle - minAngle);
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
	}
	
}
