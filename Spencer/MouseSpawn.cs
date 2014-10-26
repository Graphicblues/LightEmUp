using UnityEngine;
using System.Collections;

public class MouseSpawn : MonoBehaviour {
	public AutoSpawner autoSpawnerRight;
	public AutoSpawner autoSpawnerLeft;

	void Update(){
		
		if (Input.GetMouseButtonDown (1)) {
			
			autoSpawnerRight.Spawn ();
			
		}
		if (Input.GetMouseButtonDown (0)) {
			
			autoSpawnerLeft.Spawn ();
			
		}
	}
}