using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private GameObject unity;

    // Start is called before the first frame update
    void Start()
    {
        //回転を開始する角度を設定
        this.transform.Rotate(0, Random.Range(0, 360), 0);
        
        this.unity = GameObject.Find(" UnityChanController");
    }

    // Update is called once per frame
    void Update()
    {
        //回転
        this.transform.Rotate(0, 3, 0);
    }
}
