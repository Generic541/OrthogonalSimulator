using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderHandler : MonoBehaviour {

	public Slider xSlider;
	public Slider ySlider;

	// Update is called once per frame
	void LateUpdate () {
		transform.localEulerAngles = new Vector3 (xSlider.value, ySlider.value, 0);
	}
}
