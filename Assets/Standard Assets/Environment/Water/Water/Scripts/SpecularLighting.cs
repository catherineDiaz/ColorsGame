<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:8efe4351abfb1e260fea4fbd0bc389a02bef18085e390a98d767a04c70267b2b
size 832
=======
using System;
using UnityEngine;

namespace UnityStandardAssets.Water
{
    [RequireComponent(typeof(WaterBase))]
    [ExecuteInEditMode]
    public class SpecularLighting : MonoBehaviour
    {
        public Transform specularLight;
        private WaterBase m_WaterBase;


        public void Start()
        {
            m_WaterBase = (WaterBase)gameObject.GetComponent(typeof(WaterBase));
        }


        public void Update()
        {
            if (!m_WaterBase)
            {
                m_WaterBase = (WaterBase)gameObject.GetComponent(typeof(WaterBase));
            }

            if (specularLight && m_WaterBase.sharedMaterial)
            {
                m_WaterBase.sharedMaterial.SetVector("_WorldLightDir", specularLight.transform.forward);
            }
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
