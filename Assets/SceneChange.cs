using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {

	public string levelName;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		Application.LoadLevel (levelName);
	}
}
