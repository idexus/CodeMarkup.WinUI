﻿using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;
using CodeMarkup.WinUI;
using Microsoft.UI;
using Microsoft.UI.Xaml.Media;
using ColorCode;


namespace ExampleApp
{
    using CodeMarkup.WinUI.Controls;

    [DependencyProperties]
    public interface IExample
    {
        public string Title { get; set; }

        public UIElement ExampleContent { get; set; }

        [PropertyCallbacks(nameof(Example.SourceTextChanged))]
        public string SourceText { get; set; }
    }

    [MarkupObject]
    [ContainerProperty(nameof(ExampleContent))] 
    public partial class Example : Frame, IExample
    {
        private readonly RichTextBlock sourceTextBlock;

        public Example()
        {
            Content = new VStack(e => e.Padding(new Thickness(10)))
            {
                new TextBlock()
                    .Text(e => e.Path(nameof(Title)).Source(this))
                    .FontSize(20)
                    .Margin(new Thickness(0,10,0,10)),

                new Grid
                {
                    new Frame()
                        .Content(e => e.Path(nameof(ExampleContent))
                        .Source(this))
                }
                .Margin(new Thickness(1, 0, 1, 0))
                .Padding(new Thickness(20))
                .Background(new SolidColorBrush(Colors.MidnightBlue)),                
                
                new Expander
                {
                    new Grid
                    {
                        new RichTextBlock()
                            .Assign(out sourceTextBlock)
                            .FontFamily(new FontFamily("Consolas"))
                    }
                    .Padding(new Thickness(10, 0, 10, 0))
                    .Width(int.MaxValue)
                }
                .IsExpanded(false)
                .HorizontalAlignment(HorizontalAlignment.Stretch)
                .ExpandDirection(ExpandDirection.Down)
                .Header("Source code")
            };
        }

        public static void SourceTextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var example = (Example)sender;
            var sourceText = e.NewValue as string;
            var formatter = new RichTextBlockFormatter(ElementTheme.Dark);
            formatter.FormatRichTextBlock(sourceText, Languages.CSharp, example.sourceTextBlock);
        }
    }
}
