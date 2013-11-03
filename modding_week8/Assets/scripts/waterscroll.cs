using UnityEngine;
using System.Collections;

public class waterscroll : MonoBehaviour {

	public float scrollSpeed = 0.5F;
	
    void Update() {
        float offset = Time.time * scrollSpeed;
        renderer.material.mainTextureOffset = new Vector2(offset, offset * 1.61803398875f);
    }
}
