using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Idle_Active : MonoBehaviour
{
    private RectTransform circle;
    private Image image;
    private Idle idle;
    [SerializeField] float speed;
    private Color lerpedColor = Color.white;


    private Vector3 targetPos = new Vector3 (0, -385, 0);
    //private Vector2 targetSize = new Vector2 (500, 500);

    // Start is called before the first frame update
    void Start()
    {
        circle = GetComponent<RectTransform>();
        image = GetComponent<Image>();
        idle = GetComponent<Idle>();
    }

    // Update is called once per frame
    void Update()
    {
        // change position of circle
        circle.anchoredPosition = Vector3.MoveTowards(circle.anchoredPosition, targetPos, speed * Time.deltaTime);

        // change colour of circle
        lerpedColor = Color.Lerp(Color.white, Color.black, Time.time);
        image.color = lerpedColor;
    }
}
