<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:c4929f5c61eb5e04a4718432bc7fdce202f71b9c3e2703e2d8e6746901608646
size 1160
=======
using System;
using UnityEngine;

namespace UnityStandardAssets.Cameras
{
    public class HandHeldCam : LookatTarget
    {
        [SerializeField] private float m_SwaySpeed = .5f;
        [SerializeField] private float m_BaseSwayAmount = .5f;
        [SerializeField] private float m_TrackingSwayAmount = .5f;
        [Range(-1, 1)] [SerializeField] private float m_TrackingBias = 0;


        protected override void FollowTarget(float deltaTime)
        {
            base.FollowTarget(deltaTime);

            float bx = (Mathf.PerlinNoise(0, Time.time*m_SwaySpeed) - 0.5f);
            float by = (Mathf.PerlinNoise(0, (Time.time*m_SwaySpeed) + 100)) - 0.5f;

            bx *= m_BaseSwayAmount;
            by *= m_BaseSwayAmount;

            float tx = (Mathf.PerlinNoise(0, Time.time*m_SwaySpeed) - 0.5f) + m_TrackingBias;
            float ty = ((Mathf.PerlinNoise(0, (Time.time*m_SwaySpeed) + 100)) - 0.5f) + m_TrackingBias;

            tx *= -m_TrackingSwayAmount*m_FollowVelocity.x;
            ty *= m_TrackingSwayAmount*m_FollowVelocity.y;

            transform.Rotate(bx + tx, by + ty, 0);
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
