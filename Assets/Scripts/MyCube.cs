using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MyCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//transform.DOMoveX (5, 1).From();
		//默认是从当前位置运动到目标位置，调用From（）方法后表示从目标位置移动到当前位置
		transform.DOMoveX (5, 1).From(true);//From(true)后表示5为一个相对位置，即如果物体现在的x为1，则从6移动到1，移动5个单位，而不是移动到5

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
