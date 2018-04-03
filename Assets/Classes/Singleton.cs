<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:a5e816c25fcbf5e741ad99bb15cbf86e1257514d4fc0452eab155474114696ea
size 705
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component {

	private static T instance;
	public static T Instance {
		get {
			if (instance == null) {
				instance = FindObjectOfType<T> ();
				if (instance == null) { // if there is no singleton in the scene then make one
					GameObject obj = new GameObject (); // create gameobject
					obj.name = typeof(T).Name;
					instance = obj.AddComponent<T>();
				}
			}
			return instance;
		}
	}

	public virtual void Awake ()
	{
		if (instance == null) {
			instance = this as T;
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (gameObject);
		}
	}
}



>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
