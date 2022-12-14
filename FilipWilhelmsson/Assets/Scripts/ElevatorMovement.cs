using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMovement : MonoBehaviour
{
    [SerializeField] private GameObject nextTarget;

    [SerializeField] private float speed = 2f;

    [SerializeField] private List<GameObject> targetPoints;
    private int currentTargetPointIndex;

    void Start()
    {
        if (targetPoints.Count > 0)
        {
            nextTarget = targetPoints[0];
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (nextTarget != null)
        {
            MoveToPosition(nextTarget);
        }
    }

    void MoveToPosition(GameObject moveToTarget)
    {
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, moveToTarget.transform.position, speed * Time.fixedDeltaTime);
        if(gameObject.transform.position == moveToTarget.transform.position)
        {
            ChangeTarget();
        }
    }
    private void ChangeTarget()
    {
        currentTargetPointIndex++;

        while(targetPoints[currentTargetPointIndex] == null)
        {
            currentTargetPointIndex++;
            if(currentTargetPointIndex >=  targetPoints.Count)
            {
                currentTargetPointIndex = 0;
            }
        }

        nextTarget = targetPoints[currentTargetPointIndex];
    }
}
