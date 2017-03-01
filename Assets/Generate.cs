using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	// Use this for initialization
	void Start () {
        for (int i = 50; i > 0; i--)
        {
            for (int x = 50; x > 0; x--)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(i*2f, 0, x*2f);
            }
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
