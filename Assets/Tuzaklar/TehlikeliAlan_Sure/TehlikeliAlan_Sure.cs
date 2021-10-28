using UnityEngine;

public class TehlikeliAlan_Sure : MonoBehaviour
{
    private bool isActive;
    [SerializeField] private Tetik_Timer_Tetikli tetik_Timer_Tetikli;
    public void AktivetedAlanChanced()
    {
        isActive = !isActive;
        if (isActive)
        {
            // Alanı aktif et
        }
        else
        {
            // Alanı aktiflikten çıkar
        }
        tetik_Timer_Tetikli.SetTetik();
    }
    public void EffectVer()
    {
        if (isActive)
        {
            // Effectleri ver
        }
    }
}