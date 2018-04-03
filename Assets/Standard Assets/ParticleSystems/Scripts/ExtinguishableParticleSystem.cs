<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:36fc5f48599a88102facfbb09929241b7281e8f890b1d9ccdda9aa8c8b76c982
size 599
=======
using System;
using UnityEngine;


namespace UnityStandardAssets.Effects
{
    public class ExtinguishableParticleSystem : MonoBehaviour
    {
        public float multiplier = 1;

        private ParticleSystem[] m_Systems;


        private void Start()
        {
            m_Systems = GetComponentsInChildren<ParticleSystem>();
        }


        public void Extinguish()
        {
            foreach (var system in m_Systems)
            {
                var emission = system.emission;
                emission.enabled = false;
            }
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
