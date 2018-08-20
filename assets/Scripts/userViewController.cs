using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userViewController : MonoBehaviour {

	public GameObject selected = null;
	private Camera mainCam;
	private float zoomMutlpiler = 10f;
	private float rotationMultipiler = 1.5f;
	private float speed = 100f;
	private float pitch;
	private float yaw;

	void setSelected(GameObject Obj) {
		selected = Obj;
	}

	GameObject getSelected() {
		return selected;
	}

	void Start() {
		mainCam = Camera.main;
	}

	void Update () {
			
		if (Input.GetMouseButtonDown(0))
		{
			RaycastHit hitInfo = new RaycastHit();
			bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

			if (hit) {
				setSelected (hitInfo.transform.gameObject);
				Debug.Log (getSelected ());
				} else if (getSelected () != null) {
					setSelected (null);
					}
			Debug.Log (getSelected ());
		}

			/*
			if (getSelected () != null) {
				float screenDistance = mainCam.WorldToScreenPoint (getSelected().transform.position).z;
				getSelected().transform.position = mainCam.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenDistance));
			}
			*/
			
		// If user clicked right mouse button
		if (Input.GetMouseButton (1)) {
			if (getSelected () == null) {
				pitch += rotationMultipiler * Input.GetAxis ("Mouse Y");
				yaw += rotationMultipiler * Input.GetAxis ("Mouse X");
				pitch = Mathf.Clamp (pitch, -90f, 90f);

				while (yaw < 0f) {
					yaw += 360f;
				}
				while (yaw > 0f) {
					yaw -= 360f;
				}

				transform.eulerAngles = new Vector3 (pitch, yaw, 0f);
			}
		}
			
		// If mouse wheel moves
		if (Input.GetAxis ("Mouse ScrollWheel") != 0f) {
			mainCam.fieldOfView -= Input.GetAxis ("Mouse ScrollWheel") * zoomMutlpiler;
			mainCam.fieldOfView = Mathf.Clamp (mainCam.fieldOfView, 0.1f, 179.9f);
		}

		if (getSelected () == null) {
			if (Input.GetKey (KeyCode.D)) {
				transform.Translate (new Vector3 (speed * Time.deltaTime, 0, 0));
			}

			if (Input.GetKey (KeyCode.A)) {
				transform.Translate (new Vector3 (-speed * Time.deltaTime, 0, 0));
			}

			if (Input.GetKey (KeyCode.S)) {
				transform.Translate (new Vector3 (0, 0, -speed * Time.deltaTime));
			}

			if (Input.GetKey (KeyCode.W)) {
				transform.Translate (new Vector3 (0, 0, speed * Time.deltaTime));
			}

			if (Input.GetKey (KeyCode.Space)) {
				transform.Translate (new Vector3 (0, speed * Time.deltaTime, 0));
			}

			if (Input.GetKey (KeyCode.LeftShift)) {
				transform.Translate (new Vector3 (0, -speed * Time.deltaTime, 0));
			}
		}
	}
}
