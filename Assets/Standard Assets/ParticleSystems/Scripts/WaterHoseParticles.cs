<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:168028495dab87dcf68ff96e1ae7e2f3c544d0e2c6624c75672dc45f4d7498ee
size 1458
=======
using System;
using UnityEngine;
using System.Collections.Generic;

namespace UnityStandardAssets.Effects
{
    public class WaterHoseParticles : MonoBehaviour
    {
        public static float lastSoundTime;
        public float force = 1;


        private List<ParticleCollisionEvent> m_CollisionEvents = new List<ParticleCollisionEvent>();
        private ParticleSystem m_ParticleSystem;


        private void Start()
        {
            m_ParticleSystem = GetComponent<ParticleSystem>();
        }


        private void OnParticleCollision(GameObject other)
        {
            int numCollisionEvents = m_ParticleSystem.GetCollisionEvents(other, m_CollisionEvents);
            int i = 0;

            while (i < numCollisionEvents)
            {
                if (Time.time > lastSoundTime + 0.2f)
                {
                    lastSoundTime = Time.time;
                }

                var col = m_CollisionEvents[i].colliderComponent;
                var attachedRigidbody = col.GetComponent<Rigidbody>();
                if (attachedRigidbody != null)
                {
                    Vector3 vel = m_CollisionEvents[i].velocity;
                    attachedRigidbody.AddForce(vel*force, ForceMode.Impulse);
                }

                other.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);

                i++;
            }
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
