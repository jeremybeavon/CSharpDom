using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class NestedEnumMemberWrapper : AbstractWrapper<INestedEnumMember>, INestedEnumMemberWrapper
    {
        public NestedEnumMemberWrapper(INestedEnumMember nestedEnumMember)
            : base(nestedEnumMember)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public INestedEnumWrapper DeclaringType
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

        public void Accept(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public override void VisitNestedEnumMember<TAttributeGroup, TDeclaringType>(
            INestedEnumMember<TAttributeGroup, TDeclaringType> nestedEnumMember)
        {
        }
    }
}
