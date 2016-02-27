using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using System;
using System.Reflection;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Mono.Cecil
{
    public sealed class NestedEnumMemberWithMonoCecil :
        AbstractNestedEnumMember<AttributeWithMonoCecil, INestedEnum>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly NestedEnumWithMonoCecil declaringType;
        private readonly FieldInfo field;
        private readonly Lazy<Attributes> attributes;

        internal NestedEnumMemberWithMonoCecil(NestedEnumWithMonoCecil declaringType, FieldInfo field)
        {
            this.declaringType = declaringType;
            this.field = field;
            attributes = new Lazy<Attributes>(() => new Attributes(field));
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override INestedEnum DeclaringType
        {
            get { return declaringType; }
        }

        public override string Name
        {
            get { return field.Name; }
        }

        /*
        public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedEnumMemberWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
