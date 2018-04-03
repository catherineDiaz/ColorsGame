<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:648cece86174e9d5b5b2b2800fb03b478c4447c9724e34dcc80c8795d4649b7b
size 360
=======
using System;
using UnityEngine;


namespace UnityStandardAssets.Utility
{
    public class FollowTarget : MonoBehaviour
    {
        public Transform target;
        public Vector3 offset = new Vector3(0f, 7.5f, 0f);


        private void LateUpdate()
        {
            transform.position = target.position + offset;
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
