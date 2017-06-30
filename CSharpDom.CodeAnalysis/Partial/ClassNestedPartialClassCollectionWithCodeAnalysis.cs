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

        internal static ClassNestedPartialClassCollectionWithCodeAnalysis Create(ClassTypeWithCodeAnalysis classType)
        {
            var classes = new ClassMemberListWrapper<ClassNestedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new ClassNestedPartialClassWithCodeAnalysis());
            var abstractClasses = new ClassMemberListWrapper<ClassNestedAbstractPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new ClassNestedAbstractPartialClassWithCodeAnalysis());
            var sealedClasses = new ClassMemberListWrapper<ClassNestedSealedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new ClassNestedSealedPartialClassWithCodeAnalysis());
            var staticClasses = new ClassMemberListWrapper<ClassNestedStaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                classType.Node,
                () => new ClassNestedStaticPartialClassWithCodeAnalysis());
            return new ClassNestedPartialClassCollectionWithCodeAnalysis(classType.Members, abstractClasses, classes, sealedClasses, staticClasses);
        }
    }
}
