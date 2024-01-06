using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public GameObject[] audio;
	
	//void Update()
		//dont destroy on load
	
	public void PlayAudio(int index){
		if (audio[index] != null){
			audio[index].GetComponent<AudioSource>().Play();
		}else{
			return;
		}
	}
	
	public void StopAudio(int index){
		if (audio[index] != null){
			audio[index].GetComponent<AudioSource>().Stop();
		}else{
			return;
		}
	}
}
