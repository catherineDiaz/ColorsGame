<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:f0ab722c89f10a4237a22aba77294943c9952db3d43dfe47a20d1944f097148a
size 2946
=======
using System;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
    [RequireComponent(typeof (SphereCollider))]
    public class AfterburnerPhysicsForce : MonoBehaviour
    {
        public float effectAngle = 15;
        public float effectWidth = 1;
        public float effectDistance = 10;
        public float force = 10;

        private Collider[] m_Cols;
        private SphereCollider m_Sphere;


        private void OnEnable()
        {
            m_Sphere = (GetComponent<Collider>() as SphereCollider);
        }


        private void FixedUpdate()
        {
            m_Cols = Physics.OverlapSphere(transform.position + m_Sphere.center, m_Sphere.radius);
            for (int n = 0; n < m_Cols.Length; ++n)
            {
                if (m_Cols[n].attachedRigidbody != null)
                {
                    Vector3 localPos = transform.InverseTransformPoint(m_Cols[n].transform.position);
                    localPos = Vector3.MoveTowards(localPos, new Vector3(0, 0, localPos.z), effectWidth*0.5f);
                    float angle = Mathf.Abs(Mathf.Atan2(localPos.x, localPos.z)*Mathf.Rad2Deg);
                    float falloff = Mathf.InverseLerp(effectDistance, 0, localPos.magnitude);
                    falloff *= Mathf.InverseLerp(effectAngle, 0, angle);
                    Vector3 delta = m_Cols[n].transform.position - transform.position;
                    m_Cols[n].attachedRigidbody.AddForceAtPosition(delta.normalized*force*falloff,
                                                                 Vector3.Lerp(m_Cols[n].transform.position,
                                                                              transform.TransformPoint(0, 0, localPos.z),
                                                                              0.1f));
                }
            }
        }


        private void OnDrawGizmosSelected()
        {
            //check for editor time simulation to avoid null ref
            if(m_Sphere == null)
                m_Sphere = (GetComponent<Collider>() as SphereCollider);

            m_Sphere.radius = effectDistance*.5f;
            m_Sphere.center = new Vector3(0, 0, effectDistance*.5f);
            var directions = new Vector3[] {Vector3.up, -Vector3.up, Vector3.right, -Vector3.right};
            var perpDirections = new Vector3[] {-Vector3.right, Vector3.right, Vector3.up, -Vector3.up};
            Gizmos.color = new Color(0, 1, 0, 0.5f);
            for (int n = 0; n < 4; ++n)
            {
                Vector3 origin = transform.position + transform.rotation*directions[n]*effectWidth*0.5f;

                Vector3 direction =
                    transform.TransformDirection(Quaternion.AngleAxis(effectAngle, perpDirections[n])*Vector3.forward);

                Gizmos.DrawLine(origin, origin + direction*m_Sphere.radius*2);
            }
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
