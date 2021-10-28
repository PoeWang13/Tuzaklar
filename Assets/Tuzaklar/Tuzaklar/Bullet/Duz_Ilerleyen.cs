using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Duz_Ilerleyen : Bullet
{
    [Header("Script Atamaları")]
    [SerializeField] private int lifeTime;
    private float lifeTimeNext;
    [SerializeField] private Vector3 direction;
    public override void SetBullet(Tuzak tuzak, Vector3 direc)
    {
        SetBullet(tuzak);
        direction = direc;
    }
    private void Update()
    {
        lifeTimeNext += Time.deltaTime;
        if (lifeTimeNext > lifeTime)
        {
            lifeTimeNext = 0;
            havuzum.ObjeyiHavuzaYerlestir(this);
        }
        transform.Translate(direction * Time.deltaTime * 5);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            havuzum.ObjeyiHavuzaYerlestir(this);
        }
    }
}