using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class AbstractMethod :
        IAbstractMethod<AttributeGroup, IAbstractType, GenericParameterDeclaration, TypeReference, MethodParameter>
    {
        public AbstractMethod()
        {
            Attributes = new List<AttributeGroup>();
            GenericParameters = new List<GenericParameterDeclaration>();
            Parameters = new List<MethodParameter>();
            ReturnAttributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }
        
        public IAbstractType DeclaringType
        {
            get { return null; }
        }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }

        public ClassMemberInheritanceModifier InheritanceModifier { get; set; }
        
        public string Name { get; set; }

        public List<MethodParameter> Parameters { get; set; }

        public List<AttributeGroup> ReturnAttributes { get; set; }

        public TypeReference ReturnType { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

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

        IReadOnlyCollection<AttributeGroup> IHasReturnAttributes<AttributeGroup>.ReturnAttributes
        {
            get { return ReturnAttributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractMethod(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitMethodChildren(this, visitor);
        }
    }
}
