using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Active : MonoBehaviour
{
    private RectTransform circle;

    // animate the game object from -1 to +1 and back
    [SerializeField] float minimum = 500;
    [SerializeField] float maximum = 800f;
    [SerializeField] float time = 1f;
    
    private float radius = 0f;
    
    void Start()
    {
        circle = GetComponent<RectTransform>();
    }

    void Update()
    {
        // animate the position of the game object...
        radius = Mathf.Lerp(minimum, maximum, Mathf.PingPong(Time.time, time));
        circle.sizeDelta = new Vector2(radius, radius);
    }
}
