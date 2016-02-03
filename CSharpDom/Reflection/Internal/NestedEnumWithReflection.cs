using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System.Linq;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class NestedEnumWithReflection :
        AbstractNestedEnum<AttributeWithReflection, ITypeWithReflection, NestedEnumMemberWithReflection>,
        IHasType//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeWithReflection declaringType;
        private readonly Type type;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<IReadOnlyList<NestedEnumMemberWithReflection>> enumMembers;

        internal NestedEnumWithReflection(ITypeWithReflection declaringType, Type type)
        {
            this.declaringType = declaringType;
            this.type = type;
            attributes = new Lazy<Attributes>(() => new Attributes(type));
            enumMembers = new Lazy<IReadOnlyList<NestedEnumMemberWithReflection>>(InitializeEnumMembers);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyList<NestedEnumMemberWithReflection> EnumMembers
        {
            get { return enumMembers.Value; }
        }

        public override string Name
        {
            get { return type.Name; }
        }
        
        public Type Type
        {
            get { return type; }
        }

        public override EnumBaseType BaseType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedEnumWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/

        private IReadOnlyList<NestedEnumMemberWithReflection> InitializeEnumMembers()
        {
            return type.GetAllFields().Select(field => new NestedEnumMemberWithReflection(this, field)).ToList();
        }
    }
}
