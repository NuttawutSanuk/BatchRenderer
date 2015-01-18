using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class BulletTest : MonoBehaviour
{
    Transform m_trans;
    BulletManager m_bullets;


    void Awake()
    {
        m_trans = GetComponent<Transform>();
        m_bullets = GetComponent<BulletManager>();
    }

    float R(float v)
    {
        return Random.Range(-v, v);
    }

    void Update()
    {
        float spread = 0.4f;
        for (int i = 0; i < 24; ++i )
        {
            Vector3 pos = m_trans.position;
            Vector3 dir = (m_trans.forward + (new Vector3(R(1.0f), R(1.0f), 0.0f)).normalized*spread).normalized;
            float speed = 6.0f + R(0.25f);
            m_bullets.Shoot(pos, dir*speed, 4.0f);
        }
    }
}