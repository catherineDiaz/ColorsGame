<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:92471156353396ef963c756689d5d7d9c151081262b5d5bfbaff06df7aecf092
size 2340
=======
using System;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
    public class StandaloneInput : VirtualInput
    {
        public override float GetAxis(string name, bool raw)
        {
            return raw ? Input.GetAxisRaw(name) : Input.GetAxis(name);
        }


        public override bool GetButton(string name)
        {
            return Input.GetButton(name);
        }


        public override bool GetButtonDown(string name)
        {
            return Input.GetButtonDown(name);
        }


        public override bool GetButtonUp(string name)
        {
            return Input.GetButtonUp(name);
        }


        public override void SetButtonDown(string name)
        {
            throw new Exception(
                " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }


        public override void SetButtonUp(string name)
        {
            throw new Exception(
                " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }


        public override void SetAxisPositive(string name)
        {
            throw new Exception(
                " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }


        public override void SetAxisNegative(string name)
        {
            throw new Exception(
                " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }


        public override void SetAxisZero(string name)
        {
            throw new Exception(
                " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }


        public override void SetAxis(string name, float value)
        {
            throw new Exception(
                " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }


        public override Vector3 MousePosition()
        {
            return Input.mousePosition;
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
