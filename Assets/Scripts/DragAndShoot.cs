using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndShoot : MonoBehaviour
{
    public float power = 10f;
    public Rigidbody rb;
    public LineRenderer lineRenderer; 

    private Camera cam;
    private Vector3 startPos;
    private Vector3 endPos;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
            startPos.z = startPos.y;
            startPos.y = 0;
            Debug.Log("Start Pos: " + startPos);
        }
        if (Input.GetMouseButton(0))
        {
            endPos = Input.mousePosition;
            endPos.z = endPos.y;
            endPos.y = 0;
            // Debug.Log("End Pos: " + endPos);

            DrawLine(startPos - endPos);
        }
    }

    private void DrawLine(Vector3 direction) {
        Vector3[] positions = {
            transform.position,
            direction
        };
        lineRenderer.SetPositions(positions);
        lineRenderer.enabled = true;
    }
}