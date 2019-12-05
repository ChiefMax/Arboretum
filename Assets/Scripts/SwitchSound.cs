using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchSound : MonoBehaviour
{
    bool isOnceMainTheme = false;
    bool isOnceMenuTheme = false;

    public AudioClip[] audioClips;
    public AudioSource audioSource;

    [SerializeField]
    public GameObject menuScreen;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (menuScreen.activeSelf && !isOnceMenuTheme)
        {
            audioSource.Stop();
            audioSource.clip = audioClips[0];
            audioSource.PlayOneShot(audioClips[0]);
            isOnceMenuTheme = true;
            isOnceMainTheme = false;
        }
        else if (!menuScreen.activeSelf && !isOnceMainTheme)
        {
            audioSource.Stop();
            audioSource.clip = audioClips[1];
            audioSource.PlayOneShot(audioClips[1]);
            isOnceMenuTheme = false;
            isOnceMainTheme = true;
        }
    }
}
