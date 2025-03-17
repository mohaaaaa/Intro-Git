using System.Linq;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float lookY;
    private float lookX;

    public float maxY;
    public float minY;

    public float sensitivityX = 5;
    public float sensitivityY = 5;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump");
        }
        
        lookX += Input.GetAxis("Mouse X") * sensitivityX * Time.deltaTime;
        lookY -= Input.GetAxis("Mouse Y") * sensitivityY * Time.deltaTime;
        
        lookY = Mathf.Clamp(lookY, minY, maxY);
        gameObject.transform.localEulerAngles = new Vector3(lookY, lookX, 0);
    }
}
