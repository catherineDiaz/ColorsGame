<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:a15354bc2f44bdd90a2ebab96ed181bf146250894d53087c2972b3fba078b7b5
size 934
=======
using System;
using UnityEngine;

namespace UnityStandardAssets.Water
{
    [ExecuteInEditMode]
    public class WaterBasic : MonoBehaviour
    {
        void Update()
        {
            Renderer r = GetComponent<Renderer>();
            if (!r)
            {
                return;
            }
            Material mat = r.sharedMaterial;
            if (!mat)
            {
                return;
            }

            Vector4 waveSpeed = mat.GetVector("WaveSpeed");
            float waveScale = mat.GetFloat("_WaveScale");
            float t = Time.time / 20.0f;

            Vector4 offset4 = waveSpeed * (t * waveScale);
            Vector4 offsetClamped = new Vector4(Mathf.Repeat(offset4.x, 1.0f), Mathf.Repeat(offset4.y, 1.0f),
                Mathf.Repeat(offset4.z, 1.0f), Mathf.Repeat(offset4.w, 1.0f));
            mat.SetVector("_WaveOffset", offsetClamped);
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
