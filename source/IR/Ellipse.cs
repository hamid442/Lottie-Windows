// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Toolkit.Uwp.UI.Lottie.Animatables;

namespace Microsoft.Toolkit.Uwp.UI.Lottie.IR
{
#if PUBLIC_IR
    public
#endif
    sealed class Ellipse : Shape
    {
        public Ellipse(
            in ShapeLayerContentArgs args,
            DrawingDirection drawingDirection,
            IAnimatableVector2 position,
            IAnimatableVector2 diameter)
            : base(in args, drawingDirection)
        {
            Position = position;
            Diameter = diameter;
        }

        public IAnimatableVector2 Position { get; }

        public IAnimatableVector2 Diameter { get; }

        /// <inheritdoc/>
        public override ShapeContentType ContentType => ShapeContentType.Ellipse;

        public override ShapeType ShapeType => ShapeType.Ellipse;
    }
}
