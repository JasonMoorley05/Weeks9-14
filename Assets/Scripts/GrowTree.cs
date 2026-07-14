using UnityEngine;

public class GrowTree : MonoBehaviour
{
    public float treeGrowDuration;

    float treeGrowProgress = 0f;
    private bool onGrowPressed = false;

    public float appleGrowDuration;
    private float appleGrowProgress = 0f;

    public Transform appleTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (onGrowPressed)
        {
            treeGrowProgress += Time.deltaTime;
            transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, treeGrowProgress / treeGrowDuration);

            if(treeGrowProgress > treeGrowDuration)
            {
                appleGrowProgress += Time.deltaTime;
                appleTransform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, appleGrowProgress / appleGrowDuration);
            }
        }
    }

    public void OnGrow()
    {
        onGrowPressed = true;
    }
}
