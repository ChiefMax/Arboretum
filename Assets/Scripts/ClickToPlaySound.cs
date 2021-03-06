﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickToPlaySound : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioSource audioSource;

    public GameObject[] elements;

    public ParticleSystem leaf;

    Vector3 pos = new Vector3(0, 0, 0);

    string BtnName;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                BtnName = hit.transform.name;
                switch (BtnName)
                {
                    case "Squirrel":
                        audioSource.clip = audioClips[0];
                        audioSource.Play(0);
                        elements[0].SetActive(true);
                        LeafesSpawn(hit.transform.position);
                        break;
                    case "Blackbrid":
                        audioSource.clip = audioClips[3];
                        audioSource.Play(0);
                        elements[1].SetActive(true);
                        LeafesSpawn(hit.transform.position);
                        break;
                    case "Woodpecker":
                        audioSource.clip = audioClips[2];
                        audioSource.Play(0);
                        elements[2].SetActive(true);
                        LeafesSpawn(hit.transform.position);
                        break;
                    case "fox":
                        audioSource.clip = audioClips[4];
                        audioSource.Play(0);
                        elements[3].SetActive(true);
                        LeafesSpawn(hit.transform.position);
                        break;
                    case "Bunny":
                        audioSource.clip = audioClips[8];
                        audioSource.Play(0);
                        elements[4].SetActive(true);
                        LeafesSpawn(hit.transform.position);
                        break;
                    case "Acorn":
                        audioSource.clip = audioClips[6];
                        audioSource.Play(0);
                        elements[5].SetActive(true);
                        LeafesSpawn(hit.transform.position);
                        break;
                    case "grassblades":
                        audioSource.clip = audioClips[5];
                        audioSource.Play(0);
                        elements[6].SetActive(true);
                        LeafesSpawn(hit.transform.position);
                        break;
                    case "Caterpillar":
                        audioSource.clip = audioClips[9];
                        audioSource.Play(0);
                        elements[7].SetActive(true);
                        LeafesSpawn(hit.transform.position);
                        break;
                    case "Sparrow":
                        audioSource.clip = audioClips[1];
                        audioSource.Play(0);
                        elements[7].SetActive(true);
                        LeafesSpawn(hit.transform.position);
                        break;
                    default:
                        break;
                }
            }
        }
    }

    void LeafesSpawn(Vector3 spawnPos)
    {
        ParticleSystem firework = Instantiate(leaf, spawnPos, Quaternion.identity);
        firework.GetComponent<ParticleSystem>().Play();
    }
}
