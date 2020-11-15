using System;
using OpenTK.Graphics.OpenGL;

namespace ThreeDimensionTower
{
    class Cylinder
    {
        
        public Cylinder()
        {
            
        }
        public void LoadCylinderData(int[] cylinderArray,ModelUtility cylinder, int[] mVertexArrayObjectIDs, int x, int location, int normlLocation)
        {
            #region load in vertices and indices
            GL.GenBuffers(2, cylinderArray);

            GL.BindBuffer(BufferTarget.ArrayBuffer, cylinderArray[0]);
            GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(cylinder.Vertices.Length * sizeof(float)), cylinder.Vertices, BufferUsageHint.StaticDraw);

            int size;
            GL.GetBufferParameter(BufferTarget.ArrayBuffer, BufferParameterName.BufferSize, out size);

            if (cylinder.Vertices.Length * sizeof(float) != size)
            {
                throw new ApplicationException("Vertex data not loaded onto graphics card correctly");
            }

            GL.BindBuffer(BufferTarget.ElementArrayBuffer, cylinderArray[1]);
            GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(cylinder.Indices.Length * sizeof(uint)), cylinder.Indices, BufferUsageHint.StaticDraw);

            GL.GetBufferParameter(BufferTarget.ElementArrayBuffer, BufferParameterName.BufferSize, out size);

            if (cylinder.Indices.Length * sizeof(uint) != size)
            {
                throw new ApplicationException("Index data not loaded onto graphics card correctly");
            }
            #endregion
            BindCylinderData(mVertexArrayObjectIDs, x, cylinderArray, location, normlLocation);
        }
        public void BindCylinderData(int[] mVertexArrayObjectIDs, int x, int[] cylinderArray, int location, int normlLocation)
        {
            //bind the stuff to the first array
            GL.GenVertexArrays(2, mVertexArrayObjectIDs);

            GL.BindVertexArray(mVertexArrayObjectIDs[x]);
            GL.BindBuffer(BufferTarget.ArrayBuffer, cylinderArray[0]);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, cylinderArray[1]);
            GL.VertexAttribPointer(normlLocation, 3, VertexAttribPointerType.Float, false, 6 * sizeof(float), 3 * sizeof(float));
            GL.VertexAttribPointer(location, 3, VertexAttribPointerType.Float, false, 6 * sizeof(float), 0);
            GL.EnableVertexAttribArray(normlLocation);
            GL.EnableVertexAttribArray(location);
            //sort out stride etc
        }
    }
}
