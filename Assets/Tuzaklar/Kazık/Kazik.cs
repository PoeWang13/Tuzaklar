using UnityEngine;

public class Kazik : MonoBehaviour
{
    [SerializeField] private float beklemeTime;
    [SerializeField] private int speed = 1;
    [SerializeField] private Vector3 secondPos;
    [SerializeField] private Transform kazik;
    private float beklemeTimeNext;
    private int direction = 1;
    private bool bekle;
    private Vector3 targetPos;

    public void GiveDamage()
    {

    }
    private void Update()
    {
        if (bekle)
        {
            beklemeTimeNext += Time.deltaTime;
            if (beklemeTimeNext > beklemeTime)
            {
                beklemeTimeNext = 0;
                bekle = false;
            }
        }
        else
        {
            kazik.position = Vector3.MoveTowards(kazik.position, targetPos, Time.deltaTime * speed);
            if (Vector3.Distance(kazik.position, targetPos) < 0.05f)
            {
                bekle = true;
                if (direction == 1)
                {
                    targetPos = secondPos;
                }
                else
                {
                    targetPos = transform.position;
                }
                direction *= -1;
            }
        }
    }
}