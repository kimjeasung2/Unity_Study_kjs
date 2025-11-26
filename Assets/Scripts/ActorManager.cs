using UnityEngine;

public class ActorManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject actorObject = new GameObject("Actor");
        actorObject.SetActive(false);
        Actor actor = actorObject.AddComponent<Actor>();
        actor.actorName = "HolyCube";
        actor.actorType = "Cube";
        actorObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
