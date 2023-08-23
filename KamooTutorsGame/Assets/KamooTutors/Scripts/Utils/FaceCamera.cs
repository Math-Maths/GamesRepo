using UnityEngine;

namespace KamooTutor 
{

public class FaceCamera : MonoBehaviour 
{
    [SerializeField]
    Transform mainCameraTransform;
    
    private void LateUpdate()
    {
        Vector3 targetPosition = transform.position + mainCameraTransform.rotation * Vector3.forward;
        Vector3 lookAtDirection = targetPosition - transform.position;
        transform.rotation = Quaternion.LookRotation(lookAtDirection, mainCameraTransform.right);
    }
}

}