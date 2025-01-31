using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace Tactile.UI.UIToolkitExtensions.Extensions
{
    public static class VisualElementStyleExtensions
    {
        public static T AlignContent<T>(this T obj, StyleEnum<Align> alignContent) where T : VisualElement
        {
            obj.style.alignContent = alignContent;
            return obj;
        }

        public static T AlignItems<T>(this T obj, StyleEnum<Align> alignItems) where T : VisualElement
        {
            obj.style.alignItems = alignItems;
            return obj;
        }

        public static T AlignSelf<T>(this T obj, StyleEnum<Align> alignSelf) where T : VisualElement
        {
            obj.style.alignSelf = alignSelf;
            return obj;
        }

        public static T BackgroundColor<T>(this T obj, StyleColor backgroundColor) where T : VisualElement
        {
            obj.style.backgroundColor = backgroundColor;
            return obj;
        }

        public static T BackgroundImage<T>(this T obj, StyleBackground backgroundImage) where T : VisualElement
        {
            obj.style.backgroundImage = backgroundImage;
            return obj;
        }

        public static T BackgroundPositionX<T>(this T obj, StyleBackgroundPosition backgroundPositionX)
            where T : VisualElement
        {
            obj.style.backgroundPositionX = backgroundPositionX;
            return obj;
        }

        public static T BackgroundPositionY<T>(this T obj, StyleBackgroundPosition backgroundPositionY)
            where T : VisualElement
        {
            obj.style.backgroundPositionY = backgroundPositionY;
            return obj;
        }

        public static T BackgroundRepeat<T>(this T obj, StyleBackgroundRepeat backgroundRepeat) where T : VisualElement
        {
            obj.style.backgroundRepeat = backgroundRepeat;
            return obj;
        }

        public static T BackgroundSize<T>(this T obj, StyleBackgroundSize backgroundSize) where T : VisualElement
        {
            obj.style.backgroundSize = backgroundSize;
            return obj;
        }

        public static T BorderBottomColor<T>(this T obj, StyleColor borderBottomColor) where T : VisualElement
        {
            obj.style.borderBottomColor = borderBottomColor;
            return obj;
        }

        public static T BorderBottomLeftRadius<T>(this T obj, StyleLength borderBottomLeftRadius)
            where T : VisualElement
        {
            obj.style.borderBottomLeftRadius = borderBottomLeftRadius;
            return obj;
        }

        public static T BorderBottomRightRadius<T>(this T obj, StyleLength borderBottomRightRadius)
            where T : VisualElement
        {
            obj.style.borderBottomRightRadius = borderBottomRightRadius;
            return obj;
        }

        public static T BorderBottomWidth<T>(this T obj, StyleFloat borderBottomWidth) where T : VisualElement
        {
            obj.style.borderBottomWidth = borderBottomWidth;
            return obj;
        }

        public static T BorderLeftColor<T>(this T obj, StyleColor borderLeftColor) where T : VisualElement
        {
            obj.style.borderLeftColor = borderLeftColor;
            return obj;
        }

        public static T BorderLeftWidth<T>(this T obj, StyleFloat borderLeftWidth) where T : VisualElement
        {
            obj.style.borderLeftWidth = borderLeftWidth;
            return obj;
        }

        public static T BorderRightColor<T>(this T obj, StyleColor borderRightColor) where T : VisualElement
        {
            obj.style.borderRightColor = borderRightColor;
            return obj;
        }

        public static T BorderRightWidth<T>(this T obj, StyleFloat borderRightWidth) where T : VisualElement
        {
            obj.style.borderRightWidth = borderRightWidth;
            return obj;
        }

        public static T BorderTopColor<T>(this T obj, StyleColor borderTopColor) where T : VisualElement
        {
            obj.style.borderTopColor = borderTopColor;
            return obj;
        }

        public static T BorderTopLeftRadius<T>(this T obj, StyleLength borderTopLeftRadius) where T : VisualElement
        {
            obj.style.borderTopLeftRadius = borderTopLeftRadius;
            return obj;
        }

        public static T BorderTopRightRadius<T>(this T obj, StyleLength borderTopRightRadius) where T : VisualElement
        {
            obj.style.borderTopRightRadius = borderTopRightRadius;
            return obj;
        }

        public static T BorderTopWidth<T>(this T obj, StyleFloat borderTopWidth) where T : VisualElement
        {
            obj.style.borderTopWidth = borderTopWidth;
            return obj;
        }

        public static T Bottom<T>(this T obj, StyleLength bottom) where T : VisualElement
        {
            obj.style.bottom = bottom;
            return obj;
        }

        public static T Color<T>(this T obj, StyleColor color) where T : VisualElement
        {
            obj.style.color = color;
            return obj;
        }

        public static T Cursor<T>(this T obj, StyleCursor cursor) where T : VisualElement
        {
            obj.style.cursor = cursor;
            return obj;
        }

        public static T Display<T>(this T obj, StyleEnum<DisplayStyle> display) where T : VisualElement
        {
            obj.style.display = display;
            return obj;
        }

        public static T FlexBasis<T>(this T obj, StyleLength flexBasis) where T : VisualElement
        {
            obj.style.flexBasis = flexBasis;
            return obj;
        }

        public static T FlexDirection<T>(this T obj, StyleEnum<FlexDirection> flexDirection) where T : VisualElement
        {
            obj.style.flexDirection = flexDirection;
            return obj;
        }

        public static T FlexGrow<T>(this T obj, StyleFloat flexGrow) where T : VisualElement
        {
            obj.style.flexGrow = flexGrow;
            return obj;
        }

        public static T FlexShrink<T>(this T obj, StyleFloat flexShrink) where T : VisualElement
        {
            obj.style.flexShrink = flexShrink;
            return obj;
        }

        public static T FlexWrap<T>(this T obj, StyleEnum<Wrap> flexWrap) where T : VisualElement
        {
            obj.style.flexWrap = flexWrap;
            return obj;
        }

        public static T FontSize<T>(this T obj, StyleLength fontSize) where T : VisualElement
        {
            obj.style.fontSize = fontSize;
            return obj;
        }

        public static T Height<T>(this T obj, StyleLength height) where T : VisualElement
        {
            obj.style.height = height;
            return obj;
        }

        public static T JustifyContent<T>(this T obj, StyleEnum<Justify> justifyContent) where T : VisualElement
        {
            obj.style.justifyContent = justifyContent;
            return obj;
        }

        public static T Left<T>(this T obj, StyleLength left) where T : VisualElement
        {
            obj.style.left = left;
            return obj;
        }

        public static T LetterSpacing<T>(this T obj, StyleLength letterSpacing) where T : VisualElement
        {
            obj.style.letterSpacing = letterSpacing;
            return obj;
        }

        public static T MarginBottom<T>(this T obj, StyleLength marginBottom) where T : VisualElement
        {
            obj.style.marginBottom = marginBottom;
            return obj;
        }

        public static T MarginLeft<T>(this T obj, StyleLength marginLeft) where T : VisualElement
        {
            obj.style.marginLeft = marginLeft;
            return obj;
        }

        public static T MarginRight<T>(this T obj, StyleLength marginRight) where T : VisualElement
        {
            obj.style.marginRight = marginRight;
            return obj;
        }

        public static T MarginTop<T>(this T obj, StyleLength marginTop) where T : VisualElement
        {
            obj.style.marginTop = marginTop;
            return obj;
        }

        public static T MaxHeight<T>(this T obj, StyleLength maxHeight) where T : VisualElement
        {
            obj.style.maxHeight = maxHeight;
            return obj;
        }

        public static T MaxWidth<T>(this T obj, StyleLength maxWidth) where T : VisualElement
        {
            obj.style.maxWidth = maxWidth;
            return obj;
        }

        public static T MinHeight<T>(this T obj, StyleLength minHeight) where T : VisualElement
        {
            obj.style.minHeight = minHeight;
            return obj;
        }

        public static T MinWidth<T>(this T obj, StyleLength minWidth) where T : VisualElement
        {
            obj.style.minWidth = minWidth;
            return obj;
        }

        public static T Opacity<T>(this T obj, StyleFloat opacity) where T : VisualElement
        {
            obj.style.opacity = opacity;
            return obj;
        }

        public static T Overflow<T>(this T obj, StyleEnum<Overflow> overflow) where T : VisualElement
        {
            obj.style.overflow = overflow;
            return obj;
        }

        public static T PaddingBottom<T>(this T obj, StyleLength paddingBottom) where T : VisualElement
        {
            obj.style.paddingBottom = paddingBottom;
            return obj;
        }

        public static T PaddingLeft<T>(this T obj, StyleLength paddingLeft) where T : VisualElement
        {
            obj.style.paddingLeft = paddingLeft;
            return obj;
        }

        public static T PaddingRight<T>(this T obj, StyleLength paddingRight) where T : VisualElement
        {
            obj.style.paddingRight = paddingRight;
            return obj;
        }

        public static T PaddingTop<T>(this T obj, StyleLength paddingTop) where T : VisualElement
        {
            obj.style.paddingTop = paddingTop;
            return obj;
        }

        public static T Position<T>(this T obj, StyleEnum<Position> position) where T : VisualElement
        {
            obj.style.position = position;
            return obj;
        }

        public static T Right<T>(this T obj, StyleLength right) where T : VisualElement
        {
            obj.style.right = right;
            return obj;
        }

        public static T Rotate<T>(this T obj, StyleRotate rotate) where T : VisualElement
        {
            obj.style.rotate = rotate;
            return obj;
        }

        public static T Scale<T>(this T obj, StyleScale scale) where T : VisualElement
        {
            obj.style.scale = scale;
            return obj;
        }

        public static T TextOverflow<T>(this T obj, StyleEnum<TextOverflow> textOverflow) where T : VisualElement
        {
            obj.style.textOverflow = textOverflow;
            return obj;
        }

        public static T TextShadow<T>(this T obj, StyleTextShadow textShadow) where T : VisualElement
        {
            obj.style.textShadow = textShadow;
            return obj;
        }

        public static T Top<T>(this T obj, StyleLength top) where T : VisualElement
        {
            obj.style.top = top;
            return obj;
        }

        public static T TransformOrigin<T>(this T obj, StyleTransformOrigin transformOrigin) where T : VisualElement
        {
            obj.style.transformOrigin = transformOrigin;
            return obj;
        }

        public static T TransitionDelay<T>(this T obj, StyleList<TimeValue> transitionDelay) where T : VisualElement
        {
            obj.style.transitionDelay = transitionDelay;
            return obj;
        }

        public static T TransitionDuration<T>(this T obj, StyleList<TimeValue> transitionDuration)
            where T : VisualElement
        {
            obj.style.transitionDuration = transitionDuration;
            return obj;
        }

        public static T TransitionProperty<T>(this T obj, StyleList<StylePropertyName> transitionProperty)
            where T : VisualElement
        {
            obj.style.transitionProperty = transitionProperty;
            return obj;
        }

        public static T TransitionTimingFunction<T>(this T obj, StyleList<EasingFunction> transitionTimingFunction)
            where T : VisualElement
        {
            obj.style.transitionTimingFunction = transitionTimingFunction;
            return obj;
        }

        public static T Translate<T>(this T obj, StyleTranslate translate) where T : VisualElement
        {
            obj.style.translate = translate;
            return obj;
        }

        public static T UnityBackgroundImageTintColor<T>(this T obj, StyleColor unityBackgroundImageTintColor)
            where T : VisualElement
        {
            obj.style.unityBackgroundImageTintColor = unityBackgroundImageTintColor;
            return obj;
        }

        public static T UnityFont<T>(this T obj, StyleFont unityFont) where T : VisualElement
        {
            obj.style.unityFont = unityFont;
            return obj;
        }

        public static T UnityFontDefinition<T>(this T obj, StyleFontDefinition unityFontDefinition)
            where T : VisualElement
        {
            obj.style.unityFontDefinition = unityFontDefinition;
            return obj;
        }

        public static T UnityFontStyleAndWeight<T>(this T obj, StyleEnum<FontStyle> unityFontStyleAndWeight)
            where T : VisualElement
        {
            obj.style.unityFontStyleAndWeight = unityFontStyleAndWeight;
            return obj;
        }

        public static T UnityOverflowClipBox<T>(this T obj, StyleEnum<OverflowClipBox> unityOverflowClipBox)
            where T : VisualElement
        {
            obj.style.unityOverflowClipBox = unityOverflowClipBox;
            return obj;
        }

        public static T UnityParagraphSpacing<T>(this T obj, StyleLength unityParagraphSpacing) where T : VisualElement
        {
            obj.style.unityParagraphSpacing = unityParagraphSpacing;
            return obj;
        }

        public static T UnitySliceBottom<T>(this T obj, StyleInt unitySliceBottom) where T : VisualElement
        {
            obj.style.unitySliceBottom = unitySliceBottom;
            return obj;
        }

        public static T UnitySliceLeft<T>(this T obj, StyleInt unitySliceLeft) where T : VisualElement
        {
            obj.style.unitySliceLeft = unitySliceLeft;
            return obj;
        }

        public static T UnitySliceRight<T>(this T obj, StyleInt unitySliceRight) where T : VisualElement
        {
            obj.style.unitySliceRight = unitySliceRight;
            return obj;
        }

        public static T UnitySliceScale<T>(this T obj, StyleFloat unitySliceScale) where T : VisualElement
        {
            obj.style.unitySliceScale = unitySliceScale;
            return obj;
        }

        public static T UnitySliceTop<T>(this T obj, StyleInt unitySliceTop) where T : VisualElement
        {
            obj.style.unitySliceTop = unitySliceTop;
            return obj;
        }

        public static T UnityTextAlign<T>(this T obj, StyleEnum<TextAnchor> unityTextAlign) where T : VisualElement
        {
            obj.style.unityTextAlign = unityTextAlign;
            return obj;
        }

        public static T UnityTextOutlineColor<T>(this T obj, StyleColor unityTextOutlineColor) where T : VisualElement
        {
            obj.style.unityTextOutlineColor = unityTextOutlineColor;
            return obj;
        }

        public static T UnityTextOutlineWidth<T>(this T obj, StyleFloat unityTextOutlineWidth) where T : VisualElement
        {
            obj.style.unityTextOutlineWidth = unityTextOutlineWidth;
            return obj;
        }

        public static T UnityTextOverflowPosition<T>(this T obj,
            StyleEnum<TextOverflowPosition> unityTextOverflowPosition) where T : VisualElement
        {
            obj.style.unityTextOverflowPosition = unityTextOverflowPosition;
            return obj;
        }

        public static T Visibility<T>(this T obj, StyleEnum<Visibility> visibility) where T : VisualElement
        {
            obj.style.visibility = visibility;
            return obj;
        }

        public static T WhiteSpace<T>(this T obj, StyleEnum<WhiteSpace> whiteSpace) where T : VisualElement
        {
            obj.style.whiteSpace = whiteSpace;
            return obj;
        }

        public static T Width<T>(this T obj, StyleLength width) where T : VisualElement
        {
            obj.style.width = width;
            return obj;
        }

        public static T WordSpacing<T>(this T obj, StyleLength wordSpacing) where T : VisualElement
        {
            obj.style.wordSpacing = wordSpacing;
            return obj;
        }

        [Obsolete]
        public static T UnityBackgroundScaleMode<T>(this T obj, StyleEnum<ScaleMode> unityBackgroundScaleMode)
            where T : VisualElement
        {
            obj.style.unityBackgroundScaleMode = unityBackgroundScaleMode;
            return obj;
        }
    }
}