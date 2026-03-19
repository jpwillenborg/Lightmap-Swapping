using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


public class LightingManager : MonoBehaviour
{
    [SerializeField]
    private Toggle lampsToggle;
    private bool lampsWereOn = true;
    
    private SwitchLights switchLights;
    private SwitchMaterials switchMaterials;
    private SwitchLightmaps switchLightmaps;
    private SwitchLightingScenarios switchLightingScenarios;
    private SwitchVolumes switchVolumes;
    

    void Awake()
    {
        switchLights = GetComponent<SwitchLights>();
        switchMaterials = GetComponent<SwitchMaterials>();
        switchLightmaps = GetComponent<SwitchLightmaps>();
        switchLightingScenarios = GetComponent<SwitchLightingScenarios>();
        switchVolumes = GetComponent<SwitchVolumes>();
    }


    public void SwitchDay(bool value)
    {
        SwitchDayComponents(value);
        lampsToggle.SetIsOnWithoutNotify(value ? false : lampsWereOn);
        lampsToggle.interactable = !value;
        if (!value) SwitchLampComponents(lampsWereOn);
    }


    public void SwitchLamps(bool value)
    {
        SwitchLampComponents(value);
        lampsWereOn = !lampsWereOn;
    }


    private void SwitchDayComponents(bool value)
    {
        switchLights.Switch(value);
        switchMaterials.Switch(value);
        switchLightmaps.Switch(value);
        switchLightingScenarios.Switch(value);
        switchVolumes.Switch(value);
    }


    private void SwitchLampComponents(bool value)
    {
        switchLights.SwitchLamps(value);
        switchMaterials.SwitchLamps(value);
        switchLightmaps.SwitchLamps(value);
        switchLightingScenarios.SwitchLamps(value);
    }
}