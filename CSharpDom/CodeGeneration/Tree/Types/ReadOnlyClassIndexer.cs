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
    public sealed class ReadOnlyClassIndexer :
        AbstractClassIndexer<
            AttributeGroupNotSupported,
            IClassType,
            ReadOnlyTypeReference,
            ReadOnlyIndexerParameter,
            ReadOnlyClassAccessor>
    {
        private readonly ClassIndexer indexer;
        private readonly ReadOnlyTypeReference indexerType;
        private readonly IReadOnlyList<ReadOnlyIndexerParameter> parameters;
        private readonly ReadOnlyClassAccessor getAccessor;
        private readonly ReadOnlyClassAccessor setAccessor;

        public ReadOnlyClassIndexer(ClassIndexer indexer)
        {
            this.indexer = indexer;
            indexerType = new ReadOnlyTypeReference(indexer.Type);
            parameters = ReadOnlyIndexerParameter.Create(indexer.Parameters);
            if (indexer.EmptyAccessors != null)
            {
                getAccessor = new ReadOnlyClassAccessor(indexer.EmptyAccessors.GetAccessorVisibility);
                setAccessor = new ReadOnlyClassAccessor(indexer.EmptyAccessors.SetAccessorVisibility);
            }
            else
            {
                if (indexer.GetAccessor != null)
                {
                    getAccessor = new ReadOnlyClassAccessor(indexer.GetAccessor);
                }

                if (indexer.SetAccessor != null)
                {
                    setAccessor = new ReadOnlyClassAccessor(indexer.SetAccessor);
                }
            }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IClassType DeclaringType
        {
            get { return null; }
        }

        public override ReadOnlyClassAccessor GetAccessor
        {
            get { return getAccessor; }
        }

        public override ReadOnlyTypeReference IndexerType
        {
            get { return indexerType; }
        }

        public override IndexerInheritanceModifier InheritanceModifier
        {
            get { return indexer.InheritanceModifier; }
        }

        public override IReadOnlyList<ReadOnlyIndexerParameter> Parameters
        {
            get { return parameters; }
        }

        public override ReadOnlyClassAccessor SetAccessor
        {
            get { return setAccessor; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return indexer.Visibility; }
        }
    }
}
