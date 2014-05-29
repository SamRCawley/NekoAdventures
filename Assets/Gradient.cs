using UnityEngine;
using System.Collections;

public class Gradient : MonoBehaviour {

	private Color edgeColor = new Color (255, 255, 255);
	private Color midColor = new Color(200, 200, 255);
	// Use this for initialization
	void Start () {
		Mesh bg = ((MeshFilter)GetComponent(typeof(MeshFilter))).mesh;
		Color[] colors = new Color[bg.vertices.Length];
		colors[0] = edgeColor;
		colors[1] = edgeColor;
		colors[2] = midColor;
		colors[3] = midColor;
		bg.colors = colors;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
