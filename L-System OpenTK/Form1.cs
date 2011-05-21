//Copyright (c) 2011 E.Laverick

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in
//all copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;
using OpenTK;

namespace L_System_OpenTK
{
    public partial class Form1 : Form
    {
        private l_system lSystem = new l_system();                          // The L-System
        private List<Vector3> vertices = new List<Vector3>();               // The vertices that create the VBO
        private Stack<Vector4> vertexStack = new Stack<Vector4>();          // The stack, used for push and pop rules
        private float turtleAngle=0.0f, turtleX = 0.0f, turtleY = 0.0f;     // Turtle variables - The turtle is used for drawing

        private int vboHandle = 0;                                          // Handle to the VBO

        private bool loaded = false;                                        // Used to ensure rendering happens once the control is ready

        public Form1()
        {
            InitializeComponent();
        }

        private void calcPoints(string theString)                           // Apply rules to create vertex array
        {
            // If command strings are comma delimited then remove the commas
            string forward = util.ConvertStringArrayToString(txtForwards.Text.Split(','));
            string left = util.ConvertStringArrayToString(txtLeft.Text.Split(','));
            string right = util.ConvertStringArrayToString(txtRight.Text.Split(','));
            string push = util.ConvertStringArrayToString(txtPush.Text.Split(','));
            string pop = util.ConvertStringArrayToString(txtPop.Text.Split(','));

            float angle;            // Used to hold the angle needed for each turn
            int distance = 1;       // Alter this to change the size of the shape you draw

            bool stackPush = false; // Used to track if we're pushing drawing steps to the stack
            float pushLevel = 0.0f; // Used to keep track of the current level of the stack



            if (!float.TryParse(txtAngle.Text, out angle))  // Convert the text in the field to a valid floating point number
            {
                MessageBox.Show("Error", "Angle must be an number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            vertexStack.Clear();                            // Reset the vertexStack
            vertices.Clear();                               // Reset the current drawing array
            turtleX = turtleY = turtleAngle = 0.0f;         // Reset the turtle to the centre of the screen

            foreach (char c in theString)                   // Loop through the string
            {
                foreach (char lc in left)                   // Loop through potential left commands
                {
                    if (c == lc)                            // Check if the current command is a left
                    {
                        turtleAngle -= angle;               // Turn turtle left by angle;
                    }
                }
                foreach (char rc in right)                  // Loop through potential right commands
                {
                    if (c == rc)                            // Check if the current command is a right
                    {
                        turtleAngle += angle;               // Turn turtle right by angle;
                    }
                }
                foreach (char p in push)                    // Loop through potential stack push commands
                {
                    if (c == p)                             // Check if the current command is a stack push
                    {
                        stackPush = true;                   // Record stack push mode
                        pushLevel++;                        // Increment stack push count
                        vertexStack.Push(new Vector4(turtleX, turtleY, turtleAngle, pushLevel));    // Push the current state to the stack
                    }
                }
                foreach (char p in pop)                     // Loop through potential stack pop commands
                {
                    if (c == p)                             // Check if the current command is a stack push
                    {
                        Vector4 turtleState;                // Create a temporary repository for the turtle states popped from the stack
                        bool stackEmpty = false;            // Check if the stack is empty
                        int i = 0;                          // Loop index value

                        if (vertexStack.Count > 0)          // Check that the stack is populated
                        {
                            turtleState = vertexStack.Pop();                        // Pop the top item off the stack to the temporary turtleState
                            while (turtleState.W == pushLevel)                      // Check that we're popping off the correct state
                            {
                                i++;                                                // Increment loop index
                                turtleX = turtleState.X;                            // Set the turtle position to popped turtle state
                                turtleY = turtleState.Y;
                                turtleAngle = turtleState.Z;
                                vertices.Add(new Vector3(turtleX, turtleY, 0.0f));  // Register the popped state in the vertex list - as the lines form 
                                                                                    // a loop, this ensures that we retrace our steps... think etcha-sketch
                                if (vertexStack.Count > 0)                          // Check if the stack is still populated
                                    turtleState = vertexStack.Pop();                // Pop the next element for the next iteration of the loop
                                else
                                {
                                    stackEmpty = true;                              // Otherwise mark the stack as empty...
                                    break;                                          // ... and exit the loop
                                }
                            }
                            if (!stackEmpty)                                        // If we didn't empty the stack then we're gurrenteed to have popped
                                vertexStack.Push(turtleState);                      // a state from outside our own range.  So we put it back.

                            pushLevel--;                                            // Decrement the current pushLevel
                        }
                    }
                }
                foreach (char fc in forward)                                        // Loop through potential draw forward commands
                {
                    if (c == fc)                                                    // Check if the current command is a draw forward
                    {
                        float cos = (float)Math.Cos(util.DegreeToRadian(turtleAngle));  // Calculate the co-sine of our turtle angle
                        float sin = (float)Math.Sin(util.DegreeToRadian(turtleAngle));  // Calculate the sine of our turtle angle

                        turtleX += cos * distance;                                      // Current X position + cosine * direction give our new X coord
                        turtleY += sin * distance;                                      // Current Y position + sine * direction give our new X coord

                        vertices.Add(new Vector3(turtleX, turtleY, 0.0f));              // Add our new position to the vertex array
                        if(stackPush)                                                                   // Are we in stack push mode
                            vertexStack.Push(new Vector4(turtleX, turtleY, turtleAngle, pushLevel));    // If so then push this operation onto the stack
                    }
                }

            }
        }

        private void cmdRun_Click(object sender, EventArgs e)
        {
            int iterations = 0;
            lSystem.calcRules(txtRule.Text);                            // Calculate the rules

            if (Int32.TryParse(txtIterations.Text, out iterations))     // Convert Iterations to an integer
            {
                for (int i = 0; i < iterations; i++)                    // Run the iteration X amount of times
                    txtString.Text = lSystem.iterateString(txtString.Text);     // Perform the iteration of the string via the rules

                calcPoints(txtString.Text);                             // Calculate the VBO
                glControl.Invalidate();                                 // Force rendering
            }
            else
                MessageBox.Show("Error", "Please enter a positive integer", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void glControl_Load(object sender, EventArgs e)
        {
            loaded = true;
            GL.ClearColor(Color.Black);
            GL.ShadeModel(ShadingModel.Smooth);

            SetupViewport();

            createVBO(ref vboHandle);   // Create the VBO
        }

        private void createVBO(ref int vboID)
        {
            GL.EnableClientState(ArrayCap.VertexArray);                     // Enable VBOs

            GL.GenBuffers(1, out vboID);                                    // Generate our buffer
            GL.BindBuffer(BufferTarget.ArrayBuffer, vboID);                 // Bind the buffer to the ID
            GL.VertexPointer(3, VertexPointerType.Float, 0, (IntPtr)0);     // Define the vertex array
        }

        private void drawVBO(Vector3[] points)
        {
            GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(12 * points.Length), IntPtr.Zero, BufferUsageHint.StreamDraw); // Clear the old buffer
            GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(12 * points.Length), points, BufferUsageHint.StreamDraw); // Upload the new buffer
            GL.DrawArrays(BeginMode.LineStrip, 0, points.Length); // Draw the Array in LineStrip mode
        }

        private void SetupViewport()
        {
            int w = glControl.ClientSize.Width;
            int h = glControl.ClientSize.Height;

            GL.Viewport(0, 0, w, h);

            float aspect = w / (float)h;

            Matrix4 projection_matrix;

            Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, aspect, 1, 100, out projection_matrix);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection_matrix);
        }

        private void glControl_Paint(object sender, PaintEventArgs e)
        {
            if (!loaded) // Check if we're initialised enough for rendering
                return;

            Matrix4 lookat = Matrix4.LookAt(0, 0, 96, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.Color3(Color.White);

            if (vertices.Count > 1)
                drawVBO(vertices.ToArray());

            glControl.SwapBuffers();
        }

        private void glControl_Resize(object sender, EventArgs e)
        {
            SetupViewport();
            glControl.Invalidate();
        }
    }
}
