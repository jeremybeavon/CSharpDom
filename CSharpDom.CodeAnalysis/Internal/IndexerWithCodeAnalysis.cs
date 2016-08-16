using CSharpDom.BaseClasses;
using System;
using System.Reflection;
using System.Collections.Generic;
using CSharpDom.CodeAnalysis.Internal;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class IndexerWithCodeAnalysis :
        AbstractIndexer<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IndexerParameterWithCodeAnalysis,
            AccessorWithCodeAnalysis>,
        IHasPropertyDefinition
    {
        private readonly ITypeWithCodeAnalysis declaringType;
        private readonly PropertyDefinition indexer;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithCodeAnalysis indexerType;
        private readonly Lazy<Parameters<IndexerParameterWithCodeAnalysis>> parameters;
        private readonly AccessorWithCodeAnalysis getAccessor;
        private readonly AccessorWithCodeAnalysis setAccessor;

        internal IndexerWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, PropertyDefinition indexer)
        {
            this.declaringType = declaringType;
            this.indexer = indexer;
            attributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, indexer));
            indexerType = TypeReferenceWithCodeAnalysisFactory.CreateReference(declaringType.Assembly, indexer.PropertyType, indexer);
            parameters = new Lazy<Parameters<IndexerParameterWithCodeAnalysis>>(
                () => new Parameters<IndexerParameterWithCodeAnalysis>(declaringType.Assembly, indexer, parameter => new IndexerParameterWithCodeAnalysis(parameter)));
            if (indexer.GetMethod != null)
            {
                getAccessor = new AccessorWithCodeAnalysis(declaringType.Assembly, indexer.GetMethod);
            }

            if (indexer.SetMethod != null)
            {
                setAccessor = new AccessorWithCodeAnalysis(declaringType.Assembly, indexer.SetMethod);
            }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return declaringType; }
        }

        public override AccessorWithCodeAnalysis GetAccessor
        {
            get { return getAccessor; }
        }
        
        public override ITypeReferenceWithCodeAnalysis IndexerType
        {
            get { return indexerType; }
        }
        
        public override IReadOnlyList<IndexerParameterWithCodeAnalysis> Parameters
        {
            get { return parameters.Value.ParametersWithCodeAnalysis; }
        }

        public PropertyDefinition PropertyDefinition
        {
            get { return indexer; }
        }

        public override AccessorWithCodeAnalysis SetAccessor
        {
            get { return setAccessor; }
        }
    }
}
