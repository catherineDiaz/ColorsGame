<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:972d23328f702f2e287d74bdccea0dd6cc2eca0473929f8d4679652874032b79
size 440
=======
using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace UnityStandardAssets.Effects
{
    public class SmokeParticles : MonoBehaviour
    {
        public AudioClip[] extinguishSounds;


        private void Start()
        {
            GetComponent<AudioSource>().clip = extinguishSounds[Random.Range(0, extinguishSounds.Length)];
            GetComponent<AudioSource>().Play();
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
