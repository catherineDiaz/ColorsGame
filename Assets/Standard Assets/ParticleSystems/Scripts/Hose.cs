<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:c5844e22fde80da81713d93a2cb1c3a862421d7601cb3229bef70efe37635b4a
size 1050
=======
using System;
using UnityEngine;


namespace UnityStandardAssets.Effects
{
    public class Hose : MonoBehaviour
    {
        public float maxPower = 20;
        public float minPower = 5;
        public float changeSpeed = 5;
        public ParticleSystem[] hoseWaterSystems;
        public Renderer systemRenderer;

        private float m_Power;


        // Update is called once per frame
        private void Update()
        {
            m_Power = Mathf.Lerp(m_Power, Input.GetMouseButton(0) ? maxPower : minPower, Time.deltaTime*changeSpeed);

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                systemRenderer.enabled = !systemRenderer.enabled;
            }

            foreach (var system in hoseWaterSystems)
            {
				ParticleSystem.MainModule mainModule = system.main;
                mainModule.startSpeed = m_Power;
                var emission = system.emission;
                emission.enabled = (m_Power > minPower*1.1f);
            }
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
