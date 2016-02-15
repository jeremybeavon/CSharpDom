using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class AsyncVoidExtensionMethod :
        IAsyncVoidExtensionMethod<AttributeGroup, IStaticClass, GenericParameterDeclaration, ExtensionParameter, MethodParameter, MethodBody>
    {
        public AsyncVoidExtensionMethod()
        {
            Attributes = new List<AttributeGroup>();
            GenericParameters = new List<GenericParameterDeclaration>();
            Parameters = new List<MethodParameter>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public MethodBody Body { get; set; }

        public IStaticClass DeclaringType
        {
            get { return null; }
        }

        public ExtensionParameter ExtensionParameter { get; set; }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }
        
        public string Name { get; set; }

        public List<MethodParameter> Parameters { get; set; }
        
        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyList<GenericParameterDeclaration> IHasGenericParameters<GenericParameterDeclaration>.GenericParameters
        {
            get { return GenericParameters; }
        }

        IReadOnlyList<MethodParameter> IHasParameters<MethodParameter>.Parameters
        {
            get { return Parameters; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAsyncVoidExtensionMethod(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAsyncVoidExtensionMethodChildren(this, visitor);
        }
    }
}
