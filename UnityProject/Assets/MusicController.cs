using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audiocontroller : MonoBehaviour {

	public Slider volume;
	public AudioSource MyVolume;

	void Update()
	{
		MyVolume.volume = volume.value;
	}


}
