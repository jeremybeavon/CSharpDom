using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class InterfaceIndexerWithMonoCecil :
        AbstractInterfaceIndexer<
            AttributeWithMonoCecil,
            IBasicTypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            IndexerParameterWithMonoCecil,
            InterfaceAccessorWithMonoCecil>
    {
        private readonly PropertyInfo indexer;
        private readonly IBasicTypeWithMonoCecil declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithMonoCecil indexerType;
        private readonly InterfaceAccessorWithMonoCecil getAccessor;
        private readonly InterfaceAccessorWithMonoCecil setAccessor;
        private readonly Lazy<Parameters<IndexerParameterWithMonoCecil>> parameters;

        internal InterfaceIndexerWithMonoCecil(IBasicTypeWithMonoCecil declaringType, PropertyInfo indexer)
        {
            this.indexer = indexer;
            this.declaringType = declaringType;
            attributes = new Lazy<Attributes>(() => new Attributes(indexer));
            indexerType = TypeReferenceWithMonoCecilFactory.CreateReference(indexer.PropertyType);
            parameters = new Lazy<Parameters<IndexerParameterWithMonoCecil>>(
                () => new Parameters<IndexerParameterWithMonoCecil>(indexer, parameter => new IndexerParameterWithMonoCecil(parameter)));
            if (indexer.GetMethod != null)
            {
                getAccessor = new InterfaceAccessorWithMonoCecil(indexer.GetMethod);
            }

            if (indexer.SetMethod != null)
            {
                setAccessor = new InterfaceAccessorWithMonoCecil(indexer.SetMethod);
            }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override IBasicTypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }

        public override InterfaceAccessorWithMonoCecil GetAccessor
        {
            get { return getAccessor; }
        }
        
        public override ITypeReferenceWithMonoCecil IndexerType
        {
            get { return indexerType; }
        }

        public override InterfaceMemberInheritanceModifier InheritanceModifier
        {
            get
            {
                if ((indexer.GetMethod ?? indexer.SetMethod).IsHideBySig)
                {
                    return InterfaceMemberInheritanceModifier.New;
                }

                return InterfaceMemberInheritanceModifier.None;
            }
        }

        public override IReadOnlyList<IndexerParameterWithMonoCecil> Parameters
        {
            get { return parameters.Value.ParametersWithMonoCecil; }
        }

        public override InterfaceAccessorWithMonoCecil SetAccessor
        {
            get { return setAccessor; }
        }
    }
}
