using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;


public class SwitchLights : MonoBehaviour
{
    [SerializeField]
    private Slider slider;
    [SerializeField]
    private GameObject lightGroupDay;
    [SerializeField]
    private GameObject lightGroupNight;
    [SerializeField]
    private GameObject lampGroup;


    public void Switch(bool value)
    {
        if (value)
        {
            lightGroupDay.SetActive(true);
            lightGroupNight.SetActive(false);
        } else
        {
            lightGroupDay.SetActive(false);
            lightGroupNight.SetActive(true);
        }
    }


    public void SwitchLamps(bool value)
    {
        lampGroup.SetActive(value);
    }
}