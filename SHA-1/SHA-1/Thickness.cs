﻿using System;
using System.Windows.Forms;

namespace SHA1
{
    internal class Thickness
    {
        private int v1;
        private int v2;
        private int v3;
        private int v4;
        private int v;

        public Thickness(int v)
        {
            this.v = v;
        }

        public Thickness(int v1, int v2, int v3, int v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        
    }
}