﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	public void loadScene(string sceneName)
	{
		SceneManager.LoadScene (sceneName, LoadSceneMode.Single);
	}
}
