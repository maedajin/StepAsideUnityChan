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

    // ��ʂ���͂ݏo����Ă΂��
    private void OnBecameInvisible()
    {
        // �Q�[���I�u�W�F�N�g��j������
        Destroy(gameObject);
    }
}
