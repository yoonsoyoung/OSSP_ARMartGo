using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchObject : MonoBehaviour {
	//QR code 인식 후 생성되는 3D object 터치 시 정보 패널 팝업을 위함.
	public GameObject canvas; //상위 캔버스
	public GameObject Tpanel; //Table 패널
	public GameObject Cpanel; //Chair 패널

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) { //터치 인식
			if (Input.touchCount <= 1) { //터치 점이 1일 때. 즉 멀티 터치 아닌 터치 한 번.
				Vector2 pos = Input.GetTouch (0).position; //터치 좌표
				Vector3 theTouch = new Vector3 (pos.x, pos.y, 0.0f);
					
				Ray ray = Camera.main.ScreenPointToRay (theTouch); //raycast 로 터치 된 점 받음.
		
				RaycastHit hit = new RaycastHit ();
				if (Physics.Raycast (ray, out hit, Mathf.Infinity)) {
					if (hit.collider.CompareTag ("Table")) { //Table mark Touched
						if (Input.GetTouch (0).phase == TouchPhase.Began) {
							
						} else if (Input.GetTouch (0).phase == TouchPhase.Ended) {
							Tpanel.SetActive (true); //Table pannel On.
							Cpanel.SetActive (false); //Chair pannel Off.
						}
					} else if (hit.collider.CompareTag ("Chair")) { //Chair mark Touched
						if (Input.GetTouch (0).phase == TouchPhase.Began) {
							
						} else if (Input.GetTouch (0).phase == TouchPhase.Ended) {
							Cpanel.SetActive (true); //Chair pannel On.
							Tpanel.SetActive (false); //Chair pannel Off.
						}
					}
				}
			}
		}
	}
}
