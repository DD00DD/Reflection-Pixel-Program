using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// *************************************************************************
//        PROGRAMMER: Derek Dao                         DATE: Oct 23, 2020
// 
//      PROGRAM NAME: Reflection Pixel Program
//  
//   PROGRAM OUTLINE: 
//                    1. The program will initially load in message box. It contains
//                       instruction for using the program.
// 
//                    2. A colour check method will occur. It will review the option
//                       that the user has chosen. The colour values red, green, and blue will 
//                       be given a specific value or a random one (if random colour is chosen)
//                       to produce a colour. 
//                      
//                    3. A method called DrawTypeCheck will occur. This method reviews the user's
//                       option for how a shape is produced. A shape can either be generated normally,
//                       or with straight lines.
//
//                    4. A shape check method will occur. It will take the colour input and draw type input
//                       as its parameter. The method will check which shape the user has chosen to produce.
//                       The ShapeCheck method will also check for the random shape option. If chosen,
//                       it will produce a random number from 0 to 7. Each number between 0 to 7 
//                       will produce a specific shape (number 0 produces a square).
//
//                    5. A method named CreateAxis will be called. It will generate an axis 
//                       of symmetry at the halfway point to produce a reflection 
//                       between the two shapes.
//
//                    6. A create method will be called. The shape that will be created 
//                       is dependant on the choice of the user. However, if random shape
//                       is chosen, any shape method can be called.
//
//                    7. Once the reflection is produced, a message box will appear to
//                       notify the user that the results has been displayed.
//
// *************************************************************************
//                      Test Cases:
//
//  1. Input:  Colour - Yellow, 
//             Shape - Triangle, 
//             Drawing Type - Normal
//
//     Output: Message box notify the user about the generated reflection
//             "The reflection have loaded."
//             Select new options and press the button again for another reflection!
//
//             Picturebox Display:
//             A solid yellow triangle
//  
//  2. Input:  Colour - Blue, 
//             Shape - Arrow, 
//             Drawing Type - Lines
//
//     Output: Message box notify the user about the generated reflection
//             "The reflection have loaded."
//             Select new options and press the button again for another reflection!
//
//             Picturebox Display:
//             A blue arrow made of out lines
//
//  3. Input:  Colour - random, 
//             Shape - random, 
//             Drawing Type - Lines
//
//     Output: Message box notify the user about the generated reflection
//             "The reflection have loaded."
//             Select new options and press the button again for another reflection!
//
//             Picturebox Display:
//             A random colour shape made of out lines
//
// *************************************************************************

namespace PixelProgram
{
    public partial class PixelProgram : Form
    {    
        public PixelProgram()
        {
            InitializeComponent();
        }

        // This load event display a message box with instructions when the program is loaded.
        private void PixelProgram_Load(object sender, EventArgs e)
        {
            // A message box that displays the instructions to produce a reflection.
            // This message box is displayed when the program is initiated.
            MessageBox.Show("Pick a COLOUR, SHAPE, and DRAWING TYPE to produce a reflection!", "INSTRUCTIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // This click event obtains the user's choices to produce the specified shape.
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            // The ShapeCheck method will be called when the load button recieves a click. 
            // The methods identified as the parameters of the ShapeCheck method are called first 
            // in order to get the user's colour and drawing type of choice.
            ShapeCheck(ColourCheck(), DrawTypeCheck());

            // A message box that notify the user that a reflection has been produced.
            MessageBox.Show("The reflection have loaded.\nSelect new options and press the button again for another reflection!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // The ColourCheck method will obtain the user's colour of choice.
        private int[] ColourCheck()
        {
            // The rgb values of a colour are placed into an array.
            // The array rgb values are at 0 by default. As a result,
            // the default colour is black.
            int[] values = {0, 0, 0};

            // If the random colour option is chosen, this random value will be used 
            // for generating random rgb values to produce a random colour.
            Random rand = new Random();

            // If the colour red is chosen, the rgb values will be given 
            // a sequence of numbers to produce the colour red.
            // The same will occur for the other colours as well.
            if(rdbRed.Checked == true)
            {
                values[0] = 255;
            }

            else if (rdbBlue.Checked == true)
            {
                values[2] = 255;
            }

            else if (rdbGreen.Checked == true)
            {
                values[1] = 255;
            }

            else if (rdbYellow.Checked == true)
            {
                values[0] = 255;
                values[1] = 255;
            }

            else if (rdbPurple.Checked == true)
            {
                values[0] = 255;
                values[2] = 255;
            }

            else if (rdbPink.Checked == true)
            {
                values[0] = 255;
                values[1] = 192;
                values[2] = 203;
            }

            else if (rdbWhite.Checked == true)
            {
                values[0] = 255;
                values[1] = 255;
                values[2] = 255;
            }

            // When the random colour option is chosen,
            // Each rgb value will produce a number from 0 to 255.
            else if(rdbRandColour.Checked == true)
            {
                values[0] = rand.Next(256);
                values[1] = rand.Next(256);
                values[2] = rand.Next(256);
            }

            // The array value will return everytime to allow the ShapeCheck method to
            // use the chosen colour.
            return values;
        }

        // The DrawTypeCheck method will obtain the user's drawing type.
        private int DrawTypeCheck()
        {
            // The default drawing type is the normal option.
            // As a result, the value of drawtype is 1.
            int drawtype = 1;

            // If the user chose the lines option, the drawtype will
            // be 10. This allows the pixels to produce a line pattern
            // that will resemble the chosen shape.
            if (rdbLines.Checked == true)
            {
                drawtype = 10;
            }

            // The drawing type will always be returned as a 
            // parameter of the method ShapeCheck.
            return drawtype;
        }

        // The ShapeCheck method will obtain the user's shape of choice.
        private void ShapeCheck(int[] colourValue, int type)
        {
            // The resolution for the picture box is created
            // by the bitmap class.
            Bitmap pic = new Bitmap(600, 600);

            // This random variable is used for selecting a random shape when
            // the option is chosen.
            Random rand = new Random();

            // The shape variable is used for containing the random number
            // when the random shape option is chosen. The default value is
            // null, this allows the program to remove the random numbers
            // when another value is chosen. 
            int ? shape = null;

            // A method used for creating the axis of symmetry.
            CreateAxis(pic);

            // If random shape is chosen, the program will generate a random
            // number in order to select a random shape.
            if(rdbRandShape.Checked == true)
            {
                shape = rand.Next(8);
            }

            // If the option square is chosen or when the random value for shape is 0,
            // a method will be called to create a square.     
            if (rdbSquare.Checked == true || shape == 0)
            {
                // The bitmap, colour, and drawing type are transfered to the CreateSquare method
                // in order to generate a reflection of a square out of pixels.
                CreateSquare(pic, colourValue, type);
            }

            // The same procedure occurs for all the other shape as well.
            else if (rdbRectangle.Checked == true || shape == 1)
            {
                CreateRectangle(pic, colourValue, type);
            }

            else if (rdbTriangle.Checked == true || shape == 2)
            {
                CreateTriangle(pic, colourValue, type);
            }

            else if (rdbParallelogram.Checked == true || shape == 3)
            {
                CreateParallelogram(pic, colourValue, type);
            }

            else if (rdbRhombus.Checked == true || shape == 4)
            {
                CreateRhombus(pic, colourValue, type);
            }

            else if (rdbTrapezoid.Checked == true || shape == 5)
            {
                CreateTrapezoid(pic, colourValue, type);
            }

            else if (rdbHexagon.Checked == true || shape == 6)
            {
                CreateHexagon(pic, colourValue, type);
            }

            else if (rdbArrow.Checked == true || shape == 7)
            {
                CreateArrow(pic, colourValue, type);
            }

            // The reflection is displayed on the picture box
            // after going through all of its processes.
            picPixel.Image = pic;
        }
       
        // This method creates an axis of symmetry.
        static void CreateAxis(Bitmap picture)
        {
            // A method containing a for loop that will produce an 
            // axis of symmetry at the halfway point of the picture box.
            for (int y = 300; y == 300; y++)
            {
                for (int x = 0; x < 600; x++)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, 0, 0, 0));
                }
            }
        }

        // This method creates a reflection of 2 squares out of pixels.
        static void CreateSquare(Bitmap picture, int[] colours, int drawingType)
        {
            // The first for loop creates a square above the axis of symmetry.
            // The y-value is used to generate the height of the shape
            // and the x-value is used for the width of the shape.         
            for (int y = 50; y < 250; y++)
            {
                // The drawing type in the for loop changes the increment value of x.
                // This allows the shape to be made out of lines.
                for (int x = 200; x < 400; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
            }

            // The second for loop creates the reflected square below the axis of symmetry.
            // The process for creating the second square is the same as the first one. However,
            // only the y-value is changed.
            for (int y = 350; y < 550; y++)
            {
                for (int x = 200; x < 400; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
            }
        }

        // This method creates a reflection of 2 rectangles out of pixels.
        static void CreateRectangle(Bitmap picture, int[] colours, int drawingType)
        {
            // The first for loop is used for creating the rectangle above the axis of symmetry.
            // The difference between a rectangle and a square is its width. As a result, the
            // x value is larger this time while the y value remains the same.
            for (int y = 50; y < 250; y++)
            {
                for (int x = 100; x < 500; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
            }

            // The second for loop used for creating the rectangle below the axis of symmetry.
            for (int y = 350; y < 550; y++)
            {
                for (int x = 100; x < 500; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
            }
        }

        // This method creates a reflection of 2 triangles out of pixels.
        static void CreateTriangle(Bitmap picture, int[] colours, int drawingType)
        {
            // These variables are defined as the starting positions containing 2 x-values.
            // This allows a triangle to produce a total of 3 vertices.
            int start = 100, width = 500, startTwo = 300, widthTwo = 300;

            // The first for loop is used for creating an isosceles triangle above the axis of symmetry.
            // The first triangle starts at the base of the triangle. With the 2 starting positions,
            // start and width, the start will continue to add and the width will substract in order
            // to produce a vertex once the two numbers are equal in value.
            for (int y = 50; y < 250; y++)
            {
                for (int x = start; x < width; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
                start++;
                width--;
            }
            
            // The second for loop for producing an isosceles triangle below the axis of symmetry.
            // The second triangle starts at the tip rather than the base. This allows the triangle to be
            // reflected. The starting positions for this triangle is startTwo and widthTwo. The variable
            // startTwo will be subtracting while widthTwo will be adding in value in order to create the
            // base of the triangle.
            for (int y = 350; y < 550; y++)
            {
                for (int x = startTwo; x < widthTwo; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
                startTwo--;
                widthTwo++;
            }
        }

        // This method creates a reflection of 2 parallelograms out of pixels.
        static void CreateParallelogram(Bitmap picture, int[] colours, int drawingType)
        {
            // These are the starting positions of the two parallelograms
            int start = 250, width = 550, startTwo = 50, widthTwo = 350;

            // The first for loop is used for creating the first parallelogram above the axis of symmetry.
            // The first parallelogram will have its start and width variables subtracting.
            // With the decrementing starting positions, the two sides of the parallelogram are
            // generated parallel to each other which creates the resulting parallelogram.
            for (int y = 50; y < 250; y++)
            {
                for (int x = start; x < width; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
                start--;
                width--;
            }

            // The same process happens for the second for loop in order to generate a parallelogram
            // below the axis of symmetry. Instead of decrementing, the starting positions for the
            // second parallelogram will be incrementing. This results the reflecting parallelogram.
            for (int y = 350; y < 550; y++)
            {
                for (int x = startTwo; x < widthTwo; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
                startTwo++;
                widthTwo++;
            }
        }

        // This method creates a reflection of 2 rhombuses out of pixels.
        static void CreateRhombus(Bitmap picture, int[] colours, int drawingType)
        {
            // These are the starting positions of the first rhombus.
            int start = 300, width = 300, startTwo = 200, widthTwo = 400;

            // The first for loop is used for creating half of the rhombus.
            // This for loop will create the top part of the rhombus which can
            // be simplified to an isoceles triangle. As a result, the for loop
            // uses the same formula as the CreateTriangle method.
            for (int y = 50; y < 150; y++)
            {
                for (int x = start; x < width; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
                start--;
                width++;
            }

            // The second for loop is used for creating the bottom of the first rhombus.
            for (int y = 150; y < 250; y++)
            {
                for (int x = startTwo; x < widthTwo; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
                startTwo++;
                widthTwo--;
            }

            // These are the starting position of the second rhombus.
            int startThree = 300, widthThree = 300, startFour = 200, widthFour = 400;

            // The same procedure occurs in the second rhombus. However, only the y-values are changed.
            for (int y = 350; y < 450; y++)
            {
                for (int x = startThree; x < widthThree; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
                startThree--;
                widthThree++;
            }

            for (int y = 450; y < 550; y++)
            {
                for (int x = startFour; x < widthFour; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
                startFour++;
                widthFour--;
            }
        }

        // This method creates a reflection of 2 trapezoids out of pixels.
        static void CreateTrapezoid(Bitmap picture, int[] colours, int drawingType)
        {
            // These are the starting positions of the two trapezoids.
            int start = 200, width = 400, startTwo = 0, widthTwo = 600;

            // The first for loop creates the trapezoid above the axis of symmetry.
            // The two starting points starts at two different x-values. However,
            // the start value will be subtracting and the width value will be adding.
            // This will create the sides and base of the trapezoid. The formula
            // for creating a trapezoid is similiar to an isosceles triangle. Instead
            // of starting or ending at the top vertex, the trapezoid will end with
            // a total of 4 vertices.
            for (int y = 50; y < 250; y++)
            {
                for (int x = start; x < width; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
                start--;
                width++;
            }

            // The same process occurs for the second trapezoid below the axis of symmetry. However,
            // the trapezoid will be generated from the base instead of the top.
            for (int y = 350; y < 550; y++)
            {
                for (int x = startTwo; x < widthTwo; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
                startTwo++;
                widthTwo--;
            }
        }

        // This method creates a reflection of 2 hexagons out of pixels.
        static void CreateHexagon(Bitmap picture, int[] colours, int drawingType)
        {
            // These are the starting positions for the first hexagon.
            int start = 220, width = 380, startTwo = 120, widthTwo = 480;

            // The first for loop creates the top half of the first hexagon.
            // The formula is the same as a trapezoid since cutting a hexagon
            // in half, horizontally, will result in 2 trapezoids.
            for (int y = 50; y < 150; y ++)
            {
                for (int x = start; x < width; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
                start--;
                width++;
            }

            // The second for loop creates the bottom half of the first hexagon.
            for (int y = 150; y < 250; y++)
            {
                for (int x = startTwo; x < widthTwo; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
                startTwo++;
                widthTwo--;
            }

            // These are the starting positions for the second hexagon.
            int startThree = 220, widthThree = 380, startFour = 120, widthFour = 480;

            // Same procedure happens similiar to the first hexagon. However, the y-values
            // will change.
            for (int y = 350; y < 450; y++)
            {
                for (int x = startThree; x < widthThree; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
                startThree--;
                widthThree++;
            }

            for (int y = 450; y < 550; y++)
            {
                for (int x = startFour; x < widthFour; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
                startFour++;
                widthFour--;
            }
        }

        // This method creates a reflection of 2 arrows out of pixels.
        static void CreateArrow(Bitmap picture, int[] colours, int drawingType)
        {
            // An arrow can be broken down into two simple shapes, an isosceles triangle
            // and a rectangle. These are the starting position of the triangle part of the arrow.
            int start = 300, width = 300;

            // The first for loop creates the tip of the first arrow. The formula for creating
            // an isosceles triangle is used. However, the triangle is scaled down to a smaller size.
            for (int y = 0; y < 100; y ++)
            {
                for (int x = start; x < width; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
                start--;
                width++;
            }

            // The second for loop is used for creating the rectangle part of the first arrow.
            // Instead of create a rectangle on the x-axis, this rectangle will be on the y-axis.
            for (int y = 100; y < 250; y ++)
            {
                for (int x = 280; x < 320; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
            }

            // These are the starting position for the triangle part in the second arrow.
            int startTwo = 200, widthTwo = 400;

            // The triangle is reflected and created at the bottom of the picture box.
            for (int y = 500; y < 600; y ++)
            {
                for (int x = startTwo; x < widthTwo; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
                startTwo++;
                widthTwo--;
            }

            // This for loop creates the rectangle part of the second arrow.
            for (int y = 350; y < 500; y ++)
            {
                for (int x = 280; x < 320; x += drawingType)
                {
                    picture.SetPixel(x, y, Color.FromArgb(255, colours[0], colours[1], colours[2]));
                }
            }
        }
    }
}
