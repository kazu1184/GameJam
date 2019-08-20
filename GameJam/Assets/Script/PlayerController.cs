using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float m_speed;
    bool m_pushFlag = false;
    bool m_goalFlag = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !m_pushFlag || Input.GetMouseButtonDown(1) && !m_pushFlag)
        {
            m_pushFlag = true;

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
        if (collision.gameObject.tag == "goal")
        {
            m_goalFlag = true;
            collision.gameObject.tag = "Untagged";
            Debug.Log(0);
        }
    }

    public bool GetGoalFlag()
    {
        return m_goalFlag;
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
