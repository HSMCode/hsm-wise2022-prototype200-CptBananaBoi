using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    public float forwardspeed = 25f, strafespeed = 7.5f, hoverspeed = 5f;
    private float activeforwardspeed, activestrafespeed, activehoverspeed;
    private float forwardAcceleration = 2.5f, strafeAcceleration = 2f, hoverAcceleration = 2f;

    public float lookRateSpeed = 90f;
    private Vector2 lookInput, screenCenter, mouseDistance;

    // Start is called before the first frame update
    void Start()
    {
        screenCenter.x = Screen.width * .5f;
        screenCenter.y = Screen.height * .5f;
    }

    // Update is called once per frame
    void Update()
    {
        lookInput.x = Input.mousePosition.x;
        lookInput.y = Input.mousePosition.y;

        mouseDistance.x = (lookInput.x - screenCenter.x) / screenCenter.x;
        mouseDistance.y = (lookInput.y - screenCenter.y) / screenCenter.y;

        transform.Rotate(-mouseDistance.y * lookRateSpeed * Time.deltaTime, mouseDistance.x * lookRateSpeed * Time.deltaTime, 0f, Space.Self);


        activeforwardspeed = Mathf.Lerp(activeforwardspeed, Input.GetAxisRaw("Vertical") * forwardspeed, forwardAcceleration * Time.deltaTime);
        activestrafespeed = Mathf.Lerp(activestrafespeed, Input.GetAxisRaw("Horizontal") * strafespeed, strafeAcceleration * Time.deltaTime);
        activehoverspeed = Mathf.Lerp(activehoverspeed, Input.GetAxisRaw("Hover") * hoverspeed, hoverAcceleration * Time.deltaTime);

        transform.position += transform.forward * activeforwardspeed * Time.deltaTime;
        transform.position += (transform.right * activestrafespeed * Time.deltaTime) + (transform.up * activehoverspeed * hoverspeed * Time.deltaTime);
    }
}
