using UnityEngine;
public class Kavisli_Thrower : Tuzak
{
    [Header("Script Atamaları")]
    [SerializeField] private float time = 1;
    [SerializeField] private Pooler bulletHavuz;
    [SerializeField] private Vector3 bulletExit = new Vector3(0, 0.25f, 0.5f);

    public void FireBullet()
    {
        Bullet bullet = bulletHavuz.HavuzdanObjeIste(bulletExit).GetComponent<Bullet>();
        bullet.SetBullet(this, transform.forward * 10, time);
    }
}