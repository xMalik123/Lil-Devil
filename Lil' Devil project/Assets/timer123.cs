using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class timer123 : MonoBehaviour {

	float timer = 3; 
	void Update () {
		timer -= Time.deltaTime;
		if (timer < 0)
		{
			SceneManager.LoadScene (0);



		}

	}
}
