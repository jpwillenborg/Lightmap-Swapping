using UnityEngine;
using UnityEngine.Rendering;


public class SwitchLightingScenarios : MonoBehaviour
{
    private string scenario01 = "Day";
    private string scenario02 = "Night Lights On";
    private string scenario03 = "Night Lights Off";
    private ProbeReferenceVolume probeRefVolume;


    void Start()
    {
        probeRefVolume = ProbeReferenceVolume.instance;
        probeRefVolume.BlendLightingScenario(scenario01, 1.0f);
        // probeRefVolume.lightingScenario = scenario01;
    }


    // public void Switch(bool value)
    // {
    //     if (value)
    //     {
    //         probeRefVolume.BlendLightingScenario(scenario01, 1.0f);
    //     } else
    //     {
    //         probeRefVolume.BlendLightingScenario(scenario02, 1.0f);
    //     }
    // }


    public void Switch(bool value)
{
    if (value)
    {
        // probeRefVolume.SetActiveLightingScenario(scenario01);
        UnityEngine.Rendering.ProbeReferenceVolume.instance.lightingScenario = scenario01;
        // UnityEngine.Rendering.ProbeReferenceVolume.instance.BlendLightingScenario(scenario01, 1.0f);
    } 
    else
    {
        // probeRefVolume.SetActiveLightingScenario(scenario02);
        UnityEngine.Rendering.ProbeReferenceVolume.instance.lightingScenario = scenario02;
        // UnityEngine.Rendering.ProbeReferenceVolume.instance.BlendLightingScenario(scenario02, 1.0f);
    }
}


    public void SwitchLamps(bool value)
    {
        if (value)
        {
            probeRefVolume.BlendLightingScenario(scenario02, 1.0f);
        } else
        {
            probeRefVolume.BlendLightingScenario(scenario03, 1.0f);
        }
    }
}