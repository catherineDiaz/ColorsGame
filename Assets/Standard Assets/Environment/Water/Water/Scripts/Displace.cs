<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:3dc252de5543443c3f12300fc704b7c331e84eea30fb56b918d864f43fdc86a7
size 806
=======
using System;
using UnityEngine;

namespace UnityStandardAssets.Water
{
    [ExecuteInEditMode]
    [RequireComponent(typeof(WaterBase))]
    public class Displace : MonoBehaviour
    {
        public void Awake()
        {
            if (enabled)
            {
                OnEnable();
            }
            else
            {
                OnDisable();
            }
        }


        public void OnEnable()
        {
            Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
            Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");
        }


        public void OnDisable()
        {
            Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");
            Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
