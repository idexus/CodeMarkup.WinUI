﻿using System;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Data;

namespace ExampleApp
{
    using CodeMarkup.WinUI;
    
    [Bindable]
    public partial class RadioButtonPage : ExamplesBasePage
    {
        public RadioButtonPage()
        {
            Type = typeof(RadioButton);

            Examples = new()
            {
                new Example
                {
                    new RadioButtons(e => e.Header("Options"))
                    {
                        new RadioButton().Content("Option 1").OnChecked(rb => { }),
                        new RadioButton().Content("Option 2").OnChecked(rb => { }),
                        new RadioButton().Content("Option 3").OnChecked(rb => { }),
                    }
                }
                .Title("A RadioButtons group")
                .SourceText(Sources.RadioButton),
            };
        }
    }
}

