﻿/*
 * Copyright 2010 Rat Cow Software and Matt Emson. All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without modification, are
 * permitted provided that the following conditions are met:
 * 
 * 1. Redistributions of source code must retain the above copyright notice, this list of
 *    conditions and the following disclaimer.
 * 2. Redistributions in binary form must reproduce the above copyright notice, this list
 *    of conditions and the following disclaimer in the documentation and/or other materials
 *    provided with the distribution.
 * 3. Neither the name of the Rat Cow Software nor the names of its contributors may be used 
 *    to endorse or promote products derived from this software without specific prior written 
 *    permission.
 *    
 * THIS SOFTWARE IS PROVIDED BY RAT COW SOFTWARE "AS IS" AND ANY EXPRESS OR IMPLIED
 * WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
 * FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> OR
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON
 * ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF
 * ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 *
 * The views and conclusions contained in the software and documentation are those of the
 * authors and should not be interpreted as representing official policies, either expressed
 * or implied, of Rat Cow Software and Matt Emson.
 * 
 */

using System;
using System.Collections.Generic;
#if !CF_20
using System.Linq;
#endif
using System.Text;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RatCow.MvcFramework.WPF
{
    public class ViewAttribute : Attribute
    {
        public ViewAttribute()
        {
        }
    }

    public class OutletAttribute: Attribute
    {
        public string Name {get; private set;}

        public OutletAttribute(string name)
        {
            Name = name;
        }
    }

    public class ActionAttribute: Attribute
    {
        public string Name {get; private set;}
        public string Action { get; private set; }
        public Type EventType { get; private set; }

        public ActionAttribute(string name, string action)
        {
            Name = name;
            Action = action;
            EventType = null; //default to the type of the underlying event... typeof(EventHandler);
        }

        public ActionAttribute(string name, string action, Type eventType)
        {
          Name = name;
          Action = action;
          EventType = eventType; //overrides the event type (experimental)
        }




    }
    
}
