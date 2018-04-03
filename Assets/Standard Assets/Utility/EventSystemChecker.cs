<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:d211775c9eedf581241e91ff1420d42fb14f20a7b84cc24a6bf7dd2ee3e03e3e
size 542
=======
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventSystemChecker : MonoBehaviour
{
    //public GameObject eventSystem;

	// Use this for initialization
	void Awake ()
	{
	    if(!FindObjectOfType<EventSystem>())
        {
           //Instantiate(eventSystem);
            GameObject obj = new GameObject("EventSystem");
            obj.AddComponent<EventSystem>();
            obj.AddComponent<StandaloneInputModule>().forceModuleActive = true;
        }
	}
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
