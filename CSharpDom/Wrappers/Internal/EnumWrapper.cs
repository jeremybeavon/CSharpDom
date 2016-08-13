using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class EnumWrapper : AbstractWrapper<IEnum>, IEnumWrapper
    {
        public EnumWrapper(IEnum @enum)
            : base(@enum)
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

        public IDocumentWrapper Document
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyList<IEnumMemberWrapper> EnumMembers
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

        public INamespaceWrapper Namespace
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IProjectWrapper Project
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ISolutionWrapper Solution
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public TypeVisibilityModifier Visibility
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

        public override void VisitEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember>(
            IEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember> @enum)
        {
        }
    }
}
