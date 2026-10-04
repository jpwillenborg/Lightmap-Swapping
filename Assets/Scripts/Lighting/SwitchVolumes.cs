using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;


public class SwitchVolumes : MonoBehaviour
{
    [SerializeField]
    private Volume globalVolume;
    [SerializeField]
    private VolumeProfile profileDay;
    [SerializeField]
    private VolumeProfile profileNight;
    private VolumeProfile clonedProfileDay;
    private VolumeProfile clonedProfileNight;
    private WhiteBalance whiteBalance;
    private float balanceValue = 0;


    public void Start()
    {
        clonedProfileDay = Instantiate(profileDay);
        for (int i = 0; i < profileDay.components.Count; i++)
        {
            var component = Instantiate(profileDay.components[i]);
            clonedProfileDay.components[i] = component;
        }
        globalVolume.profile = clonedProfileDay;


        clonedProfileNight = Instantiate(profileNight);
        for (int i = 0; i < profileNight.components.Count; i++)
        {
            var component = Instantiate(profileNight.components[i]);
            clonedProfileNight.components[i] = component;
        }

        UpdateProfile(true);
    }


    public void UpdateProfile(bool value)
    {
        if (globalVolume.profile.TryGet<WhiteBalance>(out WhiteBalance adjustments))
        {
            whiteBalance = adjustments;
            Debug.Log("White Balance found.");
            
            whiteBalance.temperature.overrideState = true;
            whiteBalance.temperature.value = (int)balanceValue;
        }
        else
        {
            Debug.LogError("White Balance not found in the volume profile.");
        }
    }


    public void AdjustTemperature(float value)
    {
        whiteBalance.temperature.value = (int)value;
        balanceValue = value;
    }


    public void Switch(bool value)
    {
        if (value) {
            globalVolume.profile = clonedProfileDay;
        } else {
            globalVolume.profile = clonedProfileNight;
        }

        UpdateProfile(value);
    }
}