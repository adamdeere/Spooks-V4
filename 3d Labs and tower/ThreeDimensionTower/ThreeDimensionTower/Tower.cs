using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDimensionTower
{
    class Tower : GameWindow
    {
        public Tower()
             : base(
                1200, // Width
                700, // Height
                GraphicsMode.Default,
                "tower remaster",
                GameWindowFlags.Default,
                DisplayDevice.Default,
                3, // major
                3, // minor
                GraphicsContextFlags.ForwardCompatible
                )
        {

        }

        private int[] mVertexArrayObjectIDs = new int[3];
        private int[] HexagonArray = new int[2];
        private int[] SphereArray = new int[2];
        private int[] BoxArray = new int[2];
        private int[] CylinderArray = new int[2];
        public List<Cylinder> cylinderList = new List<Cylinder>();
        public List<Sphere> sphereList = new List<Sphere>();
        private int boxNumber = 0, sphereNumber = 1, cylinderNumber = 2;
        private ShaderUtility modelShader;
        private ShaderUtility boxShader;
        public ModelUtility MBox;
        public ModelUtility mSphere;
        public ModelUtility mCylinder;
        private Sphere sphere;
        private Box box;
        private Cylinder cylinder;
        private Matrix4 mView, uModel, uProjection;
        float intensity = 0;
        float pixelSixe = 500;
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            switch (e.KeyChar)
            {
                case 'a':
                    mView = mView * Matrix4.CreateTranslation(0.01f, 0, 0);
                    moveCam();
                    break;

                case 'd':
                    mView = mView * Matrix4.CreateTranslation(-0.01f, 0, 0);
                    moveCam();
                    break;

                case 'w':
                    mView = mView * Matrix4.CreateTranslation(0, 0.01f, 0);
                    moveCam();
                    break;
                case 'x':
                    mView = mView * Matrix4.CreateTranslation(0, -0.01f, 0);
                    moveCam();
                    break;
                case 'r':
                    Vector3 t = uModel.ExtractTranslation();
                    Matrix4 translation = Matrix4.CreateTranslation(t);
                    Matrix4 inverseTranslation = Matrix4.CreateTranslation(-t);
                    uModel = uModel * inverseTranslation * Matrix4.CreateRotationY(-0.025f) * translation;
                    break;

                case 't':
                     t = uModel.ExtractTranslation();
                     translation = Matrix4.CreateTranslation(t);
                     inverseTranslation = Matrix4.CreateTranslation(-t);
                    uModel = uModel * inverseTranslation * Matrix4.CreateRotationY(0.025f) * translation;
                    break;
                default:
                    break;
            }
        }

        private void moveCam()
        {
            int uView = GL.GetUniformLocation(boxShader.ShaderProgramID, "uView");
            GL.UniformMatrix4(uView, true, ref mView);
        }
      
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color4.CornflowerBlue);
            GL.Enable(EnableCap.CullFace);
            GL.Enable(EnableCap.DepthTest);
            mSphere = ModelUtility.LoadModel(@"Models/sphere.bin");
            mCylinder = ModelUtility.LoadModel(@"Models/cylinder.bin");
            MBox = ModelUtility.LoadModel(@"Models/TexturedCube.sjg");
            sphere = new Sphere(); box = new Box(MBox); cylinder = new Cylinder();

            int textureOne = box.LoadBoxTexture(@"Textures/texture2.jpg", TextureUnit.Texture0);
            boxShader = new ShaderUtility(@"Shaders/BoxVertexShader.vert", @"Shaders/BoxFragmentShader.frag");
            modelShader = new ShaderUtility(@"Shaders/vertexShader.vert", @"Shaders/fragmentShader.frag");
            GL.UseProgram(boxShader.ShaderProgramID);
            #region location variables for the box shader
            int uView = GL.GetUniformLocation(boxShader.ShaderProgramID, "uView");
            int boxPositionLocation = GL.GetAttribLocation(boxShader.ShaderProgramID, "boxVertexPosition");
            int uProjectionLocation = GL.GetAttribLocation(boxShader.ShaderProgramID, "uProjection");
            int uTextureSamplerLocation = GL.GetUniformLocation(boxShader.ShaderProgramID, "baseMap");
            int pixelSixeLocation = GL.GetUniformLocation(boxShader.ShaderProgramID, "pixelSize");
            int vTexCoordsLocation = GL.GetAttribLocation(boxShader.ShaderProgramID, "vTexCoords");
            int uLightDirectionLocation = GL.GetUniformLocation(boxShader.ShaderProgramID, "uLightDirection");
            int vNormalVlocation = GL.GetAttribLocation(boxShader.ShaderProgramID,"vNormal");
            int glowLocation = GL.GetUniformLocation(boxShader.ShaderProgramID, "glowColour");
            #endregion
            Vector3 normalisedLightDirection, lightDirection = new Vector3(1, 1, 1);
            Vector3.Normalize(ref lightDirection, out normalisedLightDirection);
            mView = Matrix4.CreateTranslation(0,0,-2);
            uProjection = Matrix4.CreatePerspectiveFieldOfView(1, (float)ClientRectangle.Width / ClientRectangle.Height, 0.5f, 5);

            #region linking variables for the box shader
            Vector4 glowColour = new Vector4(0, 2.0f, 0, 1.0f);
            GL.Uniform1(pixelSixeLocation, pixelSixe);
            GL.Uniform4(glowLocation, glowColour);
            GL.Uniform3(uLightDirectionLocation, normalisedLightDirection);
            GL.UniformMatrix4(uProjectionLocation, true, ref uProjection);
            GL.UniformMatrix4(uView, true, ref mView);
            GL.Uniform1(uTextureSamplerLocation, 0);
            #endregion
            box.LoadBoxData(BoxArray,mVertexArrayObjectIDs, boxNumber, boxPositionLocation, vTexCoordsLocation);
           // cylinder.LoadCylinderData(CylinderArray,mCylinder ,mVertexArrayObjectIDs, cylinderNumber, positionLocation, normalLocation);
         //   sphere.LoadSphereData(SphereArray, mVertexArrayObjectIDs,mSphere ,sphereNumber, positionLocation, normalLocation );

        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(ClientRectangle);
            if (boxShader != null)
            {
                int uProjectionLocation = GL.GetUniformLocation(boxShader.ShaderProgramID, "uProjection");
                int windowHeight = this.ClientRectangle.Height; int windowWidth = this.ClientRectangle.Width;
                if (windowHeight > windowWidth)
                {
                    if (windowWidth < 1) { windowWidth = 1; }
                    float ratio = windowHeight / windowWidth;
                    Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(1, (float)ClientRectangle.Width / ClientRectangle.Height, 0.5f, 5);
                    GL.UniformMatrix4(uProjectionLocation, true, ref projection);
                }
                else
                {
                    if (windowHeight < 1)
                    {
                        windowHeight = 1;
                    }
                    float ratio = windowWidth / windowHeight;
                    Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(1, (float)ClientRectangle.Width / ClientRectangle.Height, 0.5f, 5);
                    GL.UniformMatrix4(uProjectionLocation, true, ref projection);
                }
            }
        }
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            
            intensity += 0.001f;
            int instestiyLocation = GL.GetUniformLocation(boxShader.ShaderProgramID, "intentsity");
            GL.Uniform1(instestiyLocation, intensity);
            base.OnUpdateFrame(e);
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            //draws the first shape
            GL.BindVertexArray(mVertexArrayObjectIDs[boxNumber]);
            GL.CullFace(CullFaceMode.Front);
            int uModelLocation = GL.GetUniformLocation(boxShader.ShaderProgramID, "uModel");
            uModel = Matrix4.CreateScale(new Vector3(2, 4, 2)) * Matrix4.CreateRotationZ(0) * Matrix4.CreateTranslation(0, 0, 0);
            GL.UniformMatrix4(uModelLocation, true, ref uModel);
            GL.DrawElements(PrimitiveType.Triangles, 50, DrawElementsType.UnsignedInt, 0);

            //draws the second shape
           
            //draws the third shape

            //end of drawing
            GL.BindVertexArray(0);
            this.SwapBuffers();
        }
        protected override void OnUnload(EventArgs e)
        {
            base.OnUnload(e);
            GL.DeleteBuffers(2, HexagonArray);
            GL.DeleteBuffers(2, SphereArray);
            GL.DeleteBuffers(2, BoxArray);
            GL.DeleteBuffers(2, CylinderArray);
            GL.DeleteBuffers(2, mVertexArrayObjectIDs);
            GL.UseProgram(0);
            boxShader.Delete();
        }
    }
}
