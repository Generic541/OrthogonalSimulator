using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tetrahedronMover : MonoBehaviour {
	
	void Update () {
		Mesh mesh = GetComponent<MeshFilter> ().mesh;
		Vector3[] vertices = mesh.vertices;
		Vector3[] normals = mesh.normals;

		for (int i = 0; i < vertices.Length; i++) {
			vertices [i] += normals [i] * Mathf.Sin (Time.time);
		}
		mesh.vertices = vertices;
	}
}
