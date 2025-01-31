using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace Tactile.UI.UIToolkitExtensions.Extensions
{
    public static class StyleExtensions
    {
        public static T AlignContent<T>(this T obj, StyleEnum<Align> alignContent) where T : IStyle
        {
            obj.alignContent = alignContent;
            return obj;
        }

        public static T AlignItems<T>(this T obj, StyleEnum<Align> alignItems) where T : IStyle
        {
            obj.alignItems = alignItems;
            return obj;
        }

        public static T AlignSelf<T>(this T obj, StyleEnum<Align> alignSelf) where T : IStyle
        {
            obj.alignSelf = alignSelf;
            return obj;
        }

        public static T BackgroundColor<T>(this T obj, StyleColor backgroundColor) where T : IStyle
        {
            obj.backgroundColor = backgroundColor;
            return obj;
        }

        public static T BackgroundImage<T>(this T obj, StyleBackground backgroundImage) where T : IStyle
        {
            obj.backgroundImage = backgroundImage;
            return obj;
        }

        public static T BackgroundPositionX<T>(this T obj, StyleBackgroundPosition backgroundPositionX) where T : IStyle
        {
            obj.backgroundPositionX = backgroundPositionX;
            return obj;
        }

        public static T BackgroundPositionY<T>(this T obj, StyleBackgroundPosition backgroundPositionY) where T : IStyle
        {
            obj.backgroundPositionY = backgroundPositionY;
            return obj;
        }

        public static T BackgroundRepeat<T>(this T obj, StyleBackgroundRepeat backgroundRepeat) where T : IStyle
        {
            obj.backgroundRepeat = backgroundRepeat;
            return obj;
        }

        public static T BackgroundSize<T>(this T obj, StyleBackgroundSize backgroundSize) where T : IStyle
        {
            obj.backgroundSize = backgroundSize;
            return obj;
        }

        public static T BorderBottomColor<T>(this T obj, StyleColor borderBottomColor) where T : IStyle
        {
            obj.borderBottomColor = borderBottomColor;
            return obj;
        }

        public static T BorderBottomLeftRadius<T>(this T obj, StyleLength borderBottomLeftRadius) where T : IStyle
        {
            obj.borderBottomLeftRadius = borderBottomLeftRadius;
            return obj;
        }

        public static T BorderBottomRightRadius<T>(this T obj, StyleLength borderBottomRightRadius) where T : IStyle
        {
            obj.borderBottomRightRadius = borderBottomRightRadius;
            return obj;
        }

        public static T BorderBottomWidth<T>(this T obj, StyleFloat borderBottomWidth) where T : IStyle
        {
            obj.borderBottomWidth = borderBottomWidth;
            return obj;
        }

        public static T BorderLeftColor<T>(this T obj, StyleColor borderLeftColor) where T : IStyle
        {
            obj.borderLeftColor = borderLeftColor;
            return obj;
        }

        public static T BorderLeftWidth<T>(this T obj, StyleFloat borderLeftWidth) where T : IStyle
        {
            obj.borderLeftWidth = borderLeftWidth;
            return obj;
        }

        public static T BorderRightColor<T>(this T obj, StyleColor borderRightColor) where T : IStyle
        {
            obj.borderRightColor = borderRightColor;
            return obj;
        }

        public static T BorderRightWidth<T>(this T obj, StyleFloat borderRightWidth) where T : IStyle
        {
            obj.borderRightWidth = borderRightWidth;
            return obj;
        }

        public static T BorderTopColor<T>(this T obj, StyleColor borderTopColor) where T : IStyle
        {
            obj.borderTopColor = borderTopColor;
            return obj;
        }

        public static T BorderTopLeftRadius<T>(this T obj, StyleLength borderTopLeftRadius) where T : IStyle
        {
            obj.borderTopLeftRadius = borderTopLeftRadius;
            return obj;
        }

        public static T BorderTopRightRadius<T>(this T obj, StyleLength borderTopRightRadius) where T : IStyle
        {
            obj.borderTopRightRadius = borderTopRightRadius;
            return obj;
        }

        public static T BorderTopWidth<T>(this T obj, StyleFloat borderTopWidth) where T : IStyle
        {
            obj.borderTopWidth = borderTopWidth;
            return obj;
        }

        public static T Bottom<T>(this T obj, StyleLength bottom) where T : IStyle
        {
            obj.bottom = bottom;
            return obj;
        }

        public static T Color<T>(this T obj, StyleColor color) where T : IStyle
        {
            obj.color = color;
            return obj;
        }

        public static T Cursor<T>(this T obj, StyleCursor cursor) where T : IStyle
        {
            obj.cursor = cursor;
            return obj;
        }

        public static T Display<T>(this T obj, StyleEnum<DisplayStyle> display) where T : IStyle
        {
            obj.display = display;
            return obj;
        }

        public static T FlexBasis<T>(this T obj, StyleLength flexBasis) where T : IStyle
        {
            obj.flexBasis = flexBasis;
            return obj;
        }

        public static T FlexDirection<T>(this T obj, StyleEnum<FlexDirection> flexDirection) where T : IStyle
        {
            obj.flexDirection = flexDirection;
            return obj;
        }

        public static T FlexGrow<T>(this T obj, StyleFloat flexGrow) where T : IStyle
        {
            obj.flexGrow = flexGrow;
            return obj;
        }

        public static T FlexShrink<T>(this T obj, StyleFloat flexShrink) where T : IStyle
        {
            obj.flexShrink = flexShrink;
            return obj;
        }

        public static T FlexWrap<T>(this T obj, StyleEnum<Wrap> flexWrap) where T : IStyle
        {
            obj.flexWrap = flexWrap;
            return obj;
        }

        public static T FontSize<T>(this T obj, StyleLength fontSize) where T : IStyle
        {
            obj.fontSize = fontSize;
            return obj;
        }

        public static T Height<T>(this T obj, StyleLength height) where T : IStyle
        {
            obj.height = height;
            return obj;
        }

        public static T JustifyContent<T>(this T obj, StyleEnum<Justify> justifyContent) where T : IStyle
        {
            obj.justifyContent = justifyContent;
            return obj;
        }

        public static T Left<T>(this T obj, StyleLength left) where T : IStyle
        {
            obj.left = left;
            return obj;
        }

        public static T LetterSpacing<T>(this T obj, StyleLength letterSpacing) where T : IStyle
        {
            obj.letterSpacing = letterSpacing;
            return obj;
        }

        public static T MarginBottom<T>(this T obj, StyleLength marginBottom) where T : IStyle
        {
            obj.marginBottom = marginBottom;
            return obj;
        }

        public static T MarginLeft<T>(this T obj, StyleLength marginLeft) where T : IStyle
        {
            obj.marginLeft = marginLeft;
            return obj;
        }

        public static T MarginRight<T>(this T obj, StyleLength marginRight) where T : IStyle
        {
            obj.marginRight = marginRight;
            return obj;
        }

        public static T MarginTop<T>(this T obj, StyleLength marginTop) where T : IStyle
        {
            obj.marginTop = marginTop;
            return obj;
        }

        public static T MaxHeight<T>(this T obj, StyleLength maxHeight) where T : IStyle
        {
            obj.maxHeight = maxHeight;
            return obj;
        }

        public static T MaxWidth<T>(this T obj, StyleLength maxWidth) where T : IStyle
        {
            obj.maxWidth = maxWidth;
            return obj;
        }

        public static T MinHeight<T>(this T obj, StyleLength minHeight) where T : IStyle
        {
            obj.minHeight = minHeight;
            return obj;
        }

        public static T MinWidth<T>(this T obj, StyleLength minWidth) where T : IStyle
        {
            obj.minWidth = minWidth;
            return obj;
        }

        public static T Opacity<T>(this T obj, StyleFloat opacity) where T : IStyle
        {
            obj.opacity = opacity;
            return obj;
        }

        public static T Overflow<T>(this T obj, StyleEnum<Overflow> overflow) where T : IStyle
        {
            obj.overflow = overflow;
            return obj;
        }

        public static T PaddingBottom<T>(this T obj, StyleLength paddingBottom) where T : IStyle
        {
            obj.paddingBottom = paddingBottom;
            return obj;
        }

        public static T PaddingLeft<T>(this T obj, StyleLength paddingLeft) where T : IStyle
        {
            obj.paddingLeft = paddingLeft;
            return obj;
        }

        public static T PaddingRight<T>(this T obj, StyleLength paddingRight) where T : IStyle
        {
            obj.paddingRight = paddingRight;
            return obj;
        }

        public static T PaddingTop<T>(this T obj, StyleLength paddingTop) where T : IStyle
        {
            obj.paddingTop = paddingTop;
            return obj;
        }

        public static T Position<T>(this T obj, StyleEnum<Position> position) where T : IStyle
        {
            obj.position = position;
            return obj;
        }

        public static T Right<T>(this T obj, StyleLength right) where T : IStyle
        {
            obj.right = right;
            return obj;
        }

        public static T Rotate<T>(this T obj, StyleRotate rotate) where T : IStyle
        {
            obj.rotate = rotate;
            return obj;
        }

        public static T Scale<T>(this T obj, StyleScale scale) where T : IStyle
        {
            obj.scale = scale;
            return obj;
        }

        public static T TextOverflow<T>(this T obj, StyleEnum<TextOverflow> textOverflow) where T : IStyle
        {
            obj.textOverflow = textOverflow;
            return obj;
        }

        public static T TextShadow<T>(this T obj, StyleTextShadow textShadow) where T : IStyle
        {
            obj.textShadow = textShadow;
            return obj;
        }

        public static T Top<T>(this T obj, StyleLength top) where T : IStyle
        {
            obj.top = top;
            return obj;
        }

        public static T TransformOrigin<T>(this T obj, StyleTransformOrigin transformOrigin) where T : IStyle
        {
            obj.transformOrigin = transformOrigin;
            return obj;
        }

        public static T TransitionDelay<T>(this T obj, StyleList<TimeValue> transitionDelay) where T : IStyle
        {
            obj.transitionDelay = transitionDelay;
            return obj;
        }

        public static T TransitionDuration<T>(this T obj, StyleList<TimeValue> transitionDuration) where T : IStyle
        {
            obj.transitionDuration = transitionDuration;
            return obj;
        }

        public static T TransitionProperty<T>(this T obj, StyleList<StylePropertyName> transitionProperty)
            where T : IStyle
        {
            obj.transitionProperty = transitionProperty;
            return obj;
        }

        public static T TransitionTimingFunction<T>(this T obj, StyleList<EasingFunction> transitionTimingFunction)
            where T : IStyle
        {
            obj.transitionTimingFunction = transitionTimingFunction;
            return obj;
        }

        public static T Translate<T>(this T obj, StyleTranslate translate) where T : IStyle
        {
            obj.translate = translate;
            return obj;
        }

        public static T UnityBackgroundImageTintColor<T>(this T obj, StyleColor unityBackgroundImageTintColor)
            where T : IStyle
        {
            obj.unityBackgroundImageTintColor = unityBackgroundImageTintColor;
            return obj;
        }

        public static T UnityFont<T>(this T obj, StyleFont unityFont) where T : IStyle
        {
            obj.unityFont = unityFont;
            return obj;
        }

        public static T UnityFontDefinition<T>(this T obj, StyleFontDefinition unityFontDefinition) where T : IStyle
        {
            obj.unityFontDefinition = unityFontDefinition;
            return obj;
        }

        public static T UnityFontStyleAndWeight<T>(this T obj, StyleEnum<FontStyle> unityFontStyleAndWeight)
            where T : IStyle
        {
            obj.unityFontStyleAndWeight = unityFontStyleAndWeight;
            return obj;
        }

        public static T UnityOverflowClipBox<T>(this T obj, StyleEnum<OverflowClipBox> unityOverflowClipBox)
            where T : IStyle
        {
            obj.unityOverflowClipBox = unityOverflowClipBox;
            return obj;
        }

        public static T UnityParagraphSpacing<T>(this T obj, StyleLength unityParagraphSpacing) where T : IStyle
        {
            obj.unityParagraphSpacing = unityParagraphSpacing;
            return obj;
        }

        public static T UnitySliceBottom<T>(this T obj, StyleInt unitySliceBottom) where T : IStyle
        {
            obj.unitySliceBottom = unitySliceBottom;
            return obj;
        }

        public static T UnitySliceLeft<T>(this T obj, StyleInt unitySliceLeft) where T : IStyle
        {
            obj.unitySliceLeft = unitySliceLeft;
            return obj;
        }

        public static T UnitySliceRight<T>(this T obj, StyleInt unitySliceRight) where T : IStyle
        {
            obj.unitySliceRight = unitySliceRight;
            return obj;
        }

        public static T UnitySliceScale<T>(this T obj, StyleFloat unitySliceScale) where T : IStyle
        {
            obj.unitySliceScale = unitySliceScale;
            return obj;
        }

        public static T UnitySliceTop<T>(this T obj, StyleInt unitySliceTop) where T : IStyle
        {
            obj.unitySliceTop = unitySliceTop;
            return obj;
        }

        public static T UnityTextAlign<T>(this T obj, StyleEnum<TextAnchor> unityTextAlign) where T : IStyle
        {
            obj.unityTextAlign = unityTextAlign;
            return obj;
        }

        public static T UnityTextOutlineColor<T>(this T obj, StyleColor unityTextOutlineColor) where T : IStyle
        {
            obj.unityTextOutlineColor = unityTextOutlineColor;
            return obj;
        }

        public static T UnityTextOutlineWidth<T>(this T obj, StyleFloat unityTextOutlineWidth) where T : IStyle
        {
            obj.unityTextOutlineWidth = unityTextOutlineWidth;
            return obj;
        }

        public static T UnityTextOverflowPosition<T>(this T obj,
            StyleEnum<TextOverflowPosition> unityTextOverflowPosition) where T : IStyle
        {
            obj.unityTextOverflowPosition = unityTextOverflowPosition;
            return obj;
        }

        public static T Visibility<T>(this T obj, StyleEnum<Visibility> visibility) where T : IStyle
        {
            obj.visibility = visibility;
            return obj;
        }

        public static T WhiteSpace<T>(this T obj, StyleEnum<WhiteSpace> whiteSpace) where T : IStyle
        {
            obj.whiteSpace = whiteSpace;
            return obj;
        }

        public static T Width<T>(this T obj, StyleLength width) where T : IStyle
        {
            obj.width = width;
            return obj;
        }

        public static T WordSpacing<T>(this T obj, StyleLength wordSpacing) where T : IStyle
        {
            obj.wordSpacing = wordSpacing;
            return obj;
        }

        [Obsolete]
        public static T UnityBackgroundScaleMode<T>(this T obj, StyleEnum<ScaleMode> unityBackgroundScaleMode)
            where T : IStyle
        {
            obj.unityBackgroundScaleMode = unityBackgroundScaleMode;
            return obj;
        }
    }
}