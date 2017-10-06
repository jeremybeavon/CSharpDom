using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using CSharpDom.CodeAnalysis.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalClassNestedClassCollectionWithCodeAnalysis<TClass> :
        ClassNestedClassCollectionWithCodeAnalysis
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly ClassMemberListWrapper<
            TClass,
            ClassNestedClassWithCodeAnalysis,
            ClassDeclarationSyntax> classes;
        private readonly ClassMemberListWrapper<
            TClass,
            ClassNestedAbstractClassWithCodeAnalysis,
            ClassDeclarationSyntax> abstractClasses;
        private readonly ClassMemberListWrapper<
            TClass,
            ClassNestedSealedClassWithCodeAnalysis,
            ClassDeclarationSyntax> sealedClasses;
        private readonly ClassMemberListWrapper<
            TClass,
            ClassNestedStaticClassWithCodeAnalysis,
            ClassDeclarationSyntax> staticClasses;
        private readonly ClassNestedPartialClassCollectionWithCodeAnalysis partialClasses;

        internal InternalClassNestedClassCollectionWithCodeAnalysis(InternalClassTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            classes = new ClassMemberListWrapper<TClass, ClassNestedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.InternalNode,
                () => new ClassNestedClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsClass);
            abstractClasses = new ClassMemberListWrapper<TClass, ClassNestedAbstractClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.InternalNode,
                () => new ClassNestedAbstractClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsAbstractClass);
            sealedClasses = new ClassMemberListWrapper<TClass, ClassNestedSealedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.InternalNode,
                () => new ClassNestedSealedClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsSealedClass);
            staticClasses = new ClassMemberListWrapper<TClass, ClassNestedStaticClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.InternalNode,
                () => new ClassNestedStaticClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsStaticClass);
            partialClasses = ClassNestedPartialClassCollectionWithCodeAnalysis.Create(classType);
        }

        public override ICollection<ClassNestedAbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return abstractClasses; }
            set { classType.Members.CombineList(nameof(AbstractClasses), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ClassNestedClassWithCodeAnalysis> Classes
        {
            get { return classes; }
            set { classType.Members.CombineList(nameof(Classes), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ClassNestedSealedClassWithCodeAnalysis> SealedClasses
        {
            get { return sealedClasses; }
            set { classType.Members.CombineList(nameof(SealedClasses), value.Select(item => item.Syntax)); }
        }
        
        public override ClassNestedPartialClassCollectionWithCodeAnalysis PartialClasses
        {
            get { return partialClasses; }
            set { partialClasses.Replace(value); }
        }

        public override ICollection<ClassNestedStaticClassWithCodeAnalysis> StaticClasses
        {
            get { return staticClasses; }
            set { classType.Members.CombineList(nameof(StaticClasses), value.Select(item => item.Syntax)); }
        }
    }
}
