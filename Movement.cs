using UnityEngine;

public class Movement : MonoBehaviour
{
public float speed = 0;

    void Update()
    {

        float vectorHor = Input.GetAxis("Horizontal"); // left/right X
        float vectorVer = Input.GetAxis("Vertical"); // up/down Y

        Vector3 moveDirection = new Vector3(vectorHor, 0, vectorVer);
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
       // transform.position += moveDirection * speed * Time.deltaTime;
        //transform.rotation = Quaternion.LookRotation(moveDirection);
        //transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
