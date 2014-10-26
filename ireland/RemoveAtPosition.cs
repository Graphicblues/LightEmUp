using UnityEngine;
using System.Collections;

public class RemoveAtPosition : MonoBehaviour {
	public bool GreaterThen = false;
	public float deletepoint = -10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GreaterThen == false) {
			if (transform.position.x < deletepoint) {
				Destroy(gameObject);
			}
		}
			else {
				if (transform.position.x > deletepoint) {
					Destroy(gameObject);
				}
			}

				}
						
						
	}

