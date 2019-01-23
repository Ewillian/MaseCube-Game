using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour {
	
	public float delayTime;
	public new Animation animation;

	void Start () {
		animation = GetComponent<Animation>();
		StartCoroutine(Go());
	}

	IEnumerator Go(){
		while(true){
			animation.Play();
			yield return new WaitForSeconds(3f);
		}
	}
	
}