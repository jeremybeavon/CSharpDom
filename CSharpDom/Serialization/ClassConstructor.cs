using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ClassConstructor : IClassConstructor<AttributeGroup, IType, Parameter, MethodBody>
    {
        public ClassConstructor()
        {
            Attributes = new List<AttributeGroup>();
            Parameters = new List<Parameter>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public MethodBody Body { get; set; }

        public IType DeclaringType
        {
            get { return null; }
        }

        public List<Parameter> Parameters { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyList<Parameter> IHasParameters<Parameter>.Parameters
        {
            get { return Parameters; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassConstructor(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitConstructorChildren(this, visitor);
        }
    }
}
