using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using static UnityEngine.GraphicsBuffer;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Vector3 offSet;
    [SerializeField] private Transform followTarget;
    [SerializeField] private float smoothSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LateUpdate()
    {
        SmoothFollow();
    }
    public void SmoothFollow()
    {
        Vector3 targetPos = followTarget.position + offSet;
        Vector3 smoothFollow = Vector3.Lerp(transform.position,
        targetPos, smoothSpeed);

        transform.position = smoothFollow;
    }
}
