<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:29fcdf468be0bcfc110a5d326c3c62b3aa73a63a67d6d9cc785a7ac35a69ae02
size 353
=======
using System;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class InputAxisScrollbar : MonoBehaviour
    {
        public string axis;

	    void Update() { }

	    public void HandleInput(float value)
        {
            CrossPlatformInputManager.SetAxis(axis, (value*2f) - 1f);
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
