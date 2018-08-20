using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapePanelController : MonoBehaviour {

	private GameObject userPanel;
	private byte status = 1;

	void Start()
	{
		userPanel = GameObject.Find ("userPanel");
	}

	public void togglePanel()
	{
		if (status == 0) {
			userPanel.SetActive (true);
			status = 1;
		} else {
			userPanel.SetActive (false);
			status = 0;
		}
	}
}
