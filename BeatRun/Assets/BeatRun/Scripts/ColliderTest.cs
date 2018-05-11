using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour {

    
	public AudioSource[] audioSources;
	public AudioClip clip1;
	public AudioClip clip2;
	public AudioClip clip3;

	void Start () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		//Debug.Log("ARGH");
		if(other.name=="tik")
		    audioSources[0].PlayOneShot(clip1);
		else if(other.name == "tak")
			audioSources[0].PlayOneShot(clip2);
		else if (other.name == "tok")
            audioSources[0].PlayOneShot(clip3);
	}
	private void OnTriggerExit(Collider other)
    {
        //Debug.Log("TAS");
		//audioSources[1].PlayOneShot(clip2);
    }


	// Update is called once per frame
	void Update () {
		
	}
}
