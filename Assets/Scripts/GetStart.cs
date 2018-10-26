using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class GetStart : MonoBehaviour {

	// Use this for initialization
	public Vector3 myValue=new Vector3(1186,0,0);

	//public Transform cubeTransform;

	public RectTransform taskPanelTransform;

	public float myValue2;

	void Start () {
		///对变量做一个动画,通过差值的方式修改一个值得变化
		//(0,0,0)在两秒变化到10，10,10
		DOTween.To(()=>myValue,x=>myValue=x,new Vector3(0,0,0),2.5f);
		//前两个参数一般是固定的
		DOTween.To(()=>myValue2,x=>myValue2=x,10,2);
	}
	
	// Update is called once per frame
	void Update () {
		//cubeTransform.position = myValue;
		taskPanelTransform.localPosition=myValue;
	}
}
