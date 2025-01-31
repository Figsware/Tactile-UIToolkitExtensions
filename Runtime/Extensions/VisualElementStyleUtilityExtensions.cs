using UnityEngine.UIElements;

namespace Tactile.UI.UIToolkitExtensions.Extensions
{
    public static class VisualElementStyleUtilityExtensions
    {
        public static T BorderColor<T>(this T obj, StyleColor color) where T : VisualElement
        {
            obj.style.borderTopColor = color;
            obj.style.borderBottomColor = color;
            obj.style.borderLeftColor = color;
            obj.style.borderRightColor = color;
            return obj;
        }

        public static T BorderHorizontalColor<T>(this T obj, StyleColor color) where T : VisualElement
        {
            obj.style.borderLeftColor = color;
            obj.style.borderRightColor = color;
            return obj;
        }

        public static T BorderHorizontalWidth<T>(this T obj, StyleFloat width) where T : VisualElement
        {
            obj.style.borderLeftWidth = width;
            obj.style.borderRightWidth = width;
            return obj;
        }

        public static T BorderRadius<T>(this T obj, StyleLength length) where T : VisualElement
        {
            obj.style.borderTopLeftRadius = length;
            obj.style.borderTopRightRadius = length;
            obj.style.borderBottomLeftRadius = length;
            obj.style.borderBottomRightRadius = length;
            return obj;
        }

        public static T BorderVerticalColor<T>(this T obj, StyleColor color) where T : VisualElement
        {
            obj.style.borderTopColor = color;
            obj.style.borderBottomColor = color;
            return obj;
        }


        public static T BorderVerticalWidth<T>(this T obj, StyleFloat width) where T : VisualElement
        {
            obj.style.borderTopWidth = width;
            obj.style.borderBottomWidth = width;
            return obj;
        }


        public static T BorderWidth<T>(this T obj, StyleFloat width) where T : VisualElement
        {
            obj.style.borderTopWidth = width;
            obj.style.borderBottomWidth = width;
            obj.style.borderRightWidth = width;
            obj.style.borderLeftWidth = width;
            return obj;
        }

        public static T Distance<T>(this T obj, StyleLength length) where T : VisualElement
        {
            obj.style.top = length;
            obj.style.bottom = length;
            obj.style.left = length;
            obj.style.right = length;
            return obj;
        }

        public static T HorizontalDistance<T>(this T obj, StyleLength length) where T : VisualElement
        {
            obj.style.left = length;
            obj.style.right = length;
            return obj;
        }

        public static T Margin<T>(this T obj, StyleLength styleLength) where T : VisualElement
        {
            obj.style.marginTop = styleLength;
            obj.style.marginBottom = styleLength;
            obj.style.marginLeft = styleLength;
            obj.style.marginRight = styleLength;
            return obj;
        }

        public static T MarginHorizontal<T>(this T obj, StyleLength styleLength) where T : VisualElement
        {
            obj.style.marginLeft = styleLength;
            obj.style.marginRight = styleLength;
            return obj;
        }

        public static T MarginVertical<T>(this T obj, StyleLength styleLength) where T : VisualElement
        {
            obj.style.marginTop = styleLength;
            obj.style.marginBottom = styleLength;
            return obj;
        }

        public static T Padding<T>(this T obj, StyleLength styleLength) where T : VisualElement
        {
            obj.style.paddingTop = styleLength;
            obj.style.paddingBottom = styleLength;
            obj.style.paddingLeft = styleLength;
            obj.style.paddingRight = styleLength;
            return obj;
        }

        public static T PaddingVertical<T>(this T obj, StyleLength styleLength) where T : VisualElement
        {
            obj.style.paddingTop = styleLength;
            obj.style.paddingBottom = styleLength;
            return obj;
        }

        public static T PaddingHorizontal<T>(this T obj, StyleLength styleLength) where T : VisualElement
        {
            obj.style.paddingLeft = styleLength;
            obj.style.paddingRight = styleLength;
            return obj;
        }

        public static T UnitySlice<T>(this T obj, StyleInt slice) where T : VisualElement
        {
            obj.style.unitySliceTop = slice;
            obj.style.unitySliceBottom = slice;
            obj.style.unitySliceLeft = slice;
            obj.style.unitySliceRight = slice;
            return obj;
        }

        public static T UnitySliceHorizontal<T>(this T obj, StyleInt slice) where T : VisualElement
        {
            obj.style.unitySliceLeft = slice;
            obj.style.unitySliceRight = slice;
            return obj;
        }

        public static T UnitySliceVertical<T>(this T obj, StyleInt slice) where T : VisualElement
        {
            obj.style.unitySliceTop = slice;
            obj.style.unitySliceBottom = slice;
            return obj;
        }

        public static T VerticalDistance<T>(this T obj, StyleLength length) where T : VisualElement
        {
            obj.style.top = length;
            obj.style.bottom = length;
            return obj;
        }
    }
}