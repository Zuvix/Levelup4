using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    Rigidbody rb;
    string enemyName="Randomak";

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }
}
