using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Target : MonoBehaviour
{
    public float health = 30f;
    public void TakeDamage(float amount)
    {
        health -= amount;
        transform.DOShakeScale(0.15f,0.5f,5);
        //transform.DOShakePosition(0.5f);
        if (health <= 0f)
        {
            Kill();
        }
    }
    public void Kill()
    {
        Destroy(this.gameObject);
    }
}
