using UnityEngine;
using System.Collections;

public class GenerateSomeShit : MonoBehaviour {

	public float killtime = 15;

	// Use this for initialization
	void Start () {
		float start = Time.realtimeSinceStartup;

		for (int x = 0; x < 256; ++x) {
			for (int z = 0; z < 256; ++z) {
				if (Time.realtimeSinceStartup - start >= killtime) {return;}
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(x, 0, z);
			}}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
