using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerTest : MonoBehaviour {


	public GameObject myQuad;
    

	// Use this for initialization
	void Start () {

		GameObject go;
		for (int i = 0; i < 30;i++){
			Vector3 poz = new Vector3(i*2, 0, 0);
			go = Instantiate(myQuad, poz, Quaternion.identity);
			go.transform.parent = this.gameObject.transform;
			go.name = "tik";
		}

		for (int n = 0; n < 30; n++)
        {
			Vector3 poz = new Vector3((n * 2)+1, 0, 0);
            go = Instantiate(myQuad, poz, Quaternion.identity);
            go.transform.parent = this.gameObject.transform;
			go.GetComponent<Renderer>().material.color = Color.green;
            go.name = "tak";
        }

		for (int t = 0; t < 15; t++)
        {
            Vector3 poz = new Vector3((t * 4), 0, 0);
            go = Instantiate(myQuad, poz, Quaternion.identity);
            go.transform.parent = this.gameObject.transform;
            go.GetComponent<Renderer>().material.color = Color.blue;
            go.name = "tok";
        }
	}
    
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate(Vector3.left * Time.deltaTime *2.0f);
	}
}
