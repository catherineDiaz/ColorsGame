<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:11507286c39278f064ced748c174ad27d272980077cee7bcd3839c061744c442
size 3489
=======
using System;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
    public class MobileInput : VirtualInput
    {
        private void AddButton(string name)
        {
            // we have not registered this button yet so add it, happens in the constructor
            CrossPlatformInputManager.RegisterVirtualButton(new CrossPlatformInputManager.VirtualButton(name));
        }


        private void AddAxes(string name)
        {
            // we have not registered this button yet so add it, happens in the constructor
            CrossPlatformInputManager.RegisterVirtualAxis(new CrossPlatformInputManager.VirtualAxis(name));
        }


        public override float GetAxis(string name, bool raw)
        {
            if (!m_VirtualAxes.ContainsKey(name))
            {
                AddAxes(name);
            }
            return m_VirtualAxes[name].GetValue;
        }


        public override void SetButtonDown(string name)
        {
            if (!m_VirtualButtons.ContainsKey(name))
            {
                AddButton(name);
            }
            m_VirtualButtons[name].Pressed();
        }


        public override void SetButtonUp(string name)
        {
            if (!m_VirtualButtons.ContainsKey(name))
            {
                AddButton(name);
            }
            m_VirtualButtons[name].Released();
        }


        public override void SetAxisPositive(string name)
        {
            if (!m_VirtualAxes.ContainsKey(name))
            {
                AddAxes(name);
            }
            m_VirtualAxes[name].Update(1f);
        }


        public override void SetAxisNegative(string name)
        {
            if (!m_VirtualAxes.ContainsKey(name))
            {
                AddAxes(name);
            }
            m_VirtualAxes[name].Update(-1f);
        }


        public override void SetAxisZero(string name)
        {
            if (!m_VirtualAxes.ContainsKey(name))
            {
                AddAxes(name);
            }
            m_VirtualAxes[name].Update(0f);
        }


        public override void SetAxis(string name, float value)
        {
            if (!m_VirtualAxes.ContainsKey(name))
            {
                AddAxes(name);
            }
            m_VirtualAxes[name].Update(value);
        }


        public override bool GetButtonDown(string name)
        {
            if (m_VirtualButtons.ContainsKey(name))
            {
                return m_VirtualButtons[name].GetButtonDown;
            }

            AddButton(name);
            return m_VirtualButtons[name].GetButtonDown;
        }


        public override bool GetButtonUp(string name)
        {
            if (m_VirtualButtons.ContainsKey(name))
            {
                return m_VirtualButtons[name].GetButtonUp;
            }

            AddButton(name);
            return m_VirtualButtons[name].GetButtonUp;
        }


        public override bool GetButton(string name)
        {
            if (m_VirtualButtons.ContainsKey(name))
            {
                return m_VirtualButtons[name].GetButton;
            }

            AddButton(name);
            return m_VirtualButtons[name].GetButton;
        }


        public override Vector3 MousePosition()
        {
            return virtualMousePosition;
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
