using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float m_speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10.0f;
            Vector3 objPos = Camera.main.ScreenToWorldPoint(mousePos);

            float temp = GetAim(this.transform.position, objPos);
            Debug.Log(temp);

            SetVelocityForRigidbody(temp, m_speed);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.tag == "goal")
        {
            collision.tag = "";
            Debug.Log(0);
        }
    }

    public float GetAim(Vector3 pos1, Vector3 pos2)
    {
        float dx = pos2.x - pos1.x;
        float dz = pos2.z - pos1.z;
        float rad = Mathf.Atan2(dz, dx);
        return rad * Mathf.Rad2Deg;
    }

    public void SetVelocityForRigidbody(float direction, float speed)
    {
        // Setting velocity.
        Vector3 v;
        v.x = Mathf.Cos(Mathf.Deg2Rad * direction) * speed;
        v.z = Mathf.Sin(Mathf.Deg2Rad * direction) * speed;
        v.y = 0.0f;
        this.GetComponent<Rigidbody>().velocity = v;
    }

}
