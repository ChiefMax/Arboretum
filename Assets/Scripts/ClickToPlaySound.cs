using System.Collections;
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
                    case "testBtn":
                        audioSource.clip = audioClips[0];
                        audioSource.Play(0);
                        elements[0].SetActive(true);
                        LeafesSpawn();
                        break;
                    case "Bird1":
                        audioSource.clip = audioClips[1];
                        audioSource.Play(0);
                        elements[1].SetActive(true);
                        LeafesSpawn();
                        break;
                    case "Woodpecker":
                        audioSource.clip = audioClips[2];
                        audioSource.Play(0);
                        elements[2].SetActive(true);
                        LeafesSpawn();
                        break;
                    default:
                        break;
                }
            }
        }
    }

    void LeafesSpawn()
    {
        ParticleSystem firework = Instantiate(leaf, pos, Quaternion.identity);
        firework.GetComponent<ParticleSystem>().Play();
    }
}
