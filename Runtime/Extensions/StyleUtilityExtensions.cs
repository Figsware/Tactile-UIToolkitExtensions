using UnityEngine.UIElements;

namespace Tactile.UI.UIToolkitExtensions.Extensions
{
    public static class StyleUtilityExtensions
    {
        public static T BorderColor<T>(this T obj, StyleColor color) where T : IStyle
        {
            obj.borderTopColor = color;
            obj.borderBottomColor = color;
            obj.borderLeftColor = color;
            obj.borderRightColor = color;
            return obj;
        }

        public static T BorderHorizontalColor<T>(this T obj, StyleColor color) where T : IStyle
        {
            obj.borderLeftColor = color;
            obj.borderRightColor = color;
            return obj;
        }

        public static T BorderHorizontalWidth<T>(this T obj, StyleFloat width) where T : IStyle
        {
            obj.borderLeftWidth = width;
            obj.borderRightWidth = width;
            return obj;
        }

        public static T BorderRadius<T>(this T obj, StyleLength length) where T : IStyle
        {
            obj.borderTopLeftRadius = length;
            obj.borderTopRightRadius = length;
            obj.borderBottomLeftRadius = length;
            obj.borderBottomRightRadius = length;
            return obj;
        }

        public static T BorderVerticalColor<T>(this T obj, StyleColor color) where T : IStyle
        {
            obj.borderTopColor = color;
            obj.borderBottomColor = color;
            return obj;
        }


        public static T BorderVerticalWidth<T>(this T obj, StyleFloat width) where T : IStyle
        {
            obj.borderTopWidth = width;
            obj.borderBottomWidth = width;
            return obj;
        }


        public static T BorderWidth<T>(this T obj, StyleFloat width) where T : IStyle
        {
            obj.borderTopWidth = width;
            obj.borderBottomWidth = width;
            obj.borderRightWidth = width;
            obj.borderLeftWidth = width;
            return obj;
        }

        public static T Distance<T>(this T obj, StyleLength length) where T : IStyle
        {
            obj.top = length;
            obj.bottom = length;
            obj.left = length;
            obj.right = length;
            return obj;
        }

        public static T HorizontalDistance<T>(this T obj, StyleLength length) where T : IStyle
        {
            obj.left = length;
            obj.right = length;
            return obj;
        }

        public static T Margin<T>(this T obj, StyleLength styleLength) where T : IStyle
        {
            obj.marginTop = styleLength;
            obj.marginBottom = styleLength;
            obj.marginLeft = styleLength;
            obj.marginRight = styleLength;
            return obj;
        }

        public static T MarginHorizontal<T>(this T obj, StyleLength styleLength) where T : IStyle
        {
            obj.marginLeft = styleLength;
            obj.marginRight = styleLength;
            return obj;
        }

        public static T MarginVertical<T>(this T obj, StyleLength styleLength) where T : IStyle
        {
            obj.marginTop = styleLength;
            obj.marginBottom = styleLength;
            return obj;
        }

        public static T Padding<T>(this T obj, StyleLength styleLength) where T : IStyle
        {
            obj.paddingTop = styleLength;
            obj.paddingBottom = styleLength;
            obj.paddingLeft = styleLength;
            obj.paddingRight = styleLength;
            return obj;
        }

        public static T PaddingVertical<T>(this T obj, StyleLength styleLength) where T : IStyle
        {
            obj.paddingTop = styleLength;
            obj.paddingBottom = styleLength;
            return obj;
        }

        public static T PaddingHorizontal<T>(this T obj, StyleLength styleLength) where T : IStyle
        {
            obj.paddingLeft = styleLength;
            obj.paddingRight = styleLength;
            return obj;
        }

        public static T UnitySlice<T>(this T obj, StyleInt slice) where T : IStyle
        {
            obj.unitySliceTop = slice;
            obj.unitySliceBottom = slice;
            obj.unitySliceLeft = slice;
            obj.unitySliceRight = slice;
            return obj;
        }

        public static T UnitySliceHorizontal<T>(this T obj, StyleInt slice) where T : IStyle
        {
            obj.unitySliceLeft = slice;
            obj.unitySliceRight = slice;
            return obj;
        }

        public static T UnitySliceVertical<T>(this T obj, StyleInt slice) where T : IStyle
        {
            obj.unitySliceTop = slice;
            obj.unitySliceBottom = slice;
            return obj;
        }

        public static T VerticalDistance<T>(this T obj, StyleLength length) where T : IStyle
        {
            obj.top = length;
            obj.bottom = length;
            return obj;
        }
    }
}