using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateShape : MonoBehaviour {

	public GameObject Sphere;
	public GameObject Cube;
	public GameObject Square;
	public GameObject Tetrahedron;
	public GameObject Circle;
	public GameObject Polyhedron;
	public GameObject Convex;
	public GameObject Panel;
	public GameObject Cylinder;
	public GameObject TriangularCone;
	public GameObject Cone;

	private List<GameObject> spawnedGameObject = new List<GameObject> ();

	public List<GameObject> getSpawnedGameObject() {
		return spawnedGameObject;
	}
		
	public void createSphere()
	{
		/* GameObject sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		sphere.transform.position = new Vector3 (0, 0, 190);
		sphere.transform.localScale = new Vector3 (getSize(), getSize(), getSize()); */
		// spawnedGameObject.Add (Instantiate (Sphere, new Vector3 (0, 0, 190), Quaternion.identity) as GameObject);
		GameObject sphere = Instantiate(Sphere, new Vector3(0, 0, 190), Quaternion.identity) as GameObject;
		spawnedGameObject.Add (sphere.gameObject);
	}
	
	public void createCube()
	{
		/* GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube.transform.position = new Vector3 (0, 0, 190);
		cube.transform.localScale = new Vector3 (getSize(), getSize(), getSize()); */
		GameObject cube = Instantiate (Cube, new Vector3 (0, 0, 190), Quaternion.identity) as GameObject;
		spawnedGameObject.Add (cube);
	}

	public void createTetrahedron()
	{
		GameObject tetra = Instantiate (Tetrahedron, new Vector3 (0, 0, 190), Quaternion.identity) as GameObject;
		spawnedGameObject.Add (tetra);
	}

	public void createLine()
	{
		// Line renderer is required.
		// You must know whether this object is treated as GameObject.
	}

	public void createCircle()
	{
		GameObject circle = Instantiate (Circle, new Vector3 (0, 0, 190), Quaternion.identity) as GameObject;
		spawnedGameObject.Add (circle);
	}

	public void createSquare()
	{
		/* GameObject square = GameObject.CreatePrimitive (PrimitiveType.Cube);
		square.transform.position = new Vector3 (0, 0, 190);
		square.transform.localScale = new Vector3 (getSize()/10000f, getSize(), getSize()); */
		GameObject square = Instantiate (Square, new Vector3 (0, 0, 190), Quaternion.identity) as GameObject;
		spawnedGameObject.Add (square);
	}

	public void createPolyhedron()
	{
		// Mesh is required to implement this.
	}

	public void createConvex()
	{
		// Mesh is required.
		// Prerequisite knowledge about convex is required.
	}

	public void createPanel()
	{
		GameObject panel = Instantiate (Panel, new Vector3 (0, 0, 190), Quaternion.identity) as GameObject;
		spawnedGameObject.Add (panel);
	}

	public void createCylinder()
	{
		GameObject cyl = Instantiate (Cylinder, new Vector3 (0, 0, 190), Quaternion.identity) as GameObject;
		spawnedGameObject.Add (cyl);
	}

	public void createTriangularCone()
	{

	}

	public void createCone()
	{
		GameObject cone = Instantiate (Cone, new Vector3 (0, 0, 190), Quaternion.identity) as GameObject;
		spawnedGameObject.Add (cone);
	}
}
