using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MyButton : MonoBehaviour {

	public RectTransform myPanel;


	private bool IsIn = false;

	void Start () {
		//让myPanel从当前位置动画到（0,0,0）
		//myPanel.DOMove (new Vector3 (0, 0, 0), 2);//修改的是世界坐标
		Tweener tweener= myPanel.DOLocalMove (new Vector3 (0, 0, 0), 0.4f);//修改局部坐标(默认播放完，动画销毁)
		//Tweene对象保存这个动画的信息，每次调用do类型的方法都会创建一个tweener对象，这个对象是dotween来管理
		tweener.SetAutoKill(false);

		tweener.Pause ();
	}
	
	// Update is called once per frame
	public void OnClick()
	{
		if (IsIn == false) {
			myPanel.DOPlay ();//会播放，但是只会播放一次
			myPanel.DOPlayForward ();//动画前向播放

			IsIn = true;
		} else {
			//面板离开
			myPanel.DOPlayBackwards();//动画反向播放

			IsIn = false;
		}
	}
}
