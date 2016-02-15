using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class InterfaceIndexerWithReflection :
        AbstractInterfaceIndexer<
            AttributeWithReflection,
            IBasicTypeWithReflection,
            ITypeReferenceWithReflection,
            IndexerParameterWithReflection,
            InterfaceAccessorWithReflection>
    {
        private readonly PropertyInfo indexer;
        private readonly IBasicTypeWithReflection declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithReflection indexerType;
        private readonly InterfaceAccessorWithReflection getAccessor;
        private readonly InterfaceAccessorWithReflection setAccessor;
        private readonly Lazy<Parameters<IndexerParameterWithReflection>> parameters;

        internal InterfaceIndexerWithReflection(IBasicTypeWithReflection declaringType, PropertyInfo indexer)
        {
            this.indexer = indexer;
            this.declaringType = declaringType;
            attributes = new Lazy<Attributes>(() => new Attributes(indexer));
            indexerType = TypeReferenceWithReflectionFactory.CreateReference(indexer.PropertyType);
            parameters = new Lazy<Parameters<IndexerParameterWithReflection>>(
                () => new Parameters<IndexerParameterWithReflection>(indexer, parameter => new IndexerParameterWithReflection(parameter)));
            if (indexer.GetMethod != null)
            {
                getAccessor = new InterfaceAccessorWithReflection(indexer.GetMethod);
            }

            if (indexer.SetMethod != null)
            {
                setAccessor = new InterfaceAccessorWithReflection(indexer.SetMethod);
            }
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override IBasicTypeWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public override InterfaceAccessorWithReflection GetAccessor
        {
            get { return getAccessor; }
        }
        
        public override ITypeReferenceWithReflection IndexerType
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

        public override IReadOnlyList<IndexerParameterWithReflection> Parameters
        {
            get { return parameters.Value.ParametersWithReflection; }
        }

        public override InterfaceAccessorWithReflection SetAccessor
        {
            get { return setAccessor; }
        }
    }
}
