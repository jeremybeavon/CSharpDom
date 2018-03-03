using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStructPropertyCollectionWithCodeAnalysis<TStruct> :
        StructPropertyCollectionWithCodeAnalysis
        where TStruct : class, IHasNode<StructDeclarationSyntax>
    {
        private readonly InternalStructTypeWithCodeAnalysis<TStruct> structType;
        private readonly StructPropertyListWrapper<TStruct, StructAutoPropertyWithCodeAnalysis> autoProperties;
        private readonly StructPropertyListWrapper<TStruct, ExplicitInterfacePropertyWithCodeAnalysis> explicitInterfaceProperties;
        private readonly StructPropertyListWrapper<TStruct, StructLambdaPropertyWithCodeAnalysis> lambdaProperties;
        private readonly StructPropertyListWrapper<TStruct, StructPropertyWithCodeAnalysis> properties;

        internal InternalStructPropertyCollectionWithCodeAnalysis(InternalStructTypeWithCodeAnalysis<TStruct> structType)
        {
            this.structType = structType;
            explicitInterfaceProperties = new StructPropertyListWrapper<TStruct, ExplicitInterfacePropertyWithCodeAnalysis>(
                structType.InternalNode,
                () => new ExplicitInterfacePropertyWithCodeAnalysis(),
                syntax => syntax.IsExplicitInterfaceProperty());
            autoProperties = new StructPropertyListWrapper<TStruct, StructAutoPropertyWithCodeAnalysis>(
                structType.InternalNode,
                () => new StructAutoPropertyWithCodeAnalysis(),
                syntax => syntax.IsAutoProperty());
            lambdaProperties = new StructPropertyListWrapper<TStruct, StructLambdaPropertyWithCodeAnalysis>(
                structType.InternalNode,
                () => new StructLambdaPropertyWithCodeAnalysis(),
                syntax => syntax.IsLambdaProperty());
            properties = new StructPropertyListWrapper<TStruct, StructPropertyWithCodeAnalysis>(
                structType.InternalNode,
                () => new StructPropertyWithCodeAnalysis(),
                syntax => syntax.IsProperty());
        }

        public override ICollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfaceProperties
        {
            get { return explicitInterfaceProperties; }
            set { structType.Members.CombineList(nameof(ExplicitInterfaceProperties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StructPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { structType.Members.CombineList(nameof(Properties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StructAutoPropertyWithCodeAnalysis> AutoProperties
        {
            get { return autoProperties; }
            set { structType.Members.CombineList(nameof(AutoProperties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StructLambdaPropertyWithCodeAnalysis> LambdaProperties
        {
            get { return lambdaProperties; }
            set { structType.Members.CombineList(nameof(LambdaProperties), value.Select(item => item.Syntax)); }
        }
    }
}
