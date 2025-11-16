using UnityEngine;

public class CameraResizer : MonoBehaviour
{

    [SerializeField] float fixedWidth;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Camera>().orthographicSize = fixedWidth * Screen.height / Screen.width;
    }

}
