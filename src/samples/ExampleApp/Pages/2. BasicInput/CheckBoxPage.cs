﻿using System;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;

namespace ExampleApp
{
    using CodeMarkup.WinUI;
    
    [Bindable]
    public partial class CheckBoxPage : ExamplesBasePage
    {
        public CheckBoxPage()
        {
            Type = typeof(CheckBox);

            Examples = new()
            {
                new Example
                {
                    new CheckBox()
                        .Content("Two-state CheckBox")
                        .OnChecked(checkBox =>
                        { 
                            // checked - do some stuff 
                        })
                        .OnUnchecked(checkBox =>
                        { 
                            // unchecked - do some stuff
                        })
                }
                .Title("A 2-state CheckBox")
                .SourceText(Sources.TwoState),

                new Example
                {
                    new CheckBox()
                        .Content("Three-state CheckBox")
                        .IsThreeState(true)
                        .OnChecked(checkBox => { })
                        .OnUnchecked(checkBox => { })
                        .OnIndeterminate(checkBox => { })
                }
                .Title("A 3-state CheckBox")
                .SourceText(Sources.ThreeState),
            };
        }
    }
}

