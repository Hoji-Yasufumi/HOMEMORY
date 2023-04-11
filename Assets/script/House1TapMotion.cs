using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House1TapMotion : MonoBehaviour
{
    public GameObject house1BigNotColor;

    void Start()
    {
        house1BigNotColor.SetActive(false);
    }

    public void onClickAct()
    {
        house1BigNotColor.SetActive(true);
        house2BigNotColor.SetActive(false);
        //this.SetActive(false);
    }
}
