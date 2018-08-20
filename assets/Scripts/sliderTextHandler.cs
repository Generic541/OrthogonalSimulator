using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderTextHandler : MonoBehaviour {

	// Update is called once per frame
	public Slider parentSlider;
	public Text childText;

	void LateUpdate() {
		childText.text = parentSlider.value.ToString ("0.00");
	}
}
