using CSharpDom.BaseClasses;
using System.Reflection;
using System;
using System.Collections.Generic;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class EnumMemberWithCodeAnalysis :
        AbstractEnumMember<AttributeGroupWithCodeAnalysis, EnumWithCodeAnalysis>,
        IHasFieldDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly EnumWithCodeAnalysis declaringType;
        private readonly FieldDefinition field;
        private readonly Lazy<Attributes> attributes;

        internal EnumMemberWithCodeAnalysis(EnumWithCodeAnalysis declaringType, FieldDefinition field)
        {
            this.declaringType = declaringType;
            this.field = field;
            attributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, field));
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override EnumWithCodeAnalysis DeclaringType
        {
            get { return declaringType; }
        }

        public override string Name
        {
            get { return field.Name; }
        }

        public FieldDefinition FieldDefinition
        {
            get { return field; }
        }


        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitEnumMemberWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
