using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class select : MonoBehaviour {


	public void lvl (int devil) {
		SceneManager.LoadScene (devil);
	
	}
}
