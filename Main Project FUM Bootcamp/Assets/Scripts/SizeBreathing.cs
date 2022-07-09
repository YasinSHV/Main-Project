using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeBreathing : MonoBehaviour
{

    Vector3 minScale;
    public Vector3 MaxScale;
    public float speed = 2f;
    public float DurationUnit = 5f;
    bool Repeater = false;

    private void Start()
    {
        minScale = transform.localScale;
    }
    private void update() 
    {
        RepeatLerp(minScale, MaxScale, DurationUnit);
        RepeatLerp(MaxScale, minScale, DurationUnit);
    }

    public IEnumerator RepeatLerp(Vector3 a, Vector3 b, float time) 
    {
        float i = 0.0f;
        float rate = (1.0f / time) * speed;
        i += Time.deltaTime * rate; 
          transform.localScale =  Vector3.Lerp(a, b, i);
        yield return null;

    }

}
