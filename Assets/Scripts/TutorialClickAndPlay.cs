using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialClickAndPlay : MonoBehaviour
{
    public AudioClip[] DialogueSound;
    public AudioSource source;

    public GameObject[] elements;

    string BtnName;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
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
                    case "Woodpecker":
                        StartCoroutine(playEngineSound(DialogueSound));
                        elements[0].SetActive(true);
                        break;
                    default:
                        break;
                }
            }
        }
    }

    IEnumerator playEngineSound(AudioClip[] playThis)
    {
        for (int i = 0; i < DialogueSound.Length; i++)
        {
            source.PlayOneShot(playThis[i]);
            yield return new WaitForSeconds(playThis[i].length);
        }
    }
}
