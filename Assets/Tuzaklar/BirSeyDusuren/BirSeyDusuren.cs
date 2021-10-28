using UnityEngine;

public class BirSeyDusuren : MonoBehaviour
{
    [Header("Script Atamaları")]
    [SerializeField] private Rigidbody dusenObje;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dusenObje.useGravity = true;
        }
    }
}