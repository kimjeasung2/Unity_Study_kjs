using UnityEngine;

public class Actor : MonoBehaviour
{
    public string actorName;
    public string actorType;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Actor의 이름은 {actorName}입니다.");
    }

    private void OnEnable()
    {
        
        Debug.Log($"Actor의 타입은 {actorType}입니다.");
    }

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
