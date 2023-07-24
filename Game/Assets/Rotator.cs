using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float speed;
    
    // Update is called once per frame
    private void Update()
    {
        var delta = speed * Time.deltaTime;
        transform.Rotate(delta,delta,delta);
    }
}
