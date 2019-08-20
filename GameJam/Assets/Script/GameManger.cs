using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    [SerializeField]
    GameObject m_sphere;
    [SerializeField]
    GameObject m_objContoroller;
    PlayerController m_playerController;
    // Start is called before the first frame update
    void Start()
    {
        m_playerController = m_sphere.GetComponent<PlayerController>();
        m_sphere.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            m_sphere.SetActive(true);
            m_objContoroller.SetActive(false);
        }

        if(m_playerController.GetGoalFlag())
        {
            Debug.Log("yes");
            SceneManager.LoadScene("SampleScene");
        }
    }
}
