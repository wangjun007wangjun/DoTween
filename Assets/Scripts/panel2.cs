using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class panel2 : MonoBehaviour {

	// Use this for initialization
	private DOTweenAnimation tweenAimation;
	private bool isShow = false;
	void Start () {
		tweenAimation = GetComponent<DOTweenAnimation> ();
		//tweenAimation.DOPlayForward ();
	}
	
	// Update is called once per frame
	public void OnClick () {
		if (isShow) {
			tweenAimation.DOPlayBackwards ();
			isShow = false;
		} else {
			tweenAimation.DOPlayForward ();
			isShow = true;
		}
	}
}
