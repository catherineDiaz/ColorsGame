<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:2e002d5f38910d761f68fde28ca8dcc0844ab3472ef43c184a73a6224036045e
size 816
=======
using System;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
    public class ParticleSystemMultiplier : MonoBehaviour
    {
        // a simple script to scale the size, speed and lifetime of a particle system

        public float multiplier = 1;


        private void Start()
        {
            var systems = GetComponentsInChildren<ParticleSystem>();
            foreach (ParticleSystem system in systems)
            {
				ParticleSystem.MainModule mainModule = system.main;
				mainModule.startSizeMultiplier = multiplier;
                mainModule.startSpeedMultiplier = multiplier;
                mainModule.startLifetimeMultiplier = Mathf.Lerp(multiplier, 1, 0.5f);
                system.Clear();
                system.Play();
            }
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
