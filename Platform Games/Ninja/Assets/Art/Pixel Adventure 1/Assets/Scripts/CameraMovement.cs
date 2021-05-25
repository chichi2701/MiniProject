using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smothing;

    Vector3 velocity = Vector3.zero;

    [Header("Set up Vertical limit camera position ")]
    //enable and set the maximum Y value
    public bool YMaxEnabled = false;
    public float YMaxValue = 0f;

    //enable and set the mimimum Y value
    public bool YMinEnabled = false;
    public float YMinValue = 0f;

    [Header("Set up Horizonal limit camera position ")]

    //enable and set the maximum Y value
    public bool XMaxEnabled = false;
    public float XMaxValue = 0f;

    //enable and set the mimimum Y value
    public bool XMinEnabled = false;
    public float XMinValue = 0f;

    //public Vector3 offset;

    private void LateUpdate()
    {
        ///*simple but not smooth*/
        //transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);

        /*another way*/
        //Vector3 targetPos = target.position;
        //targetPos.z = transform.position.z;
        //transform.position = target.position + offset;
        //targetPos.x = Mathf.Clamp(targetPos.x, minPosition.x, maxPosition.y);
        //targetPos.y = Mathf.Clamp(targetPos.y, minPosition.y, maxPosition.y);
        //transform.position = Vector3.Lerp(transform.position, target.position, smothing);



        Vector3 targetPos = new Vector3(target.position.x, target.position.y, transform.position.z);

        /*Vertical*/
        if (YMaxEnabled && YMinEnabled)
        {
            targetPos.y = Mathf.Clamp(target.position.y, YMinValue, YMaxValue);
        }
        else if (YMaxEnabled)
        {
            targetPos.y = Mathf.Clamp(target.position.y, target.position.y, YMaxValue);
        }
        else if (YMinEnabled)
        {
            targetPos.y = Mathf.Clamp(target.position.y, YMinValue, target.position.y);
        }

        /*Horizonal*/
        if (XMaxEnabled && XMinEnabled)
        {
            targetPos.x = Mathf.Clamp(target.position.x, XMinValue, XMaxValue);
        }
        else if (XMaxEnabled)
        {
            targetPos.x = Mathf.Clamp(target.position.x, target.position.x, XMaxValue);
        }
        else if (XMinEnabled)
        {
            targetPos.x = Mathf.Clamp(target.position.x, XMinValue, target.position.x);
        }

        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smothing);
    }
}
