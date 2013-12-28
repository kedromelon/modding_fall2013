using UnityEngine;
using System.Collections;

public class FloatingText : MonoBehaviour {

	const float speed = 1;
	public float lifetime = 1f;

	// Use this for initialization
	void Start () {
		StartCoroutine(SelfDestruct());
	}
	
	// Update is called once per frame
	void Update () {

		transform.LookAt ( Camera.main.transform );

		transform.position += (transform.up - transform.forward) * Time.deltaTime * speed;
		transform.position += transform.right * Mathf.Sin(7 * Time.time) * 0.025f * Mathf.Sin(3 * Time.time) * Mathf.Sin (21 * Time.time);
	}

	IEnumerator SelfDestruct () {

		yield return new WaitForSeconds( lifetime );
		Destroy (gameObject);
	}
}
