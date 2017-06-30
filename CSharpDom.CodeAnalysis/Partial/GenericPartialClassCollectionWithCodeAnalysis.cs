using CSharpDom.Common;
using CSharpDom.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Partial
{
    public abstract class GenericPartialClassCollectionWithCodeAnalysis<TClass, TAbstractClass, TSealedClass, TStaticClass> :
        EditablePartialClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass>
        where TClass : IPartialClassTypeWithCodeAnalysis
        where TAbstractClass : IAbstractPartialTypeWithCodeAnalysis
        where TSealedClass : ISealedPartialTypeWithCodeAnalysis
        where TStaticClass : IStaticType, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly IMemberList members;
        private readonly ICollection<TAbstractClass> abstractClasses;
        private readonly ICollection<TClass> classes;
        private readonly ICollection<TSealedClass> sealedClasses;
        private readonly ICollection<TStaticClass> staticClasses;

        internal GenericPartialClassCollectionWithCodeAnalysis(
            IMemberList members,
            ICollection<TAbstractClass> abstractClasses,
            ICollection<TClass> classes,
            ICollection<TSealedClass> sealedClasses,
            ICollection<TStaticClass> staticClasses)
        {
            this.members = members;
            this.abstractClasses = abstractClasses;
            this.classes = classes;
            this.sealedClasses = sealedClasses;
            this.staticClasses = staticClasses;
        }

        public override ICollection<TAbstractClass> AbstractClasses
        {
            get => abstractClasses;
            set => members.CombineList("AbstractPartialClasses", value.Select(item => item.Syntax));
        }

        public override ICollection<TClass> Classes
        {
            get => classes;
            set => members.CombineList("PartialClasses", value.Select(item => item.Syntax));
        }

        public override ICollection<TSealedClass> SealedClasses
        {
            get => sealedClasses;
            set => members.CombineList("SealedPartialClasses", value.Select(item => item.Syntax));
        }

        public override ICollection<TStaticClass> StaticClasses
        {
            get => staticClasses;
            set => members.CombineList("StaticPartialClasses", value.Select(item => item.Syntax));
        }

        public void Replace(
            GenericPartialClassCollectionWithCodeAnalysis<TClass, TAbstractClass, TSealedClass, TStaticClass> value)
        {
            members.CombineList(
                new MemberListSyntax("AbstractPartialClasses", value.AbstractClasses.Select(item => item.Syntax)),
                new MemberListSyntax("PartialClasses", value.Classes.Select(item => item.Syntax)),
                new MemberListSyntax("SealedPartialClasses", value.SealedClasses.Select(item => item.Syntax)),
                new MemberListSyntax("StaticPartialClasses", value.StaticClasses.Select(item => item.Syntax)));
        }
    }
}
