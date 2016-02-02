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
            IType,
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

        public override IType DeclaringType
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

        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get
            {
                switch (indexer.InheritanceModifier)
                {
                    case IndexerInheritanceModifier.None:
                        return CSharpDom.ClassMemberInheritanceModifier.None;
                    case IndexerInheritanceModifier.Abstract:
                        return CSharpDom.ClassMemberInheritanceModifier.Abstract;
                    case IndexerInheritanceModifier.New:
                        return CSharpDom.ClassMemberInheritanceModifier.New;
                    case IndexerInheritanceModifier.NewVirtual:
                        return CSharpDom.ClassMemberInheritanceModifier.NewVirtual;
                    case IndexerInheritanceModifier.Override:
                        return CSharpDom.ClassMemberInheritanceModifier.Override;
                    case IndexerInheritanceModifier.SealedOverride:
                        return CSharpDom.ClassMemberInheritanceModifier.SealedOverride;
                    case IndexerInheritanceModifier.Virtual:
                        return CSharpDom.ClassMemberInheritanceModifier.Virtual;
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

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return ReadOnlyClass.GetVisibility(indexer.Visibility); }
        }
    }
}
