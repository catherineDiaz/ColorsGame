<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:0047694160f759ad827223b658e8d4d008c5dcbd2c8526404562f8adb45e1c1e
size 489
=======
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof (GUITexture))]
public class ForcedReset : MonoBehaviour
{
    private void Update()
    {
        // if we have forced a reset ...
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
        {
            //... reload the scene
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
