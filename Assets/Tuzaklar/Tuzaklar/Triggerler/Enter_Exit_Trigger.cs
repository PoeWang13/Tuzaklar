using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections.Generic;

public class Enter_Exit_Trigger : MonoBehaviour
{
    [Header("Script Atamaları")]
    [SerializeField] private List<string> enterTags = new List<string>() { "Player" };
    [SerializeField] private UnityEvent enterAction;
    [SerializeField] private List<string> exitTags = new List<string>() { "Player" };
    [SerializeField] private UnityEvent exitAction;
    private void OnTriggerEnter(Collider other)
    {
        if (enterTags.Contains(other.tag))
        {
            enterAction?.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (exitTags.Contains(other.tag))
        {
            exitAction?.Invoke();
        }
    }
}