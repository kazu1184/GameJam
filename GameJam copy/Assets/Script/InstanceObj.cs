using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceObj : MonoBehaviour
{
    enum VALUE_OBJECT
    {
        BOX
    }

    [SerializeField]
    GameObject[] m_obj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // オブジェクトの生成
            Instantiate(m_obj[(int)VALUE_OBJECT.BOX], new Vector3(0.0f, 0.5f, 0.0f), Quaternion.identity);
        }
    }
}
