using UnityEngine;

public class BallSchizo : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        // Handle collision logic here
        Debug.Log("BallSchizo collided with: " + other.gameObject.name);
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = randomColor;
    }
    private Color GetRandomColor()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
}
