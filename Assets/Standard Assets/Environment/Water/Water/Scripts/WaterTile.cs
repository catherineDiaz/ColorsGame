<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:07a9d6aa7a62188def4bb50445236dcf55cc60360c8bf25ecb0aa6a509670b4b
size 1555
=======
using System;
using UnityEngine;

namespace UnityStandardAssets.Water
{
    [ExecuteInEditMode]
    public class WaterTile : MonoBehaviour
    {
        public PlanarReflection reflection;
        public WaterBase waterBase;


        public void Start()
        {
            AcquireComponents();
        }


        void AcquireComponents()
        {
            if (!reflection)
            {
                if (transform.parent)
                {
                    reflection = transform.parent.GetComponent<PlanarReflection>();
                }
                else
                {
                    reflection = transform.GetComponent<PlanarReflection>();
                }
            }

            if (!waterBase)
            {
                if (transform.parent)
                {
                    waterBase = transform.parent.GetComponent<WaterBase>();
                }
                else
                {
                    waterBase = transform.GetComponent<WaterBase>();
                }
            }
        }


#if UNITY_EDITOR
        public void Update()
        {
            AcquireComponents();
        }
#endif


        public void OnWillRenderObject()
        {
            if (reflection)
            {
                reflection.WaterTileBeingRendered(transform, Camera.current);
            }
            if (waterBase)
            {
                waterBase.WaterTileBeingRendered(transform, Camera.current);
            }
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
