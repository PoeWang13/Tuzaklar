using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [Header("Script Atamaları")]
    [SerializeField] private Vector3 teleportPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.position = teleportPoint;
        }
    }
    public void SetTeleportPoint(Vector3 teleport)
    {
        teleportPoint = teleport;
    }
}