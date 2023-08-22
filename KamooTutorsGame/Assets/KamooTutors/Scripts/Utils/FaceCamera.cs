using UnityEngine;

namespace KamooTutor 
{

public class FaceCamera : MonoBehaviour 
{
    [SerializeField]
    Transform mainCameraTransform;
    [SerializeField]
    float x,y,z;

    private void LateUpdate()
    {
        Vector3 offset = new Vector3(x,y,z);
        Vector3 targetPosition = transform.position + mainCameraTransform.rotation * Vector3.forward;
        Vector3 lookAtDirection = targetPosition - transform.position + offset;
        transform.rotation = Quaternion.LookRotation(lookAtDirection, mainCameraTransform.right);
    }
}

}