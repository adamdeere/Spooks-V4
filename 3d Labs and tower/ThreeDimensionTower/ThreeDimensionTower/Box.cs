using System;
using OpenTK.Graphics.OpenGL;
using System.Drawing.Imaging;
using System.Drawing;

namespace ThreeDimensionTower
{
    class Box
    {
        public ModelUtility box;
        public Box(ModelUtility inbox)
        {
            box = inbox;
        }
        public void LoadBoxData(int[] boxArray, int[] mVertexArrayObjectIDs, int x,  int location, int texCoords)
        {
            #region load in vertices and indices
            GL.GenBuffers(2, boxArray);

            GL.BindBuffer(BufferTarget.ArrayBuffer, boxArray[0]);
            GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(box.Vertices.Length * sizeof(float)), box.Vertices, BufferUsageHint.StaticDraw);

            int size;
            GL.GetBufferParameter(BufferTarget.ArrayBuffer, BufferParameterName.BufferSize, out size);

            if (box.Vertices.Length * sizeof(float) != size)
            {
                throw new ApplicationException("Vertex data not loaded onto graphics card correctly");
            }

            GL.BindBuffer(BufferTarget.ElementArrayBuffer, boxArray[1]);
            GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(box.Indices.Length * sizeof(uint)), box.Indices, BufferUsageHint.StaticDraw);

            GL.GetBufferParameter(BufferTarget.ElementArrayBuffer, BufferParameterName.BufferSize, out size);

            if (box.Indices.Length * sizeof(uint) != size)
            {
                throw new ApplicationException("Index data not loaded onto graphics card correctly");
            }
            #endregion
            BindBoxData(mVertexArrayObjectIDs, x, boxArray, location, texCoords);
        }
        public void BindBoxData(int[] mVertexArrayObjectIDs, int x, int[] boxArray, int location, int texCoords)
        {
            //bind the stuff to the first array
            GL.GenVertexArrays(2, mVertexArrayObjectIDs);

            GL.BindVertexArray(mVertexArrayObjectIDs[x]);
            GL.BindBuffer(BufferTarget.ArrayBuffer, boxArray[0]);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, boxArray[1]);
            GL.VertexAttribPointer(texCoords, 2, VertexAttribPointerType.Float, false, 5 * sizeof(float), 3 * sizeof(float));
            GL.VertexAttribPointer(location, 3, VertexAttribPointerType.Float, false, 5 * sizeof(float), 0);
            GL.EnableVertexAttribArray(texCoords);
            GL.EnableVertexAttribArray(location);
            //sort out stride etc
        }
        public int LoadBoxTexture(string filepath, TextureUnit tex)
        {
            
            int mTexture_ID;
            Bitmap TextureBitmap;
            BitmapData TextureData;
            if (System.IO.File.Exists(filepath))
            {
                 TextureBitmap = new Bitmap(filepath);
                 TextureData = TextureBitmap.LockBits(new System.Drawing.Rectangle(0, 0, TextureBitmap.Width, 
                    TextureBitmap.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            } else { throw new Exception("Could not find file " + filepath); }

            GL.ActiveTexture(tex);
            GL.GenTextures(1, out mTexture_ID);
            GL.BindTexture(TextureTarget.Texture2D, mTexture_ID);

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, TextureData.Width, TextureData.Height, 0, 
                OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, TextureData.Scan0);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);

            TextureBitmap.UnlockBits(TextureData);
            return mTexture_ID;
        }
    }
}
