using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Wrappers
{
    public interface IClassLambdaPropertyWrapper :
        IClassLambdaProperty<IAttributeGroupWrapper, IClassTypeWrapper, ITypeReferenceWrapper, IExpression>
    {
    }
}
