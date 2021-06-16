using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowList : MonoBehaviour
{
    [SerializeField] private Text score;

    private void OnEnable()
    {
        if (GlobalChampData.score / 1000 >= 4)
        {
            score.text = "大段位-"+((GlobalChampData.score / 1000)-3)+"级";
        }
        else
        {
            score.text = GlobalChampData.score.ToString();
        }
    }
}
