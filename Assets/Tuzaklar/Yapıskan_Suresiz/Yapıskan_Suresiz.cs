using UnityEngine;

public class Yapıskan_Suresiz : MonoBehaviour
{
    private void EffectVer()
    {
        // Effectleri ver
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.SetParent(other.transform);
            EffectVer();
            Destroy(gameObject);
        }
    }
}