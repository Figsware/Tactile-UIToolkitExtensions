using UnityEngine;
using UnityEngine.UIElements;

namespace Tactile.UI.UIToolkitExtensions.Extensions
{
    public static class ImageExtensions
    {
        public static T Image<T>(this T obj, Texture image) where T : Image
        {
            obj.image = image;
            return obj;
        }
        
        public static T ScaleMode<T>(this T obj, ScaleMode scaleMode) where T : Image
        {
            obj.scaleMode = scaleMode;
            return obj;
        }
        
        public static T SourceRect<T>(this T obj, Rect sourceRect) where T : Image
        {
            obj.sourceRect = sourceRect;
            return obj;
        }
        
        public static T Sprite<T>(this T obj, Sprite sprite) where T : Image
        {
            obj.sprite = sprite;
            return obj;
        }
        
        public static T TintColor<T>(this T obj, Color tintColor) where T : Image
        {
            obj.tintColor = tintColor;
            return obj;
        }
        
        public static T UV<T>(this T obj, Rect uv) where T : Image
        {
            obj.uv = uv;
            return obj;
        }
        
        public static T VectorImage<T>(this T obj, VectorImage image) where T : Image
        {
            obj.vectorImage = image;
            return obj;
        }
    }
}