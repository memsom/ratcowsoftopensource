﻿/*
 * Copyright 2011 Rat Cow Software and Matt Emson. All rights reserved.
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using RatCow.Hiragana;

namespace RatcowHiriganaTool
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      HiraganaTable h = new HiraganaTable();

      textBox1.Text = h.Test(); //builds a table of characters
    }

    private void button2_Click(object sender, EventArgs e)
    {
      HiraganaTable h = new HiraganaTable();

      textBox1.Text = String.Format("{0}{1}{2}", h.DecodeBlock("ta"), h.DecodeBlock("na"), h.DecodeBlock("ka"));
    }

    private void button3_Click(object sender, EventArgs e)
    {
      //we tokenize the word
      List<String> tokens = new List<string>();

      string buffer = null;

      StringBuilder sb = new StringBuilder(textBox2.Text);
      for(int i = 0; i < sb.Length; i++)
      {
        char c = sb[i];
        buffer = buffer + c;

        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        {
          //convert
          tokens.Add(buffer);
          buffer = null;
        }       
      }

      textBox1.Text += "\r\n--------------------------------\r\n";

      HiraganaTable h = new HiraganaTable();
      foreach (var s in tokens)
      {
        textBox1.Text += h.DecodeBlock(s);
      }
    }

    private void button4_Click(object sender, EventArgs e)
    {

      textBox1.Text += "\r\n--------------------------------\r\n";

      HiraganaTable h = new HiraganaTable();
      StringBuilder sb = new StringBuilder(textBox2.Text);
      for (int i = 0; i < sb.Length; i++)
      {
        textBox1.Text += h.EncodeBlock(sb[i]);
      }

      

    }
  }
}
