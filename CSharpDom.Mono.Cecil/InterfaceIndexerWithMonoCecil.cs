using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class InterfaceIndexerWithMonoCecil :
        AbstractInterfaceIndexer<
            AttributeWithMonoCecil,
            IInterfaceTypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            IndexerParameterWithMonoCecil,
            InterfaceAccessorWithMonoCecil>
    {
        private readonly PropertyDefinition indexer;
        private readonly IInterfaceTypeWithMonoCecil declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithMonoCecil indexerType;
        private readonly InterfaceAccessorWithMonoCecil getAccessor;
        private readonly InterfaceAccessorWithMonoCecil setAccessor;
        private readonly Lazy<Parameters<IndexerParameterWithMonoCecil>> parameters;

        internal InterfaceIndexerWithMonoCecil(IInterfaceTypeWithMonoCecil declaringType, PropertyDefinition indexer)
        {
            this.indexer = indexer;
            this.declaringType = declaringType;
            AssemblyWithMonoCecil assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, indexer));
            indexerType = TypeReferenceWithMonoCecilFactory.CreateReference(assembly, indexer.PropertyType, indexer);
            parameters = new Lazy<Parameters<IndexerParameterWithMonoCecil>>(
                () => new Parameters<IndexerParameterWithMonoCecil>(assembly, indexer, parameter => new IndexerParameterWithMonoCecil(parameter)));
            if (indexer.GetMethod != null)
            {
                getAccessor = new InterfaceAccessorWithMonoCecil(assembly, indexer.GetMethod);
            }

            if (indexer.SetMethod != null)
            {
                setAccessor = new InterfaceAccessorWithMonoCecil(assembly, indexer.SetMethod);
            }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override IInterfaceTypeWithMonoCecil DeclaringType
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
