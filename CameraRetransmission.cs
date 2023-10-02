using UnityEngine;

public class CameraRetransmission : MonoBehaviour
{
    public Camera sourceCamera; // Reference to the source camera.
    public Material targetMaterial; // Material of the object on which the image will be displayed.
    public RenderTexture renderTexture; // Render Texture for retransmitting the image.

    void Start()
    {
        // Create a Render Texture if it has not been assigned.
        if (renderTexture == null)
        {
            renderTexture = new RenderTexture(Screen.width, Screen.height, 24);
        }

        // Assign the Render Texture to the source camera.
        sourceCamera.targetTexture = renderTexture;

        // Assign the Render Texture as the texture of the object's material.
        targetMaterial.mainTexture = renderTexture;
    }
}

