using UnityEngine;
using System.Collections;

public class CollideTester : MonoBehaviour {

	public bool red;

	void OnCollisionEnter2D (Collision2D info) {

		int score = (int) stData.GetDictionaryValue ("Scores", "Score");

		if (red) {
			if (info.gameObject.GetComponent<SpriteRenderer> ().color == new Color (1, 0, 0)) {
				Destroy (gameObject);
				Destroy (info.gameObject);
				score++;
			} 
			else {

				score--;

				}
			} 
		else{

			if (info.gameObject.GetComponent<SpriteRenderer> ().color == new Color (0, 0, 1)) {
				Destroy (gameObject);
				Destroy (info.gameObject);
				score++;
			}
			else{

				score--;

			}
		}

		stData.SetDictionaryValue ("Scores", "Score", score);

	}
}

