using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject.Controller
{
    public class InputController
    {
        public bool Space => Input.GetKeyDown(KeyCode.Space);
        public bool LeftMouseClick => Input.GetMouseButtonDown(0);
        public bool RightMouseClick => Input.GetMouseButtonDown(1);
        
    }
}

