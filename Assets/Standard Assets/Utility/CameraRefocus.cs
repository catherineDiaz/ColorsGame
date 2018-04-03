<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:e916e5da08ddf27c3e62fc921c5e4d946bd2d4c5f030491fcde5defaad0dfe0e
size 1335
=======
using System;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
    public class CameraRefocus
    {
        public Camera Camera;
        public Vector3 Lookatpoint;
        public Transform Parent;

        private Vector3 m_OrigCameraPos;
        private bool m_Refocus;


        public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
        {
            m_OrigCameraPos = origCameraPos;
            Camera = camera;
            Parent = parent;
        }


        public void ChangeCamera(Camera camera)
        {
            Camera = camera;
        }


        public void ChangeParent(Transform parent)
        {
            Parent = parent;
        }


        public void GetFocusPoint()
        {
            RaycastHit hitInfo;
            if (Physics.Raycast(Parent.transform.position + m_OrigCameraPos, Parent.transform.forward, out hitInfo,
                                100f))
            {
                Lookatpoint = hitInfo.point;
                m_Refocus = true;
                return;
            }
            m_Refocus = false;
        }


        public void SetFocusPoint()
        {
            if (m_Refocus)
            {
                Camera.transform.LookAt(Lookatpoint);
            }
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
