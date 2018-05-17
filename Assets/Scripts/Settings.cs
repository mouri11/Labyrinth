using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;//reference to audio

public class Settings : MonoBehaviour {
public AudioMixer audioMixer;
void start(){
	audioMixer.SetFloat("Volume",0.0f);
}
public void setVolume(float volume){
	audioMixer.SetFloat("Volume",volume);//setfloat(name of exposed param,float value)
}
}
