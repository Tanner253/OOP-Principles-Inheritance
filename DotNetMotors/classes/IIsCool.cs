﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DotNetMotors.classes
{
    public interface IIsCool
    {
        bool IsCool { get; set; }

        /// <summary>
        /// creates method for being cool must be action
        /// </summary>
        /// <returns>string </returns>
        string ImCool();
        
    }
}
