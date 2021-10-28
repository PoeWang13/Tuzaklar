using UnityEngine;

public class Yapiskan_Sureli : MonoBehaviour
{
    [Header("Script Atamaları")]
    [SerializeField] private Tetik_Timer_Tetikli tetik_Timer_Tetikli;
    private void EffectVer()
    {
        // Effectleri ver
    }
    public void EffectSil()
    {
        // Effectleri sil
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.SetParent(other.transform);
            tetik_Timer_Tetikli.SetTetik();
            EffectVer();
        }
    }
}