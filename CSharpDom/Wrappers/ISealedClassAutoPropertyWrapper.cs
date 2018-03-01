using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Wrappers
{
    public interface ISealedClassAutoPropertyWrapper :
        ISealedClassAutoProperty<IAttributeGroupWrapper, ISealedTypeWrapper, ITypeReferenceWrapper, IClassAccessorWrapper, IExpression>
    {
    }
}
