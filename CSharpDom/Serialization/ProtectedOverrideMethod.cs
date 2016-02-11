using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ProtectedOverrideMethod :
        IProtectedOverrideMethod<AttributeGroup, ISealedType, GenericParameterDeclaration, TypeReference, Parameter, MethodBody>
    {
        public ProtectedOverrideMethod()
        {
            Attributes = new List<AttributeGroup>();
            GenericParameters = new List<GenericParameterDeclaration>();
            Parameters = new List<Parameter>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public MethodBody Body { get; set; }

        public ISealedType DeclaringType
        {
            get { return null; }
        }
        
        public List<GenericParameterDeclaration> GenericParameters { get; set; }
        
        public bool IsAsync { get; set; }

        public bool IsInternal { get; set; }

        public bool IsSealed { get; set; }

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
            visitor.VisitProtectedOverrideMethod(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitMethodChildren(this, visitor);
        }
    }
}
