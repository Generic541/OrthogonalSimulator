using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orthogonalDataLoader : MonoBehaviour {

	public void LoadData()
	{
		if (File.Exists (Application.persistentDataPath + "/orthgonalData.dat")) {
			// You must clear ALL objects

			BinaryFormatter formatter = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/orthgonalData.dat", FileMode.Open);
			orthogonalDataSaveFormat saveFormat = (orthogonalDataSaveFormat)formatter.Deserialize (file);
			file.Close ();

			foreach (GameObject childs in saveFormat.ShapeList) {
				Instantiate (childs, childs.transform.position, childs.transform.rotation);
			}

			Camera.main.transform.position = saveFormat.CurrentObserverPosition;

			sliderHandler slide = new sliderHandler ();
			slide.xSlider.value = saveFormat.Xangle;
			slide.ySlider.value = saveFormat.Yangle;

			Debug.Log ("Data has been loaded successfully.");
		} else {
			Debug.LogError ("No data found. Is data corrupted or missing?");
		}
	}
}
