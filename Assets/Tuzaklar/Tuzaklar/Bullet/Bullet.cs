using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Bullet : PoolObje
{
    [Header("Script Atamaları")]
    [SerializeField] private Tuzak tuzakci;
    public virtual void SetBullet(Tuzak tuzak)
    {
        tuzakci = tuzak;
    }
    public virtual void SetBullet(Tuzak tuzak, Vector3 direc)
    {
    }
    public virtual void SetBullet(Tuzak tuzak, Vector3 end, float time)
    {
    }
}