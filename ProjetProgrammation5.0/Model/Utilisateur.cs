    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace ProjetProgrammation5._0.Model
    {
        public class Utilisateur
        {
           public bool goLeft, goRight, jumping, hasKey;


            public int jumpSpeed = 10;
            public  int force = 8;
            public int score = 0;
            public int playerSpeed = 10;
            public int backgroundSpeed = 0;
            public bool spacePressed = false;
        }
    }
 