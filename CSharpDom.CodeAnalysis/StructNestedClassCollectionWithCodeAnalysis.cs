using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructNestedClassCollectionWithCodeAnalysis :
        EditableStructNestedClassCollection<
            StructNestedClassWithCodeAnalysis,
            StructNestedAbstractClassWithCodeAnalysis,
            StructNestedSealedClassWithCodeAnalysis,
            StructNestedStaticClassWithCodeAnalysis,
            StructNestedPartialClassCollectionWithCodeAnalysis>
    {
        private readonly StructTypeWithCodeAnalysis structType;
        private readonly StructTypeMemberListWrapper<StructNestedClassWithCodeAnalysis, ClassDeclarationSyntax> classes;
        private readonly StructTypeMemberListWrapper<
            StructNestedAbstractClassWithCodeAnalysis,
            ClassDeclarationSyntax> abstractClasses;
        private readonly StructTypeMemberListWrapper<
            StructNestedSealedClassWithCodeAnalysis,
            ClassDeclarationSyntax> sealedClasses;
        private readonly StructTypeMemberListWrapper<
            StructNestedStaticClassWithCodeAnalysis,
            ClassDeclarationSyntax> staticClasses;
        private readonly StructNestedPartialClassCollectionWithCodeAnalysis partialClasses;

        internal StructNestedClassCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis structType)
        {
            this.structType = structType;
            classes = new StructTypeMemberListWrapper<StructNestedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                structType.Node,
                () => new StructNestedClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsClass);
            abstractClasses = new StructTypeMemberListWrapper<StructNestedAbstractClassWithCodeAnalysis, ClassDeclarationSyntax>(
                structType.Node,
                () => new StructNestedAbstractClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsAbstractClass);
            sealedClasses = new StructTypeMemberListWrapper<StructNestedSealedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                structType.Node,
                () => new StructNestedSealedClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsSealedClass);
            staticClasses = new StructTypeMemberListWrapper<StructNestedStaticClassWithCodeAnalysis, ClassDeclarationSyntax>(
                structType.Node,
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
