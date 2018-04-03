<<<<<<< HEAD
version https://git-lfs.github.com/spec/v1
oid sha256:2450dc6e90dc1f0416694f286bcddecd12547cfca2ca7dc3ff273bcb517a18e1
size 511
=======
using System;
using UnityEngine;

namespace UnityStandardAssets.Water
{
    public class MeshContainer
    {
        public Mesh mesh;
        public Vector3[] vertices;
        public Vector3[] normals;


        public MeshContainer(Mesh m)
        {
            mesh = m;
            vertices = m.vertices;
            normals = m.normals;
        }


        public void Update()
        {
            mesh.vertices = vertices;
            mesh.normals = normals;
        }
    }
}
>>>>>>> 69bef140a0eed029aae24974c9e5e6b45b06b028
