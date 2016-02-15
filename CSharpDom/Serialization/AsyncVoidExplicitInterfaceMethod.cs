using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class AsyncVoidExplicitInterfaceMethod :
        IAsyncVoidExplicitInterfaceMethod<AttributeGroup, IType, InterfaceReference, GenericParameterDeclaration, MethodParameter, MethodBody>
    {
        public AsyncVoidExplicitInterfaceMethod()
        {
            Attributes = new List<AttributeGroup>();
            GenericParameters = new List<GenericParameterDeclaration>();
            Parameters = new List<MethodParameter>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public MethodBody Body { get; set; }

        public IType DeclaringType
        {
            get { return null; }
        }

        public InterfaceReference ExplicitInterface { get; set; }

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
            visitor.VisitAsyncVoidExplicitInterfaceMethod(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAsyncVoidExplicitInterfaceMethodChildren(this, visitor);
        }
    }
}
