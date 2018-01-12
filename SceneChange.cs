using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {
	//Main 화면에서 Menu 화면으로 넘어가기 위함.
	public void Menu()
	{
		SceneManager.LoadScene ("Menu"); //Menu 라는 이름의 Scene 을 불러옴.
	}

	public void AR_MartGO()
	{
		SceneManager.LoadScene ("AR_MartGo"); //AR_MartGo 라는 이름의 Scene을 불러옴.
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//취소(뒤로가기) 키 입력(터치) 시 어플 종료.
		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKeyDown (KeyCode.Escape)) {
				Application.Quit ();
			}
		}
	}
}
