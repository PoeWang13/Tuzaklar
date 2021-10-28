using UnityEngine;

public class Thrower : MonoBehaviour
{
    [Header("Script Atamaları")]
    [SerializeField] private Vector3 throwPower;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Rigidbody>().AddForce(throwPower);
        }
    }
}