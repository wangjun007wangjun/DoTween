using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MyText : MonoBehaviour {

	// Use this for initialization
	private Text text;
	void Start () {
		text = this.GetComponent<Text> ();
		text.DOText ("接下来进入下一场景,当地人格瑞特哈哈哈",3);
	}
	

}
