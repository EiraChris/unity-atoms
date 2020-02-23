using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Color`. Inherits from `EquatableAtomReference&lt;Color, ColorConstant, ColorVariable, ColorEvent, ColorColorEvent, ColorColorFunction, ColorVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColorReference : EquatableAtomReference<
        Color,
        ColorConstant,
        ColorVariable,
        ColorEvent,
        ColorColorEvent,
        ColorColorFunction,
        ColorVariableInstancer>, IEquatable<ColorReference>
    {
        public ColorReference() : base() { }
        public ColorReference(Color value) : base(value) { }
        public bool Equals(ColorReference other) { return base.Equals(other); }
    }
}