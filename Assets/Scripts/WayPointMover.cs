using UnityEngine;

public class WaypointMover : MonoBehaviour
{
    public Transform[] waypoints; // 순차적으로 이동할 위치들
    public float speed = 5f;      // 이동 속도

    private int currentWaypointIndex = 0; // 현재 목표 인덱스

    void Update()
    {
        if (waypoints.Length == 0) return;

        // 현재 목표 위치
        Transform target = waypoints[currentWaypointIndex];

        // 직선 이동
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // 목표에 도달했으면 다음 웨이포인트로 이동
        if (Vector3.Distance(transform.position, target.position) < 0.01f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0; // 반복하려면 0, 아니면 주석 처리
            }
        }
    }
}