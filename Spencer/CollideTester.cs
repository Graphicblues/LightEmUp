using UnityEngine;
using System.Collections;

public class CollideTester : MonoBehaviour {

	public bool red;
	public string nextLevel;
	void OnCollisionEnter2D (Collision2D info) {

		if (red) {
			if (info.gameObject.GetComponent<SpriteRenderer> ().color == new Color (1, 0, 0)) {
				Destroy (gameObject);
					Destroy (info.gameObject);
				} 
			else {

					stTools.EndScene (nextLevel);

				}
			} 
		else{

			if (info.gameObject.GetComponent<SpriteRenderer> ().color == new Color (0, 0, 1)) {
				Destroy (gameObject);
				Destroy (info.gameObject);
			}
			else{

				stTools.EndScene(nextLevel);

			}
		}


	}
}

