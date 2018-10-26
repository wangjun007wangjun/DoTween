using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MyPanel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Tweener tweener= transform.DOLocalMoveX (0,2);
		tweener.SetEase (Ease.InBounce);//动画的属性

		tweener.SetLoops (3);//动画循环播放次数

		tweener.OnComplete (OnTweenerComplete);//动画播放完调用的函数，即使设置了循环播放动画，也只是调用一次

	}
	
	// Update is called once per frame
	 void OnTweenerComplete () {
		Debug.Log ("动画播放完毕");
	}
}
