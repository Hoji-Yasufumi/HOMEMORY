using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlashingText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI colorText;
    private bool judgeTap = false;
 
    void Start()
    {
        colorText.color = new Color(92f/255f, 122f/255f, 142f/255f, 1.0f);
        StartCoroutine("Flashing");
    }
 
    IEnumerator Flashing()
    {
        while (judgeTap == false){
            for ( int i = 0 ; i < 40 ; i++ )
            {
                colorText.color = colorText.color - new Color32(0,0,0,10);
                yield return new WaitForSeconds(0.02f);
            }
 
            for ( int k = 0 ; k < 40 ; k++ )
            {
                colorText.color = colorText.color + new Color32(0,0,0,10);
                yield return new WaitForSeconds(0.02f);
            }

            if(Input.GetMouseButtonDown(0)) judgeTap = true;
        }
    }
}
