using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructIndexer :
        AbstractStructIndexer<
            AttributeGroupNotSupported,
            IType,
            ReadOnlyTypeReference,
            ReadOnlyMethodParameter,
            ReadOnlyStructPropertyAccessor>
    {
        private readonly StructIndexer indexer;
        private readonly ReadOnlyTypeReference indexerType;
        private readonly IReadOnlyList<ReadOnlyMethodParameter> parameters;
        private readonly ReadOnlyStructPropertyAccessor getAccessor;
        private readonly ReadOnlyStructPropertyAccessor setAccessor;

        public ReadOnlyStructIndexer(StructIndexer indexer)
        {
            this.indexer = indexer;
            indexerType = new ReadOnlyTypeReference(indexer.Type);
            parameters = ReadOnlyMethodParameter.Create(indexer.Parameters);
            if (indexer.GetAccessor != null)
            {
                getAccessor = new ReadOnlyStructPropertyAccessor(indexer.GetAccessor);
            }

            if (indexer.SetAccessor != null)
            {
                setAccessor = new ReadOnlyStructPropertyAccessor(indexer.SetAccessor);
            }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IType DeclaringType
        {
            get { return null; }
        }

        public override ReadOnlyStructPropertyAccessor GetAccessor
        {
            get { return getAccessor; }
        }

        public override ReadOnlyTypeReference IndexerType
        {
            get { return indexerType; }
        }
        
        public override IReadOnlyList<ReadOnlyMethodParameter> Parameters
        {
            get { return parameters; }
        }

        public override ReadOnlyStructPropertyAccessor SetAccessor
        {
            get { return setAccessor; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return indexer.Visibility; }
        }
    }
}
