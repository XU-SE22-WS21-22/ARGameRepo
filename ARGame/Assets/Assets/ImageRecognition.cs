using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class ImageRecognition : MonoBehaviour
{
private ARTrackedImageManager aRTrackedImageManager;

private void Awake()
{
    aRTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
}

public void OnEnable()
{
    aRTrackedImageManager.trackedImagesChanged += OnImageChanged;
}

public void OnDisale()
{
    aRTrackedImageManager.trackedImagesChanged -= OnImageChanged;
}

public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
{

}
}
