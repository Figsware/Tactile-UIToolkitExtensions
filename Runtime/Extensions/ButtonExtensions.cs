using UnityEngine;
using UnityEngine.UIElements;

namespace Tactile.UI.UIToolkitExtensions.Extensions
{
    public static class ButtonExtensions
    {
        public static T Clickable<T>(this T obj, Clickable clickable) where T : Button
        {
            obj.clickable = clickable;
            return obj;
        }
    }
}