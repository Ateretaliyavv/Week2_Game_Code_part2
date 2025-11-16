using UnityEngine;

public class CameraResizer : MonoBehaviour
{

    [SerializeField] float fixedWidth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Camera>().orthographicSize = fixedWidth * Screen.height / Screen.width;
    }

}
