using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class ClassNestedPartialClassCollectionWithCodeAnalysis :
        GenericPartialClassCollectionWithCodeAnalysis<
            ClassNestedPartialClassWithCodeAnalysis,
            ClassNestedAbstractPartialClassWithCodeAnalysis,
            ClassNestedSealedPartialClassWithCodeAnalysis,
            ClassNestedStaticPartialClassWithCodeAnalysis>
    {
        private ClassNestedPartialClassCollectionWithCodeAnalysis(
            IMemberList members,
            ICollection<ClassNestedAbstractPartialClassWithCodeAnalysis> abstractClasses,
            ICollection<ClassNestedPartialClassWithCodeAnalysis> classes,
            ICollection<ClassNestedSealedPartialClassWithCodeAnalysis> sealedClasses,
            ICollection<ClassNestedStaticPartialClassWithCodeAnalysis> staticClasses)
            : base(members, abstractClasses, classes, sealedClasses, staticClasses)
        {
        }

        internal static ClassNestedPartialClassCollectionWithCodeAnalysis Create<TClass>(
            InternalClassTypeWithCodeAnalysis<TClass> classType)
            where TClass : class, IHasSyntax<ClassDeclarationSyntax>
        {
            var classes = new ClassMemberListWrapper<TClass, ClassNestedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.InternalNode,
                () => new ClassNestedPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsPartialClass);
            var abstractClasses = new ClassMemberListWrapper<TClass, ClassNestedAbstractPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.InternalNode,
                () => new ClassNestedAbstractPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsAbstractPartialClass);
            var sealedClasses = new ClassMemberListWrapper<TClass, ClassNestedSealedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.InternalNode,
                () => new ClassNestedSealedPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsSealedPartialClass);
            var staticClasses = new ClassMemberListWrapper<TClass, ClassNestedStaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.InternalNode,
                () => new ClassNestedStaticPartialClassWithCodeAnalysis(),
                ClassDeclarationSyntaxExtensions.IsStaticPartialClass);
            return new ClassNestedPartialClassCollectionWithCodeAnalysis(classType.Members, abstractClasses, classes, sealedClasses, staticClasses);
        }
    }
}
