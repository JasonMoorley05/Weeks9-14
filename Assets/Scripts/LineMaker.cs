using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class LineMaker : MonoBehaviour
{
    LineRenderer lineRenderer;

    public float growDuration;

    public Vector3 startPosition;
    public Vector3 stopPosition;

    Coroutine grow;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();

        if (lineRenderer == null)
        {
            Debug.Log("Linemaker does not have a LineRendererer Component");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (grow != null)
            {
                StopCoroutine(grow);
            }

            grow = StartCoroutine(growUpdate());
        }
    }

    IEnumerator growUpdate()
    {
        float t = 0;
        lineRenderer.positionCount = 2;

        lineRenderer.SetPosition(0, startPosition);
        lineRenderer.SetPosition(1, stopPosition);

        while (t < growDuration)
        {
            t += Time.deltaTime;

            Vector2 currentSecondPosition = Vector2.Lerp(startPosition, stopPosition, t/growDuration);
            lineRenderer.SetPosition(1, currentSecondPosition);

            yield return null;
        }
    }

}