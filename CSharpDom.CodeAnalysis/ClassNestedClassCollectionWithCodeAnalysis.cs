using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassNestedClassCollectionWithCodeAnalysis :
        EditableClassNestedClassCollection<
            ClassNestedClassWithCodeAnalysis,
            ClassNestedAbstractClassWithCodeAnalysis,
            ClassNestedSealedClassWithCodeAnalysis,
            ClassNestedStaticClassWithCodeAnalysis,
            ClassNestedPartialClassCollectionWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly ClassMemberListWrapper<ClassNestedClassWithCodeAnalysis, ClassDeclarationSyntax> classes;
        private readonly ClassMemberListWrapper<ClassNestedAbstractClassWithCodeAnalysis, ClassDeclarationSyntax> abstractClasses;
        private readonly ClassMemberListWrapper<ClassNestedSealedClassWithCodeAnalysis, ClassDeclarationSyntax> sealedClasses;
        private readonly ClassMemberListWrapper<ClassNestedStaticClassWithCodeAnalysis, ClassDeclarationSyntax> staticClasses;
        private readonly ClassNestedPartialClassCollectionWithCodeAnalysis partialClasses;

        internal ClassNestedClassCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            classes = new ClassMemberListWrapper<ClassNestedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new ClassNestedClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsAbstractClass);
            abstractClasses = new ClassMemberListWrapper<ClassNestedAbstractClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new ClassNestedAbstractClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsClass);
            sealedClasses = new ClassMemberListWrapper<ClassNestedSealedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new ClassNestedSealedClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsSealedClass);
            staticClasses = new ClassMemberListWrapper<ClassNestedStaticClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
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
