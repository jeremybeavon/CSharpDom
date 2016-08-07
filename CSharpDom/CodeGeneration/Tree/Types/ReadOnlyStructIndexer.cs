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
            IStructType,
            ReadOnlyTypeReference,
            ReadOnlyIndexerParameter,
            ReadOnlyStructAccessor>
    {
        private readonly StructIndexer indexer;
        private readonly ReadOnlyTypeReference indexerType;
        private readonly IReadOnlyList<ReadOnlyIndexerParameter> parameters;
        private readonly ReadOnlyStructAccessor getAccessor;
        private readonly ReadOnlyStructAccessor setAccessor;

        public ReadOnlyStructIndexer(StructIndexer indexer)
        {
            this.indexer = indexer;
            indexerType = new ReadOnlyTypeReference(indexer.Type);
            parameters = ReadOnlyIndexerParameter.Create(indexer.Parameters);
            if (indexer.GetAccessor != null)
            {
                getAccessor = new ReadOnlyStructAccessor(indexer.GetAccessor);
            }

            if (indexer.SetAccessor != null)
            {
                setAccessor = new ReadOnlyStructAccessor(indexer.SetAccessor);
            }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IStructType DeclaringType
        {
            get { return null; }
        }

        public override ReadOnlyStructAccessor GetAccessor
        {
            get { return getAccessor; }
        }

        public override ReadOnlyTypeReference IndexerType
        {
            get { return indexerType; }
        }
        
        public override IReadOnlyList<ReadOnlyIndexerParameter> Parameters
        {
            get { return parameters; }
        }

        public override ReadOnlyStructAccessor SetAccessor
        {
            get { return setAccessor; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return indexer.Visibility; }
        }
    }
}
