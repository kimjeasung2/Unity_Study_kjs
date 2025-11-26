using UnityEngine;

public class RotateOnTarget : MonoBehaviour
{
    public Transform target; // 공전할 대상
    public float rotationSpeed = 5f; // 공전 속도
    public Vector3 rotationAxis = Vector3.up; // 공전 축
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(target == null)
        {
            Debug.LogError("타겟없다. " + gameObject.name);
            return;
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Debug.LogError("타겟없다. " + gameObject.name);
            return;
        }
        // 대상 주위를 공전
        transform.RotateAround(target.position, rotationAxis, rotationSpeed * Time.deltaTime);
    }
}
