using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orthogonalDataSaver : MonoBehaviour {

	// CreateShape cs = new CreateShape();
	// sliderHandler slide = new sliderHandler ();

	List<GameObject> shapeList;
	Vector3 ObserverPos;
	float xAngle;
	float yAngle;

	private orthogonalDataSaveFormat CreateDataSaveFormatInstance()
	{
		orthogonalDataSaveFormat saveFormat = new orthogonalDataSaveFormat ();
		// saveFormat.ShapeList = GetComponent<GameObject> ();
		saveFormat.CurrentObserverPosition = Camera.main.transform.position;
		// saveFormat.Xangle = slide.xSlider.value;
		// saveFormat.Yangle = slide.ySlider.value;

		return saveFormat;
	}

	public void SaveOrthogonalData() {
		orthogonalDataSaveFormat saveFormat = CreateDataSaveFormatInstance ();

		BinaryFormatter formatter = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/orthgonalData.dat");
		formatter.Serialize (file, saveFormat);
		file.Close ();
		Debug.Log ("Data has been saved successfully.");
	}
}
