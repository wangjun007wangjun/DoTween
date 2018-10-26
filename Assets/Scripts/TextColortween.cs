using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextColortween : MonoBehaviour {

	// Use this for initialization
	public Text text;

	void Start () {
		text = GetComponent<Text> ();

		Tweener twenner1= text.DOText ("等人共同话题机会与句酷酷酷",3);
		twenner1.SetAutoKill (false);

		twenner1.SetLoops (2);
		twenner1.Pause ();

		Tweener twenner2=text.DOColor (Color.green, 3);
		//Tweener twenner2=text.DOFade(1,6);
		twenner1.SetAutoKill (false);
		twenner2.SetLoops (3);
		twenner2.Pause ();
	}
	
	// Update is called once per frame
	public void OnClick () {
		text.DOPlay ();
	}
}
