using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Spawne : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject basicEnemak;
    public Text nameTxt;
    void Start()
    {
        GameObject go=Instantiate(basicEnemak);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
