using UnityEngine;

public class Bataklik : MonoBehaviour
{
    [Header("Script Atamaları")]
    [SerializeField] private float speedDusmeOran;
    [SerializeField] private bool isZehirli;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Speed dusur
            if (isZehirli)
            {
                // Zehir ver
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Speed duzelt
        }
    }
}