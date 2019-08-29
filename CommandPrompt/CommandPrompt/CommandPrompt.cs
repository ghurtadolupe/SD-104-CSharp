using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CommandPrompt
{
    class CommandPrompt
    {
        int height;
        int columns;
        string[] screenText;
        ConsoleColor backgroundColor;
        ConsoleColor foregroundColor;




        //Start of Constructor
        public CommandPrompt(int height, int columns)
        {
            this.height = height;
            this.columns = columns;

            //setting the console color 
            backgroundColor = ConsoleColor.Black;   // or whatever you like
            foregroundColor = ConsoleColor.Green; // or whatever you like








            // create the screen to hold the number of rows passed in with the height parameter
            screenText = new string[height];

            // we will use the C# object to set the size of our window.
            Console.SetWindowSize(33, 35);

            // let's set the initial screen rows to all blank lines
            for (int i = 0; i < screenText.Length; i++)
            {
                screenText[i] = "";
            }
        }   // end of CommandPrompt constructor




        public void Display()
        {

            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;





            Console.Clear();             //  the Console object is available to us to control aspects of our terminal window. The Clear method will blank our window
                                         // The Clear method has blanked the screen and left the cursor at the top of the window.
                                         // We will now loop through the screenText array to put out text on the screen.
            for (int i = 0; i < screenText.Length; i++)
            {
                Console.WriteLine(screenText[i]);
            }
        }   // end of Display method


        public void SetScreenText(int lineNumber, string lineOfText)
        {
            screenText[lineNumber] = lineOfText;
        }   // end of SetScreenText method


        public void ClearScreen()
        {
            for (int i = 0; i < screenText.Length; i++)
            {
                screenText[i] = "";
            }
        }


            public void SetBackgroundColor(string color)
            {
                backgroundColor = ConvertColor(color);
            }   // end of SetBackgroundColor

            public void SetForegroundColor(string color)
            {
                foregroundColor = ConvertColor(color);
            }   // end of SetForegroundColor




            //Convert color
            public static ConsoleColor ConvertColor(string strColor)
            {
                ConsoleColor color;
                switch (strColor.ToLower())
                {
                    case "black": color = ConsoleColor.Black; break;
                    case "red": color = ConsoleColor.Red; break;
                    case "cyan": color = ConsoleColor.Cyan; break;
                    case "darkblue": color = ConsoleColor.DarkBlue; break;
                    case "darkcyan": color = ConsoleColor.DarkCyan; break;
                    case "darkgreen": color = ConsoleColor.DarkGreen; break;
                    case "darkmagenta": color = ConsoleColor.DarkMagenta; break;
                    case "yellow": color = ConsoleColor.Yellow; break;
                    case "darkyellow": color = ConsoleColor.DarkYellow; break;
                    case "darkred": color = ConsoleColor.DarkRed; break;
                    case "white": color = ConsoleColor.White; break;
                    case "magenta": color = ConsoleColor.Magenta; break;
                    case "blue": color = ConsoleColor.Blue; break;



                default: color = ConsoleColor.DarkGray; break;
                }
                return color;
            }   // end of ConvertColor method



            public void SaveScreen(string fileName)
            {
                FileStream stream;
                StreamWriter textOut = null;
               
            

            try
                {
                    fileName = "../../../" + fileName;
                    stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    textOut = new StreamWriter(stream);

                //textOut.WriteLine(Console.ReadLine());
                textOut.WriteLine(height);
                textOut.WriteLine(columns);
                textOut.WriteLine(backgroundColor);
                textOut.WriteLine(foregroundColor);

                for (int i = 0; i < screenText.Length; i++)
                {
                    textOut.WriteLine(screenText[i]);
                }
                   

            }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Creating file: ");
                    Console.WriteLine(ex.ToString());
                    return;
                }
                finally
                {
                    if (textOut != null)
                        textOut.Close();
                }
            }   // of of SaveScreen method




        public void ReloadScreen(string fileName)
        {
            FileStream stream;
            StreamReader textIn = null;
            
           

            try
            {
                fileName = "../../../" + fileName;
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                textIn = new StreamReader(stream);

                // screenText[0]=(textIn.ReadLine());
                height = Convert.ToInt32(textIn.ReadLine());
               columns = Convert.ToInt32(textIn.ReadLine());
                backgroundColor = ConvertColor(textIn.ReadLine());
                foregroundColor = ConvertColor(textIn.ReadLine());

                screenText = new string[height];

                for (int i = 0; i < screenText.Length; i++)
                {
                    screenText[i] = textIn.ReadLine();
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Reading file: ");
                Console.WriteLine(ex.ToString());
                return;
            }
            finally
            {
                if (textIn != null)
                    textIn.Close();
            }
        }   // of of SaveScreen method



    }
}

