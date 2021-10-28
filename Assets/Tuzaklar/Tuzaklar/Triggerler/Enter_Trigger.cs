using TMPro;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class Enter_Trigger : MonoBehaviour
{
    [Header("Script Atamaları")]
    [SerializeField] private List<string> enterTags = new List<string>() { "Player"};
    [SerializeField] private UnityEvent enterAction;
    private void OnTriggerEnter(Collider other)
    {
        if (enterTags.Contains(other.tag))
        {
            enterAction?.Invoke();
        }
    }
}