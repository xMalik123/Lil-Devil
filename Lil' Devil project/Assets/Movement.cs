using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public int movementspeed = 100;
	void Update () {
		if(Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left * movementspeed * Time.deltaTime);
	}
		if(Input.GetKey(KeyCode.D)) {
			transform.Translate (Vector3.right * movementspeed * Time.deltaTime);

			if(Input.GetKeyDown(KeyCode.W)) {
				transform.Translate (Vector3.up * 100 * Time.deltaTime);
}
}
}
}