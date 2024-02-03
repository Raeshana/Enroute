using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Idle : MonoBehaviour
{
    private RectTransform circle;

    // animate the game object from -1 to +1 and back
    [SerializeField] float minimum = 0f;
    [SerializeField] float maximum = 300f;

    // starting value for the Lerp
    static float t = 0.0f;
    [SerializeField] float i = 1f;

    // image and colours
    private Image image;
    private float lerpedAlpha = 0f;
    private Color lerpedColor;

    void Start()
    {
        circle = GetComponent<RectTransform>();
        image = GetComponent<Image>();
        lerpedColor = image.color;
    }

    void Update()
    {
        // animate the position of the game object...
        circle.anchoredPosition = new Vector3(0, Mathf.Lerp(minimum, maximum, t), 0);

        // .. and increase the t interpolater
        t += i * Time.deltaTime;

        // now check if the interpolator has reached 1.0
        // and swap maximum and minimum so game object moves
        // in the opposite direction.
        if (t > i)
        {
            float temp = maximum;
            maximum = minimum;
            minimum = temp;
            t = 0.0f;
        }

        // colour change
        lerpedAlpha = Mathf.Lerp(0.7f, 1f, Mathf.PingPong(Time.time, 1));
        lerpedColor.a = lerpedAlpha;
        image.color = lerpedColor;
    }
}
