﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Button))]
public class SoundController : MonoBehaviour
{
    public Toggle soundEffect;
    public AudioSource theSound;

    private AudioSource source { get { return GetComponent<AudioSource>(); }}
    private Button button { get { return GetComponent<Button>();}}
    // Start is called before the first frame update
    void Start()
    {
        source.playOnAwake = false;

        gameObject.AddComponent<AudioSource>();
       // source.clip = btnSound;

        button.onClick.AddListener(() => PlaySound());
    }
     // Update is called once per frame
    void PlaySound()
    {
        if (SoundEffectsToggle.isOn == true || soundEffect.isOn)
        {
            source.pitch = Random.Range(0.5f, 1.5f);
            //source.PlayOneShot(btnSound, 0.5f);
            theSound.Play();
        }
    }
}
