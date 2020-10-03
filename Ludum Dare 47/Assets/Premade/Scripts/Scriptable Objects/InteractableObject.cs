using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Interactable Object", menuName = "Interactable")]
public class InteractableObject : ScriptableObject
{
    public new string name;
    public GameObject prefab;
    public bool isBreakable;

    private void Awake()
    {
        prefab.transform.tag = "Interactable";
    }
}
