using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class EnumMemberWrapper : AbstractWrapper<IEnumMember>, IEnumMemberWrapper
    {
        public EnumMemberWrapper(IEnumMember enumMember)
            : base(enumMember)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumWrapper DeclaringType
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

        public override void VisitEnumMember<TAttributeGroup, TDeclaringType>(
            IEnumMember<TAttributeGroup, TDeclaringType> enumMember)
        {
        }
    }
}
