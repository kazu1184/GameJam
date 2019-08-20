using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjCount : MonoBehaviour
{
    // Start is called before the first frame update
    int count;

    void Start()
    {
        count = 3;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            count -= 1;

            if (count <= 0)
            {
                Debug.Log("dest");
                this.gameObject.SetActive(false);
            }
        }
    }
}