using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House2TapMotion : MonoBehaviour
{
    public GameObject house2BigNotColor;

    void Start()
    {
        house2BigNotColor.SetActive(false);
    }

    public void onClickAct()
    {
        house1BigNotColor.SetActive(false);
        house2BigNotColor.SetActive(true);
        //this.SetActive(false);
    }
}
