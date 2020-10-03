using Manager;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class SpawnInteractable : MonoBehaviour
{
    public InteractableObject[] interactables;
    public Transform[] points;
    private void Start()
    {
        EventManager.StartListening("Loaded", Loaded);
    }

    private void Loaded()
    {
        SpawnObject();
    }

    public void SpawnObject()
    {
        for(int i = 0; i < points.Length; i++)
        {
            Instantiate(interactables[Mathf.RoundToInt(Random.Range(0, interactables.Length))].prefab, points[i]);
        }
    }
}
