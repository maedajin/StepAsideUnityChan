using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private GameObject unity;

    // Start is called before the first frame update
    void Start()
    {
        //��]���J�n����p�x��ݒ�
        this.transform.Rotate(0, Random.Range(0, 360), 0);
        
        this.unity = GameObject.Find(" UnityChanController");
    }

    // Update is called once per frame
    void Update()
    {
        //��]
        this.transform.Rotate(0, 3, 0);
    }
}
