using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class XPHandler : MonoBehaviour
{
    string BtnName;
    [SerializeField]
    public Image imageToChange;

    public TextMeshProUGUI text;

    float valueToChange;

    int counter = 0;
    int Lvl = 1;

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
        //float staticHeight = 32f;
        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //    bool nextTest = true;
        //    if (nextTest)
        //    {
        //        imageToChange.rectTransform.sizeDelta += new Vector2(60f, staticHeight);
        //    }
        //}

        if (counter == 5)
        {
            Lvl++;
            text.text = Lvl.ToString();
            imageToChange.fillAmount = 0f;
            counter = 0;
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
                        imageToChange.fillAmount += 0.2f;
                        counter++;
                        break;
                    case "Blackbrid":
                        imageToChange.fillAmount += 0.2f;
                        counter++;
                        break;
                    case "Woodpecker":
                        imageToChange.fillAmount += 0.2f;
                        counter++;
                        break;
                    case "fox":
                        imageToChange.fillAmount += 0.2f;
                        counter++;
                        break;
                    case "Bunny":
                        imageToChange.fillAmount += 0.2f;
                        counter++;
                        break;
                    case "Acorn":
                        imageToChange.fillAmount += 0.2f;
                        counter++;
                        break;
                    case "grassblades":
                        imageToChange.fillAmount += 0.2f;
                        counter++;
                        break;
                    case "Catarpiller":
                        imageToChange.fillAmount += 0.2f;
                        counter++;
                        break;
                    case "Sparrow":
                        imageToChange.fillAmount += 0.2f;
                        counter++;
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}
