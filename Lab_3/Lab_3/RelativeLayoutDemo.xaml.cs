using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab_3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelativeLayoutDemo : ContentPage
    {
        public RelativeLayoutDemo()
        {
            layout.Children.Add(redBox, Constraint.RelativeToParent((parent) => {
                return parent.X;
            }), Constraint.RelativeToParent((parent) => {
                return parent.Y * .15;
            }), Constraint.RelativeToParent((parent) => {
                return parent.Width;
            }), Constraint.RelativeToParent((parent) => {
                return parent.Height * .8;
            }));
            layout.Children.Add(blueBox, Constraint.RelativeToView(redBox, (Parent, sibling) => {
                return sibling.X + 20;
            }), Constraint.RelativeToView(blueBox, (parent, sibling) => {
                return sibling.Y + 20;
            }), Constraint.RelativeToParent((parent) => {
                return parent.Width * .5;
            }), Constraint.RelativeToParent((parent) => {
                return parent.Height * .5;
            }));

        }
    }
}