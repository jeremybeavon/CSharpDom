using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class TypeReferenceWrapper : AbstractTypeReference, IWrapper<ITypeReference>
    {
        public TypeReferenceWrapper(ITypeReference typeReference)
        {
            WrappedObject = typeReference;
        }
        
        public ITypeReference WrappedObject { get; private set; }
    }
}
