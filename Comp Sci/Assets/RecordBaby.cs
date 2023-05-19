using System.Collections.Generic;
using UnityEngine;

public class RecordBaby : MonoBehaviour
{
    public Transform PlayerTransform;
    private Vector3 _cameraOffset;
    public float rotationSpeed = 1;
    public Transform Target, Player;
    float mouseX, mouseY;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    public bool LookAtPlayer = false;
    // Start is called before the first frame update
    void Start()
    {
        _cameraOffset = transform.position - PlayerTransform.position;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        CamControl();
        

        /*if(LookAtPlayer){
            transform.LookAt(PlayerTransform);
        }*/
    }
    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY += Input.GetAxis("Mouse Y") * rotationSpeed * -1;
        mouseY = Mathf.Clamp(mouseY, -35, 60);


        Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        Player.rotation = Quaternion.Euler(0, mouseX, 0);
    }
}