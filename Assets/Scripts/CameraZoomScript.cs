using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomScript : MonoBehaviour
{
	private Vector3 offset = new Vector3(0, 10, -20);
	public GameObject cheese;

	public Transform target;
	public float distance = 20.0f;
	public float height = 5.0f;
	public float heightDamping = 2.0f;

	public float lookAtHeight = 0.0f;

	public Rigidbody parentRigidbody;

	public float rotationSnapTime = 0.3F;

	public float distanceSnapTime;
	public float distanceMultiplier;

	private Vector3 lookAtVector;

	private float usedDistance;

	float wantedRotationAngle;
	float wantedHeight;

	float currentRotationAngle;
	float currentHeight;

	Quaternion currentRotation;
	Vector3 wantedPosition;

	private float yVelocity = 0.0F;
	private float zVelocity = 0.0F;

	void Start()
	{

		lookAtVector = new Vector3(0, lookAtHeight, 0);

	}

	void LateUpdate()
	{

		wantedHeight = target.position.y + height;
		currentHeight = transform.position.y;

		wantedRotationAngle = target.eulerAngles.y;
		currentRotationAngle = transform.eulerAngles.y;

		currentRotationAngle = Mathf.SmoothDampAngle(currentRotationAngle, wantedRotationAngle, ref yVelocity, rotationSnapTime);

		currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

		wantedPosition = target.position;
		wantedPosition.y = currentHeight;

		usedDistance = Mathf.SmoothDampAngle(usedDistance, distance + (parentRigidbody.velocity.magnitude * distanceMultiplier), ref zVelocity, distanceSnapTime);

		wantedPosition += Quaternion.Euler(0, currentRotationAngle, 0) * new Vector3(0, 0, -usedDistance);

		transform.position = wantedPosition;

		transform.LookAt(target.position + lookAtVector);
		transform.position = cheese.transform.position + offset;

	}

}
//{
//    public Vector3 offset = new Vector3(0, 0, 1);
//    public Transform target;

//    public float minZoom = 5f;
//    public float maxZoom = 15f;
//    public float zoomSpeed = 4f;

//    private float currentZoom = 10f;

//    void Update()
//    {
//        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
//        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);
//    }

//    void LateUpdate()
//    {
//        transform.position = target.position - offset * currentZoom;
//    }
//}
//{
//    private void CameraZoom()
//    {
//        public float cameraZoomSensitivity;
//        float zoomValue = Input.GetAxis("Mouse ScrollWheel") * cameraZoomSensitivity;
//        //mainCamera is just the Transform of the Camera.
//        mainCamera.Translate(new Vector3(0.0f, 0.0f, zoomValue));
//    }
    //{
    //     public Vector3 offset = new Vector3(5, 30, -20);
    //    public Transform target;

    //    public float minZoom = 5f;
    //    public float maxZoom = 15f;
    //    public float zoomSpeed = 4f;

    //    private float currentZoom = 10f;

    //    void Update()
    //    {
    //        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
    //        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);
    //    }

    //    void LateUpdate()
    //    {
    //        transform.position = target.position - offset * currentZoom;
    //    }
//}
