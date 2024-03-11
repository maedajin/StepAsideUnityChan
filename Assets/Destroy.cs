using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 画面からはみ出たら呼ばれる
    private void OnBecameInvisible()
    {
        // ゲームオブジェクトを破棄する
        Destroy(gameObject);
    }
}
