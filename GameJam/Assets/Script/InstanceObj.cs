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
        GameObject temp;
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10.0f;
            Vector3 objPos = Camera.main.ScreenToWorldPoint(mousePos);
            objPos.y = 0.5f;

            float area = 4.0f;
            if(objPos.x <= area && objPos.x >= -area && objPos.z <= area && objPos.z >= -area)
            {
                // オブジェクトの生成
                temp = Instantiate(m_obj[(int)VALUE_OBJECT.BOX], objPos, Quaternion.identity);
                Color randomColor = new Color( Random.value, Random.value, Random.value, 1.0f );
                temp.GetComponent<Renderer>().material.color = randomColor;
                DontDestroyOnLoad(temp);

            }
        }
    }
}
