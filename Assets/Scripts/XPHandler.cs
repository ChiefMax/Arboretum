using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPHandler : MonoBehaviour
{
    string BtnName;
    [SerializeField]
    public RawImage imageToChange;

    float valueToChange;
    float staticHeight = 32f;

    /*
    *black bird
    fox
    bunny
    *squirrel
    oak
    grass
    caterpillar
    *woodpecker
    sparrow
    int 8
    */

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float staticHeight = 32f;
        if (Input.GetKeyDown(KeyCode.F))
        {
            bool nextTest = true;
            if (nextTest)
            {
                imageToChange.rectTransform.sizeDelta += new Vector2(60f, staticHeight);
            }
        }
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
                        valueToChange += 60f;
                        break;
                    case "Blackbrid":
                        valueToChange += 60f;
                        break;
                    case "Woodpecker":
                        valueToChange += 60f;
                        break;
                    case "Fox":
                        valueToChange += 60f;
                        break;
                    case "Bunny":
                        valueToChange += 60f;
                        break;
                    case "Oak":
                        valueToChange += 60f;
                        break;
                    case "Grass":
                        valueToChange += 60f;
                        break;
                    case "Catapiller":
                        valueToChange += 60f;
                        break;
                    case "Sparrow":
                        valueToChange += 60f;
                        break;
                    default:
                        break;
                }
            }
            imageToChange.rectTransform.sizeDelta += new Vector2(valueToChange, staticHeight);
        }
    }
}
