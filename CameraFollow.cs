using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public GameObject cameraview;
    private Vector3 offset = new Vector3(0, 7, -20);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraview.transform.position = player.transform.position + offset; 
        cameraview.transform.rotation = player.transform.rotation;   
    }
}
