/*
 * Copyright 2010 - 2012 Rat Cow Software and Matt Emson. All rights reserved.
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

/*This stub code was generated by the MvcFramework compiler, created by RatCow Soft -
 See http://code.google.com/p/ratcowsoftopensource/ */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

//3rd Party
using RatCow.MvcFramework;

namespace testapp3
{
  using RatCow.MvcFramework.Mapping;

  internal partial class Form1Controller : BaseController<Form1>
  {
    Data data = new Data();
    DataProxy deo = new DataProxy();
    List<ListData> combo3List = new List<ListData>();

    private class ListData
    {
      public string Displayed { get; set; }

      public int Value { get; set; }
    }

    protected override void ViewLoad()
    {
      base.ViewLoad();

      combo3List.Add(new ListData() { Displayed = "First", Value = 1 });
      combo3List.Add(new ListData() { Displayed = "Second", Value = 2 });
      combo3List.Add(new ListData() { Displayed = "Third", Value = 3 });
      combo3List.Add(new ListData() { Displayed = "Fourth", Value = 4 });

      comboBox3.DataSource = combo3List;
      comboBox3.DisplayMember = "Displayed";
      comboBox3.ValueMember = "Value";

      data.SomeText = "hello";
      data.ADateValue = DateTime.Parse("01 April 1976");
      data.SomeBooleanValue = true;
      data.ComboByIndex = 3;
      data.ComboByText = "E";
      data.ComboByValue = 3;
      data.ListBoxByIndex = 2;

      deo.MapControlToData("", this.View, data);
      deo.DataChanged += new EventHandler(deo_DataChanged);
    }

    private void deo_DataChanged(object sender, EventArgs e)
    {
      UpdateUI();
    }

    partial void button1Click(EventArgs e)
    {
      UpdateUI();
    }

    private void UpdateUI()
    {
      label1.Text = data.SomeText + "\r\n" +
        data.ADateValue.ToShortDateString() + "\r\n" +
        data.SomeBooleanValue.ToString() + "\r\n" +
        data.ComboByIndex.ToString() + "\r\n" +
        data.ComboByText + "\r\n" +
        data.ComboByValue.ToString() + "\r\n" +
        data.ListBoxByIndex.ToString();
    }
  }
}