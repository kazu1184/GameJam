﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class StartGoalPosObj : MonoBehaviour
{
    // [SerializeField]
    // GameObject[] m_wall;
    [SerializeField]
    Vector3 start_wall_vec;
    Vector3 goal_wall_vec;


    private void Awake() {
        var random_int_array = Enumerable.Range(1, 12).OrderBy(n => Guid.NewGuid()).Take(2).ToArray();

        var start_obj_name = String.Format("Wall-{0}", random_int_array[0]);
        var goal_obj_name = String.Format("Wall-{0}", random_int_array[1]);

        var start_wall = GameObject.Find(start_obj_name);
        var goal_wall = GameObject.Find(goal_obj_name);

        start_wall.GetComponent<Renderer>().material.color = Color.yellow;
        goal_wall.GetComponent<Renderer>().material.color = Color.red;

        goal_wall.tag = "goal";

        start_wall_vec = start_wall.transform.position;
        goal_wall_vec = goal_wall.transform.position;

    }
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public Vector3 GetStartWallVec3()
    {
        return start_wall_vec;
    }

    public Vector3 GetGoalWallVec3()
    {
        return goal_wall_vec;
    }

}
