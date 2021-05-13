using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FlyingEnemy : Target
{
    Vector3 start;
    public float maxTime=3;
    float timePassed=0;
    bool isRight=true;
    MeshRenderer meshRenderer;
    void Awake()
    {
        start = transform.position;
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        //transform.DOMove(new Vector3(start.x, start.y, start.z - 5f), 3f);
        StartCoroutine("Movement");
        meshRenderer.material.DOColor(Color.black, 3f);
    }

    public IEnumerator Movement()    {        while (true)        {            transform.DOMove(new Vector3(start.x, start.y, start.z + 5f), maxTime);
            yield return new WaitForSeconds(maxTime);
            transform.DOMove(new Vector3(start.x, start.y, start.z), maxTime);            yield return new WaitForSeconds(maxTime);            transform.DOMove(new Vector3(start.x, start.y, start.z - 5f), maxTime);            yield return new WaitForSeconds(maxTime);
            transform.DOMove(new Vector3(start.x, start.y, start.z), maxTime);            yield return new WaitForSeconds(maxTime);        }

    }

    private void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed >= maxTime)
        {
            timePassed -= maxTime;
            if (isRight)
            {
                transform.DOMove(new Vector3(start.x, start.y, start.z +5f), maxTime);               
            }
            else
            {
                transform.DOMove(new Vector3(start.x, start.y, start.z -5f), maxTime);
            }
            isRight = !isRight;

        }
    }
}
