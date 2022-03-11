using ComponentFactory.Krypton.Toolkit;
using System;

namespace SkarLauncher
{
    public class SkarUtils
    {

        public static KryptonButton createButton(String id)
        {
            KryptonButton button = new KryptonButton();

            button.Name = id;
            button.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb;
            button.Location = new System.Drawing.Point(9, 9);
            button.OverrideDefault.Back.Color1 = System.Drawing.Color.DimGray;
            button.OverrideDefault.Back.Color2 = System.Drawing.Color.DimGray;
            button.OverrideDefault.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            button.OverrideDefault.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            button.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            button.OverrideDefault.Border.Color2 = System.Drawing.Color.Black;
            button.OverrideDefault.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            button.OverrideDefault.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            button.OverrideDefault.Border.DrawBorders = (((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right);
            button.OverrideDefault.Border.Rounding = 5;
            button.OverrideDefault.Border.Width = 3;
            button.Size = new System.Drawing.Size(47, 47);
            button.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
            button.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
            button.StateCommon.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            button.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            button.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            button.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            button.StateCommon.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            button.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            button.StateCommon.Border.DrawBorders = (((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right);
            button.StateCommon.Border.Rounding = 5;
            button.StateCommon.Border.Width = 3;
            button.StateTracking.Border.Color1 = System.Drawing.Color.White;
            button.StateTracking.Border.Color2 = System.Drawing.Color.White;
            button.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            button.StateTracking.Border.DrawBorders = (((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right);
            button.StateTracking.Border.Rounding = 5;
            button.StateTracking.Border.Width = 3;
            button.TabIndex = 0;
            button.Values.Image = global::SkarLauncher.Properties.Resources.fnch1old2;
            button.Values.Text = "";

            return button;
        }

    }
}
