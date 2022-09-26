
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public Transform[] wayPoint;
    private Vector3 pos;
    private Vector3 prev;

    private void OnDrawGizmos()
    {
        if (wayPoint != null)
        {
            Gizmos.color = Color.red;
            for (int i = 0; i < wayPoint.Length; i++)
            {
                pos = wayPoint[i].position;
                if (i < 0)
                {
                    prev = wayPoint[i - 1].position;
                    Gizmos.color = Color.green;
                    Gizmos.DrawLine(prev, pos);
                }
            }
        }
    }
}
