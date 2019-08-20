using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class StartGoalPosObj : MonoBehaviour
{
    // [SerializeField]
    // GameObject[] m_wall;

    Vector3 start_wall;
    Vector3 goal_wall;

    // Start is called before the first frame update
    void Start()
    {
        var random_int_array = Enumerable.Range(1, 13).OrderBy(n => Guid.NewGuid()).Take(2).ToArray();

        var start_obj_name = String.Format("Wall-{0}", random_int_array[0]);
        var goal_obj_name = String.Format("Wall-{0}", random_int_array[1]);
        start_wall = GameObject.Find(start_obj_name).transform.position;
        goal_wall = GameObject.Find(goal_obj_name).transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public Vector3 GetStartWallVec3()
    {
        return start_wall;
    }

    public Vector3 GetGoalWallVec3()
    {
        return goal_wall;
    }

}
