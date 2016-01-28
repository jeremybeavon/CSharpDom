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
        AbstractIndexer<
            AttributeGroupNotSupported,
            IBasicType,
            ReadOnlyTypeReference,
            ReadOnlyMethodParameter,
            ReadOnlyClassPropertyAccessor>
    {
        private readonly ClassIndexer indexer;
        private readonly ReadOnlyTypeReference indexerType;
        private readonly IReadOnlyList<ReadOnlyMethodParameter> parameters;
        private readonly ReadOnlyClassPropertyAccessor getAccessor;
        private readonly ReadOnlyClassPropertyAccessor setAccessor;

        public ReadOnlyClassIndexer(ClassIndexer indexer)
        {
            this.indexer = indexer;
            indexerType = new ReadOnlyTypeReference(indexer.Type);
            parameters = ReadOnlyMethodParameter.Create(indexer.Parameters);
            if (indexer.EmptyAccessors != null)
            {
                getAccessor = new ReadOnlyClassPropertyAccessor(indexer.EmptyAccessors.GetAccessorVisibility);
                setAccessor = new ReadOnlyClassPropertyAccessor(indexer.EmptyAccessors.SetAccessorVisibility);
            }
            else
            {
                if (indexer.GetAccessor != null)
                {
                    getAccessor = new ReadOnlyClassPropertyAccessor(indexer.GetAccessor);
                }

                if (indexer.SetAccessor != null)
                {
                    setAccessor = new ReadOnlyClassPropertyAccessor(indexer.SetAccessor);
                }
            }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IBasicType DeclaringType
        {
            get { return null; }
        }

        public override ReadOnlyClassPropertyAccessor GetAccessor
        {
            get { return getAccessor; }
        }

        public override ReadOnlyTypeReference IndexerType
        {
            get { return indexerType; }
        }

        public override MemberInheritanceModifier InheritanceModifier
        {
            get
            {
                switch (indexer.InheritanceModifier)
                {
                    case IndexerInheritanceModifier.None:
                        return MemberInheritanceModifier.None;
                    case IndexerInheritanceModifier.Abstract:
                        return MemberInheritanceModifier.Abstract;
                    case IndexerInheritanceModifier.New:
                        return MemberInheritanceModifier.New;
                    case IndexerInheritanceModifier.NewVirtual:
                        return MemberInheritanceModifier.NewVirtual;
                    case IndexerInheritanceModifier.Override:
                        return MemberInheritanceModifier.Override;
                    case IndexerInheritanceModifier.SealedOverride:
                        return MemberInheritanceModifier.SealedOverride;
                    case IndexerInheritanceModifier.Virtual:
                        return MemberInheritanceModifier.Virtual;
                    default:
                        throw new NotSupportedException();
                }
            }
        }

        public override IReadOnlyList<ReadOnlyMethodParameter> Parameters
        {
            get { return parameters; }
        }

        public override ReadOnlyClassPropertyAccessor SetAccessor
        {
            get { return setAccessor; }
        }

        public override MemberVisibilityModifier Visibility
        {
            get { return ReadOnlyClass.GetVisibility(indexer.Visibility); }
        }
    }
}
