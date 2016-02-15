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
    public sealed class ReadOnlyExplicitInterfaceIndexer :
        AbstractExplicitInterfaceIndexer<
            AttributeGroupNotSupported,
            IType,
            ReadOnlyInterfaceReference,
            ReadOnlyTypeReference,
            ReadOnlyIndexerParameter,
            ReadOnlyAccessor>
    {
        private readonly ExplicitInterfaceIndexer indexer;
        private readonly ReadOnlyInterfaceReference explicitInterface;
        private readonly ReadOnlyTypeReference indexerType;
        private readonly IReadOnlyList<ReadOnlyIndexerParameter> parameters;
        private readonly ReadOnlyAccessor getAccessor;
        private readonly ReadOnlyAccessor setAccessor;

        public ReadOnlyExplicitInterfaceIndexer(ExplicitInterfaceIndexer indexer)
        {
            this.indexer = indexer;
            explicitInterface = new ReadOnlyInterfaceReference(indexer.ExplicitInterface);
            indexerType = new ReadOnlyTypeReference(indexer.Type);
            parameters = ReadOnlyIndexerParameter.Create(indexer.Parameters);
            if (indexer.GetAccessor != null)
            {
                getAccessor = new ReadOnlyAccessor(indexer.GetAccessor);
            }

            if (indexer.SetAccessor != null)
            {
                setAccessor = new ReadOnlyAccessor(indexer.SetAccessor);
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

        public override ReadOnlyAccessor GetAccessor
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

        public override ReadOnlyAccessor SetAccessor
        {
            get { return setAccessor; }
        }

        public override ReadOnlyInterfaceReference ExplicitInterface
        {
            get { return explicitInterface; }
        }
    }
}
