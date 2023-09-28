using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class UIBehaviour : MonoBehaviour
{
    //TMP_Text headText;
    int catsHit = 0;

    void Start()
    {
        //headText = GameObject.Find("lblCats").GetComponent<TMPro.TMP_Text>();
    }

    void Update()
    {
    }

    public void AddHit()
    {
        catsHit++;

        /*if (headText != null)
        {
            headText.text = "CatBots touchés : " + catsHit;
        }
        else
        {
            Debug.LogError("headText not initialized.");
        }*/
    }
}
