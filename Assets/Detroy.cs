using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detroy : MonoBehaviour {


	void OnBecameInvisible(){
		Destroy (this.gameObject);
	}
}
