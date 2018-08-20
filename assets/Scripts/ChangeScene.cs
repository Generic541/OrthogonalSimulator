using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public void changeToMainMenu()
	{
		SceneManager.LoadScene ("MainMenu");
	}

	public void changeToLoadOrthogonalScreen()
	{
		SceneManager.LoadScene ("loadOrthogonal");
	}

	public void changeToMyOrthogonalScreen()
	{
		SceneManager.LoadScene ("BasicOrthogonal");
	}
}
