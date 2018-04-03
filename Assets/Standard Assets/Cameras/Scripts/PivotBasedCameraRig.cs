<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:88e3ea4c7db85d320bf5242481e76fd500c6ef652361daa4323adba2a92db477
size 815
=======
using System;
using UnityEngine;


namespace UnityStandardAssets.Cameras
{
    public abstract class PivotBasedCameraRig : AbstractTargetFollower
    {
        // This script is designed to be placed on the root object of a camera rig,
        // comprising 3 gameobjects, each parented to the next:

        // 	Camera Rig
        // 		Pivot
        // 			Camera

        protected Transform m_Cam; // the transform of the camera
        protected Transform m_Pivot; // the point at which the camera pivots around
        protected Vector3 m_LastTargetPosition;


        protected virtual void Awake()
        {
            // find the camera in the object hierarchy
            m_Cam = GetComponentInChildren<Camera>().transform;
            m_Pivot = m_Cam.parent;
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
