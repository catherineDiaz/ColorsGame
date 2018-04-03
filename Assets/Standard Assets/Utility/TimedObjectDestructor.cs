<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:a9b3e9fd975778b63fcb502fd9d69adeebd23bddfa1b122478ce944201e6c941
size 588
=======
using System;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
    public class TimedObjectDestructor : MonoBehaviour
    {
        [SerializeField] private float m_TimeOut = 1.0f;
        [SerializeField] private bool m_DetachChildren = false;


        private void Awake()
        {
            Invoke("DestroyNow", m_TimeOut);
        }


        private void DestroyNow()
        {
            if (m_DetachChildren)
            {
                transform.DetachChildren();
            }
            DestroyObject(gameObject);
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
