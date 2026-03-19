using UnityEngine;
using System;
using UnityEngine.UI;


[Serializable]
public struct ObjectData
{
    public MeshRenderer renderer;
    public int materialIndex;
    public Material dayMaterial;
    public Material nightMaterial;
}


[Serializable]
public struct LampsObjectData
{
    public MeshRenderer renderer;
    public int materialIndex;
    public Material onMaterial;
    public Material offMaterial;
}


public class SwitchMaterials : MonoBehaviour
{
    [SerializeField]
    private ObjectData[] ObjectData;
    [SerializeField]
    private LampsObjectData[] LampsObjectData;
    private Material[] objectMaterials;
    private Material[] lampsObjectMaterials;


    public void Switch(bool value)
    {
        for (int i = 0; i < ObjectData.Length; i++)
        {
            objectMaterials = ObjectData[i].renderer.materials;
            if (value)
            {
                objectMaterials[ObjectData[i].materialIndex] = ObjectData[i].dayMaterial;
            } else
            {
                objectMaterials[ObjectData[i].materialIndex] = ObjectData[i].nightMaterial;
            }
            ObjectData[i].renderer.materials = objectMaterials;
        }
    }


    public void SwitchLamps(bool value)
    {
        for (int i = 0; i < LampsObjectData.Length; i++)
        {
            lampsObjectMaterials = LampsObjectData[i].renderer.materials;
            if (value)
            {
                lampsObjectMaterials[LampsObjectData[i].materialIndex] = LampsObjectData[i].onMaterial;
            } else
            {
                lampsObjectMaterials[LampsObjectData[i].materialIndex] = LampsObjectData[i].offMaterial;
            }
            LampsObjectData[i].renderer.materials = lampsObjectMaterials;
        }
    }
}