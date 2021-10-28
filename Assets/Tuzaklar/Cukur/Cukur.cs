using UnityEngine;

public class Cukur : MonoBehaviour
{
    [Header("Script Atamaları")]
    [SerializeField] private string mesaj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(mesaj);
            PopUp_Manager.Instance
                .SetFadeInDuration(1)
                .SetTitle("Idiot")
                .SetMessage("Are you BLIND ?")
                .SetPozitifButtonActiver(true);
                //.SetPozitifAction(// Adamı ileri zıplat);
        }
    }
}