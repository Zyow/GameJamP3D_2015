﻿using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour 
{
	public AudioClip pauseSFX;
	public GameObject uiPause;

	private AudioSource audioSource;
	private bool isInPause;

	void Awake ()
	{
		uiPause.SetActive (false);
		audioSource = GetComponent<AudioSource>();
	}

	void Update ()
	{
		if (Input.GetButtonDown("Pause"))
		{
			audioSource.PlayOneShot (pauseSFX);
			isInPause = !isInPause;
			if (isInPause)
			{
				uiPause.SetActive (true);
				Time.timeScale = 0;
			}
			else 
			{
				uiPause.SetActive (false);
				Time.timeScale = 1;
			}
		}
	}
}
