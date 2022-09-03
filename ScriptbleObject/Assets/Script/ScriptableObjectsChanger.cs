using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjectsChanger : MonoBehaviour
{
    [SerializeField] private ScriptableObject[] serializableObjects;
    [SerializeField] private MapDisplay mapDisplay;

    private void Awake()
    {
        mapDisplay.DisplayMap((Map)serializableObjects[0]);
    }

}
