using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createTetrahedronMesh : MonoBehaviour {

	public int size = 1;

	void Start () {
		MeshFilter filter = GetComponent<MeshFilter> ();
		Mesh mesh = filter.mesh;
		mesh.Clear ();

		// Vertices
		mesh.vertices = new Vector3[]
		{
			new Vector3(0, 0, 0), // 0
			new Vector3(size, 0, 0), // 1
			new Vector3(size/2f, 0, size*Mathf.Sqrt(3/4f)), // 2
			new Vector3(size/2f, size*Mathf.Sqrt(3/4f), Mathf.Sqrt(3/4f)/3*size) // 3
		};

		mesh.triangles = new int[] {
			0, 1, 2,
			0, 2, 3,
			2, 1, 3,
			0, 3, 1
		};

		mesh.RecalculateNormals ();
		mesh.RecalculateBounds ();
	}
}
