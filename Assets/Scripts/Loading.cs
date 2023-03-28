using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public GameObject loading;
    public GameObject error;
    public Image bar;


    void Update()
    {
        if (loading.activeSelf == true)
        {
            if (bar.fillAmount <= 0.05)
            {
                bar.fillAmount += (0.005f);
            }
            else if (bar.fillAmount <= 0.4)
            {
                bar.fillAmount += (0.001f);
            }
            else if (bar.fillAmount <= 0.7)
            {
                bar.fillAmount += (0.0007f);
            }
            else if (bar.fillAmount < 0.9)
            {
                bar.fillAmount += (0.00015f);
            }
            else
            {
                bar.fillAmount -= (1f);
                loading.SetActive(false);
                error.SetActive(true);
            }
        }



    }
}
