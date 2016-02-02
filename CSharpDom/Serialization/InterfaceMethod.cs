using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class InterfaceMethod :
        IInterfaceMethod<AttributeGroup, IBasicType, GenericParameterDeclaration, TypeReference, Parameter>
    {
        public InterfaceMethod()
        {
            Attributes = new List<AttributeGroup>();
            GenericParameters = new List<GenericParameterDeclaration>();
            Parameters = new List<Parameter>();
        }

        public List<AttributeGroup> Attributes { get; set; }
        
        public IBasicType DeclaringType
        {
            get { return null; }
        }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }

        public InterfaceMemberInheritanceModifier InheritanceModifier { get; set; }

        public string Name { get; set; }

        public List<Parameter> Parameters { get; set; }

        public TypeReference ReturnType { get; set; }
        
        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyList<GenericParameterDeclaration> IHasGenericParameters<GenericParameterDeclaration>.GenericParameters
        {
            get { return GenericParameters; }
        }

        IReadOnlyList<Parameter> IHasParameters<Parameter>.Parameters
        {
            get { return Parameters; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterfaceMethod(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitMethodChildren(this, visitor);
        }
    }
}
