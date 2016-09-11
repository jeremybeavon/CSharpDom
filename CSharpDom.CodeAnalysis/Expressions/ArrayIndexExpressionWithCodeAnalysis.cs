using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class ArrayIndexExpressionWithCodeAnalysis :
        EditableArrayIndexExpression<IExpressionWithCodeAnalysis>,
        IH
    {

    }
}
