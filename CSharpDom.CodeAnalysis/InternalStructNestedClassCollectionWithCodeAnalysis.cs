using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStructNestedClassCollectionWithCodeAnalysis<TStruct> :
        StructNestedClassCollectionWithCodeAnalysis
        where TStruct : class, IHasSyntax<StructDeclarationSyntax>
    {
        private readonly InternalStructTypeWithCodeAnalysis<TStruct> structType;
        private readonly StructTypeMemberListWrapper<
            TStruct,
            StructNestedClassWithCodeAnalysis,
            ClassDeclarationSyntax> classes;
        private readonly StructTypeMemberListWrapper<
            TStruct,
            StructNestedAbstractClassWithCodeAnalysis,
            ClassDeclarationSyntax> abstractClasses;
        private readonly StructTypeMemberListWrapper<
            TStruct,
            StructNestedSealedClassWithCodeAnalysis,
            ClassDeclarationSyntax> sealedClasses;
        private readonly StructTypeMemberListWrapper<
            TStruct,
            StructNestedStaticClassWithCodeAnalysis,
            ClassDeclarationSyntax> staticClasses;
        private readonly StructNestedPartialClassCollectionWithCodeAnalysis partialClasses;

        internal InternalStructNestedClassCollectionWithCodeAnalysis(InternalStructTypeWithCodeAnalysis<TStruct> structType)
        {
            this.structType = structType;
            classes = new StructTypeMemberListWrapper<TStruct, StructNestedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                structType.InternalNode,
                () => new StructNestedClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsClass);
            abstractClasses = new StructTypeMemberListWrapper<TStruct, StructNestedAbstractClassWithCodeAnalysis, ClassDeclarationSyntax>(
                structType.InternalNode,
                () => new StructNestedAbstractClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsAbstractClass);
            sealedClasses = new StructTypeMemberListWrapper<TStruct, StructNestedSealedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                structType.InternalNode,
                () => new StructNestedSealedClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsSealedClass);
            staticClasses = new StructTypeMemberListWrapper<TStruct, StructNestedStaticClassWithCodeAnalysis, ClassDeclarationSyntax>(
                structType.InternalNode,
                () => new StructNestedStaticClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsStaticClass);
            partialClasses = StructNestedPartialClassCollectionWithCodeAnalysis.Create(structType);
        }

        public override ICollection<StructNestedAbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return abstractClasses; }
            set { structType.Members.CombineList(nameof(AbstractClasses), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StructNestedClassWithCodeAnalysis> Classes
        {
            get { return classes; }
            set { structType.Members.CombineList(nameof(Classes), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StructNestedSealedClassWithCodeAnalysis> SealedClasses
        {
            get { return sealedClasses; }
            set { structType.Members.CombineList(nameof(SealedClasses), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StructNestedStaticClassWithCodeAnalysis> StaticClasses
        {
            get { return staticClasses; }
            set { structType.Members.CombineList(nameof(StaticClasses), value.Select(item => item.Syntax)); }
        }

        public override StructNestedPartialClassCollectionWithCodeAnalysis PartialClasses
        {
            get { return partialClasses; }
            set { partialClasses.Replace(value); }
        }
    }
}
