# Camera-Translating-Unity
=======================
```c#
using UnityEngine;

public class CameraRetransmissio : MonoBehaviour
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
```
=======================
## First - create monitor object.
=======================
![9](https://github.com/zaveshaa/Camera-Translating-Unity/assets/127344512/37587cca-d655-42b6-a7f4-791f76b5b518)
=======================
## Second - create render texture.
=======================
![10](https://github.com/zaveshaa/Camera-Translating-Unity/assets/127344512/94219d88-295d-4ad2-977d-1f1a665b3b98)
=======================
## Third - create camera from which the image will be transmitted.
=======================
![11](https://github.com/zaveshaa/Camera-Translating-Unity/assets/127344512/b503ca17-c9f1-4046-8149-8544eb80455c)
=======================
## Fourth - select moniotor object, create script, and paste code.
=======================
![12](https://github.com/zaveshaa/Camera-Translating-Unity/assets/127344512/24b458f1-a078-4191-94a8-d694dc451c64)
=======================
## Fifth - transfer into the script the camera, material, and render texture that you will apply to the monitor object.
=======================
![13](https://github.com/zaveshaa/Camera-Translating-Unity/assets/127344512/e876a32c-4083-4871-8dba-19d23441acb0)
=======================
## Thats all!
=======================
![14](https://github.com/zaveshaa/Camera-Translating-Unity/assets/127344512/8b6f7e90-6f6e-4d87-a8ee-2a8c767a6eef)
=======================
### Programm:
* unity 2022.3.9f1
* visual studio 2019 comercial


