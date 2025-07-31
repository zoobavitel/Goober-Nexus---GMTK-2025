using UnityEngine;

public class SceneManager : MonoBehaviour
{
    void Start()
    {
        // Check if there's already a camera in the scene
        Camera[] cameras = FindObjectsByType<Camera>(FindObjectsSortMode.None);
        
        if (cameras.Length == 0)
        {
            // Create a new camera if none exists
            GameObject cameraObject = new GameObject("Main Camera");
            Camera camera = cameraObject.AddComponent<Camera>();
            cameraObject.AddComponent<AudioListener>();
            
            // Set camera position for 2D side-scrolling
            cameraObject.transform.position = new Vector3(0, 0, -10);
            
            // Set camera to orthographic for 2D
            camera.orthographic = true;
            camera.orthographicSize = 5f;
            
            Debug.Log("Camera created automatically - no camera found in scene");
        }
        else
        {
            Debug.Log("Camera found in scene: " + cameras[0].name);
        }
    }
} 