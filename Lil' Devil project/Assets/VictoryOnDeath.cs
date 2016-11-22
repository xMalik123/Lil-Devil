using UnityEngine;
using System.Collections;

public class VictoryOnDeath : MonoBehaviour {

	public GameObject Victory;

	void OnDestroy () {
		Victory.SetActive (true);

	
}
}