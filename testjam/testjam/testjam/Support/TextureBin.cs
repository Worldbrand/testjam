using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;


namespace testjam
{
    public class TextureBin
    {
        //In this class, we import every texture we can find and throw it into a dictionary structure.
        private static Dictionary<String, Texture2D> texDic = new Dictionary<String, Texture2D>();

        //makes our lives a bit easier
        public static SpriteFont mainFont;

        public static SpriteFont MainFont
        {
            get
            {
                return mainFont;
            }
        }

        //Again, makes our lives easier if we ever just want to draw pixels. There is a predefined Pixel texture.
        public static Texture2D Pixel
        {
            get
            {
                return GetTexture("Pixel");
            }
        }

        //Returns an entry in the dictionary by name, as a reference.
        public static Texture2D GetTexture(String name)
        {
            Console.WriteLine(name);
            texDic[name].Name = name;
            return texDic[name];
        }

        //Runs through every sprite and adds it to our texture dictionary.
        public static void Load(ContentManager content)
        {
            //Load the font
            //mainFont = content.Load<SpriteFont>("Fonts/MainFont");

            //Create a string array containing each file found in Sprites folder
            string[] files = System.IO.Directory.GetFiles(content.RootDirectory + "/Sprites/");
            foreach (string file in files)
            //Retrieves the name of the texture.
            {
                string textureName = file.Substring(file.LastIndexOf('/') + 1, file.Length - 5 - file.LastIndexOf('/'));

                //To understand how the above line works, we should uncomment the two below:
                //Console.WriteLine(file);
                Console.WriteLine(textureName);

                //They will output something like this:
                //Content/Sprites/Pixel.xnb
                //Pixel

                //What happens is essentially that we clip most of the string and end up with just the filename.
                texDic.Add(textureName, content.Load<Texture2D>("Sprites/" + textureName));

            }
        }
    }
}
