using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
public class MobileCam : MonoBehaviour
{
	private bool camAvailable;
	private WebCamTexture backCam;
	private Texture defaultBackground;

	public RawImage background;
	public AspectRatioFitter fit;
	//public bool frontFacing;

	// Use this for initialization
	void Start()
	{
		defaultBackground = background.texture;
		WebCamDevice[] devices = WebCamTexture.devices;

		if (devices.Length == 0) 
        {
			Debug.Log("No Detect");
			camAvailable = false;
			return;
        }
			

		for (int i = 0; i < devices.Length; i++)
		{
			 

			if (!devices[i].isFrontFacing)
			{
				backCam = new WebCamTexture(devices[i].name, Screen.width, Screen.height);
				
			}
		}

		if (backCam  == null)
        {
			Debug.Log("unable Detect");
			return;
        }
			

		backCam.Play(); // Start the camera
		background.texture = backCam; // Set the texture

		camAvailable = true; // Set the camAvailable for future purposes.
	}

	// Update is called once per frame
	private void Update()
	{
		if (!camAvailable)
			return;

		float ratio = (float)backCam.width / (float)backCam.height;
		fit.aspectRatio = ratio; // Set the aspect ratio

		float scaleY = backCam.videoVerticallyMirrored ? -1f : 1f; // Find if the camera is mirrored or not
		background.rectTransform.localScale = new Vector3(1f, scaleY, 1f); // Swap the mirrored camera

		int orient = -backCam.videoRotationAngle;
		background.rectTransform.localEulerAngles = new Vector3(0, 0, orient);
	}
}
