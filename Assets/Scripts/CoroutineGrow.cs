using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEditor;

public class CoroutineGrow : MonoBehaviour
{
    public List<Transform> appleTransforms;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Coroutine a = StartCoroutine(Grow());
        //StopCoroutine(a);

        StartCoroutine(Grow());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Grow()
    {
        float t = 0;
        while(t < 1)
        {
            t += Time.deltaTime;
            transform.localScale = Vector3.one * t;
            yield return null;
        }



        for (int i = 0; i < appleTransforms.Count; i++)
        {
            t = 0;
            float size = Random.Range(1, 4);

            while (t < size)
            {
                t += Time.deltaTime;
                appleTransforms[i].localScale = Vector3.one * t;
                yield return null;
            }
        }
    }
}
