using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Kavisli_Ilerleyen : Bullet
{
    private float timeNext;
    [SerializeField] private float time = 3;
    [SerializeField] private float yukseklik = 3;
    private Vector3 start;
    private Vector3 end;
    public override void SetBullet(Tuzak tuzak, Vector3 end, float time)
    {
        SetBullet(tuzak);
        this.time = time;
        this.end = end;
        start = transform.position;
    }
    private void Update()
    {
        timeNext += Time.deltaTime;
        transform.position = MathParabola.Parabola(start, end, yukseklik, timeNext);
        if (timeNext > time)
        {
            timeNext = 0;
            havuzum.ObjeyiHavuzaYerlestir(this);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            havuzum.ObjeyiHavuzaYerlestir(this);
        }
    }
}
public class MathParabola
{
    public static Vector3 Parabola(Vector3 start, Vector3 end, float height, float t)
    {
        Func<float, float> f = x => -4 * height * x * x + 4 * height * x;

        var mid = Vector3.Lerp(start, end, t);

        return new Vector3(mid.x, f(t) + Mathf.Lerp(start.y, end.y, t), mid.z);
    }
}