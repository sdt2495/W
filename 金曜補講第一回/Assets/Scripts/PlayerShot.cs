using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    [SerializeField] GameObject enemy;   
    [SerializeField] GameObject bullet;

    private float bulletSpeed = 10.0f;
    private float time = 1.0f;

    void Update()
    {
        if (enemy == null) return;

        time -= Time.deltaTime;

        if (time <= 0)
        {
            Shot();
            time = 1.0f;
        }
    }

    void Shot()
    {
        transform.LookAt(enemy.transform);

        GameObject obj = Instantiate(bullet, transform.position, Quaternion.identity);

        Vector3 dir = (enemy.transform.position - transform.position).normalized;
        obj.GetComponent<Rigidbody>().linearVelocity = dir * bulletSpeed;
    }
}