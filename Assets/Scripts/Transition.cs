using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    private Idle_Active idle_active;
    private Idle idle;

    // Start is called before the first frame update
    void Start()
    {
        idle_active = GetComponent<Idle_Active>();
        idle = GetComponent<Idle>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void transition()
    {
        idle.enabled = false;
        idle_active.enabled = true;
    }
}
