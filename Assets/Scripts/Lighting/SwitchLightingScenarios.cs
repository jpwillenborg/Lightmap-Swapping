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


    public void Switch(bool value)
    {
        if (value)
        {
            probeRefVolume.BlendLightingScenario(scenario01, 1.0f);
        } else
        {
            probeRefVolume.BlendLightingScenario(scenario02, 1.0f);
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