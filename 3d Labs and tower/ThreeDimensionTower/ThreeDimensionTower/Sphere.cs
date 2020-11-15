using System;
using OpenTK.Graphics.OpenGL;
namespace ThreeDimensionTower
{
    class Sphere
    {
        
        public Sphere()
        {
           
        }
        public void LoadSphereData(int[] SphereArray, ModelUtility sphere, int[] mVertexArrayObjectIDs, int x, int location, int normlLocation)
        {
            #region load in vertices and indices
            GL.GenBuffers(2, SphereArray);

            GL.BindBuffer(BufferTarget.ArrayBuffer, SphereArray[0]);
            GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(sphere.Vertices.Length * sizeof(float)), sphere.Vertices, BufferUsageHint.StaticDraw);

            int size;
            GL.GetBufferParameter(BufferTarget.ArrayBuffer, BufferParameterName.BufferSize, out size);

            if (sphere.Vertices.Length * sizeof(float) != size)
            {
                throw new ApplicationException("Vertex data not loaded onto graphics card correctly");
            }

            GL.BindBuffer(BufferTarget.ElementArrayBuffer, SphereArray[1]);
            GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(sphere.Indices.Length * sizeof(uint)), sphere.Indices, BufferUsageHint.StaticDraw);

            GL.GetBufferParameter(BufferTarget.ElementArrayBuffer, BufferParameterName.BufferSize, out size);

            if (sphere.Indices.Length * sizeof(uint) != size)
            {
                throw new ApplicationException("Index data not loaded onto graphics card correctly");
            }
            #endregion
            BindSphereData(mVertexArrayObjectIDs, x, SphereArray, location, normlLocation);
        }
        public void BindSphereData(int[] mVertexArrayObjectIDs, int x, int[] sphereArray, int location, int normlLocation)
        {
            //bind the stuff to the first array
            GL.GenVertexArrays(2, mVertexArrayObjectIDs);

            GL.BindVertexArray(mVertexArrayObjectIDs[x]);
            GL.BindBuffer(BufferTarget.ArrayBuffer, sphereArray[0]);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, sphereArray[1]);
            GL.VertexAttribPointer(normlLocation, 3, VertexAttribPointerType.Float, false, 6 * sizeof(float), 3 * sizeof(float));
            GL.VertexAttribPointer(location, 3, VertexAttribPointerType.Float, false, 6 * sizeof(float), 0);
            GL.EnableVertexAttribArray(normlLocation);
            GL.EnableVertexAttribArray(location);
            //sort out stride etc
        }
        
    }
}
