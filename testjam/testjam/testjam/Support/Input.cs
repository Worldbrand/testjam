using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace testjam
{
    public static class Input
    {
        private static MouseState mouse = Mouse.GetState();
        private static MouseState mousePrev = Mouse.GetState();
        static Input()
        {
        }

        public static void Update()
        {
            mousePrev = mouse;
            mouse = Mouse.GetState();
        }

        #region Mouse

        public static bool MouseScrollDown
        {
            get { return (mouse.ScrollWheelValue < mousePrev.ScrollWheelValue); }
        }

        public static bool MouseScrollUp
        {
            get { return (mouse.ScrollWheelValue > mousePrev.ScrollWheelValue); }
        }

        public static float MouseWheelFloat
        {
            get { return (float)mouse.ScrollWheelValue; }
        }

        public static bool MouseLeftButtonPressed
        {
            get { return (mouse.LeftButton == ButtonState.Pressed && mousePrev.LeftButton == ButtonState.Released); }
        }

        public static bool MouseLeftButtonTapped
        {
            get { return (mouse.LeftButton == ButtonState.Pressed && mousePrev.LeftButton == ButtonState.Released); }
        }

        public static bool MouseRightButtonTapped
        {
            get { return (mouse.RightButton == ButtonState.Pressed && mousePrev.RightButton == ButtonState.Released); }
        }

        public static bool MouseMiddleButtonTapped
        {
            get { return (mouse.MiddleButton == ButtonState.Pressed && mousePrev.MiddleButton == ButtonState.Released); }
        }

        public static bool MouseLeftButtonDown
        {
            get { return mouse.LeftButton == ButtonState.Pressed; }
        }

        public static bool MouseRightButtonDown
        {
            get { return mouse.RightButton == ButtonState.Pressed; }
        }

        public static bool MouseMiddleButtonDown
        {
            get { return mouse.MiddleButton == ButtonState.Pressed; }
        }

        public static Vector2 MousePosition
        {
            get { return new Vector2(mouse.X, mouse.Y); }
        }

        public static Vector2 MousePrevPosition
        {
            get { return new Vector2(mousePrev.X, mousePrev.Y); }
        }

        #endregion

    }
}

