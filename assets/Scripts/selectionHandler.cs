using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectionHandler : MonoBehaviour {

	private bool isSelected = false;
	private float rotationMultipiler = 4.5f;
	private Vector3 ScreenPoint;
	private Vector3 offset;

	void Update()
	{
		// Replace right click to Arrow keys, for convenience
		if (isSelected) {
			transform.Rotate (Input.GetAxis ("Vertical") * rotationMultipiler, 0, -Input.GetAxis("Horizontal") * rotationMultipiler, Space.World);

			if (Input.GetKey (KeyCode.Delete)) {
				Destroy (this.gameObject);
			}
		}
			
	}

	void OnMouseDown()
	{
		// For drag event
		isSelected = true;
		ScreenPoint = Camera.main.WorldToScreenPoint (transform.position);
		offset = transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, ScreenPoint.z));
		transform.GetComponent<Renderer> ().material.color = new Color32 (55, 255, 55, 255);
	}

	void OnMouseUp()
	{
		isSelected = false;
		transform.GetComponent<Renderer> ().material.color = new Color32 (255, 255, 255, 255);
	}

	void OnMouseDrag()
	{
		Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, ScreenPoint.z);
		Vector3 curPos = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
		transform.position = curPos;
	}
}
