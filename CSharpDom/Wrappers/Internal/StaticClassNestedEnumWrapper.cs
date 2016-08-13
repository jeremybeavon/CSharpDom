using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassNestedEnumWrapper : AbstractWrapper<IStaticClassNestedEnum>, IStaticClassNestedEnumWrapper
    {
        public StaticClassNestedEnumWrapper(IStaticClassNestedEnum nestedEnum)
            : base(nestedEnum)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public EnumBaseType BaseType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IStaticTypeWrapper DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyList<INestedEnumMemberWrapper> EnumMembers
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ClassMemberVisibilityModifier Visibility
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Accept(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public override void VisitStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(IStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
        }
    }
}
