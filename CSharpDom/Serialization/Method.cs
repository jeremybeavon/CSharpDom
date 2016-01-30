using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class Method :
        IMethod<AttributeGroup, IBasicType, IGenericParameterDeclaration, TypeReference, Parameter, MethodBody>
    {
        public Method()
        {
            Attributes = new List<AttributeGroup>();
            GenericParameters = new List<IGenericParameterDeclaration>();
            Parameters = new List<Parameter>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public MethodBody Body { get; set; }

        public IBasicType DeclaringType
        {
            get { return null; }
        }

        public List<IGenericParameterDeclaration> GenericParameters { get; set; }

        public MemberInheritanceModifier InheritanceModifier { get; set; }

        public string Name { get; set; }

        public List<Parameter> Parameters { get; set; }

        public TypeReference ReturnType { get; set; }

        public MemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyList<IGenericParameterDeclaration> IHasGenericParameters<IGenericParameterDeclaration>.GenericParameters
        {
            get { return GenericParameters; }
        }

        IReadOnlyList<Parameter> IHasParameters<Parameter>.Parameters
        {
            get { return Parameters; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitMethod(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitMethodChildren(this, visitor);
        }
    }
}
