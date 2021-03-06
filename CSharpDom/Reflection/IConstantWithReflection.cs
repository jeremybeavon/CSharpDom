﻿using CSharpDom.Common;
using CSharpDom.Reflection.ConstantExpressions;

namespace CSharpDom.Reflection
{
    public interface IConstantWithReflection : IConstant<IConstantExpressionWithReflection>
    {
    }
}
