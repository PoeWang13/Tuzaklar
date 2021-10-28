using UnityEngine;

public class Duz_Thrower : Tuzak
{
    [Header("Script Atamaları")]
    [SerializeField] private Pooler bulletHavuz;
    [SerializeField] private Vector3 bulletExit = new Vector3(0, 0.25f, 0.5f);

    public void FireBullet()
    {
        Bullet bullet = bulletHavuz.HavuzdanObjeIste(bulletExit).GetComponent<Bullet>();
        bullet.SetBullet(this, transform.forward);
    }
}