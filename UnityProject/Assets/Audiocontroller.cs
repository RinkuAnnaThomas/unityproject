using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour {

	public Slider volumes;
	public AudioSource MyVolumes;

	void Update()
	{
		MyVolumes.volume = volumes.value;
	}


}
