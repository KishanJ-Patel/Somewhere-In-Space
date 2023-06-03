using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStickLook : MonoBehaviour
{
	public bl_Joystick Joystick;

	public enum RotationAxes { VerticalandHorizontal = 0, Vertical = 1, Horizontal = 2 };
	public RotationAxes axes = RotationAxes.VerticalandHorizontal;
	public float sensitivityX = 15F;
	public float sensitivityY = 15F;

	public float minimumX = -360F;
	public float maximumX = 360F;

	public float minimumY = -60F;
	public float maximumY = 60F;

	float rotationX = 0F;
	float rotationY = 0F;

	Quaternion originalRotation;

	void Update()
	{
		if (axes == RotationAxes.VerticalandHorizontal)
		{
			// Read the mouse input axis
			rotationX += Joystick.Horizontal * sensitivityX;
			rotationY += Joystick.Vertical * sensitivityY;

			rotationX = ClampAngle(rotationX, minimumX, maximumX);
			rotationY = ClampAngle(rotationY, minimumY, maximumY);

			Quaternion xQuaternion = Quaternion.AngleAxis(rotationX, Vector3.up);
			Quaternion yQuaternion = Quaternion.AngleAxis(rotationY, -Vector3.right);

			transform.localRotation = originalRotation * xQuaternion * yQuaternion;
		}
		else if (axes == RotationAxes.Vertical)
		{
			rotationX += Joystick.Vertical * sensitivityX;
			rotationX = ClampAngle(rotationX, minimumX, maximumX);

			Quaternion xQuaternion = Quaternion.AngleAxis(rotationX, Vector3.up);
			transform.localRotation = originalRotation * xQuaternion;
		}
		else
		{
			rotationY += Joystick.Horizontal * sensitivityY;
			rotationY = ClampAngle(rotationY, minimumY, maximumY);

			Quaternion yQuaternion = Quaternion.AngleAxis(-rotationY, Vector3.right);
			transform.localRotation = originalRotation * yQuaternion;
		}

		
	}

	void Start()
	{
		// Make the rigid body not change rotation
		if (GetComponent<Rigidbody>())
			GetComponent<Rigidbody>().freezeRotation = true;
		originalRotation = transform.localRotation;
	}

	public static float ClampAngle(float angle, float min, float max)
	{
		if (angle < -360F)
			angle += 360F;
		if (angle > 360F)
			angle -= 360F;
		return Mathf.Clamp(angle, min, max);
	}
}
