using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Search;
using CSharpDom.Serialization;
using CSharpDom.Serialization.Factories;
using CSharpDom.Text;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Common
{
    public abstract class AbstractSolutionTests<TProject>
        where TProject : IProject
    {
        public abstract ISolution<TProject> Solution { get; }

        protected bool IsConstructorTest { get; set; }

        protected bool IsNestedConstructorTest { get; set; }

        protected async Task TestClassAsync(Type type)
        {
            IClass @class = await Solution.Find().ClassByNameAsync<IClass>(type.Name());
            string namespaceName = new FindNamespaceForClassVisitor(@class).Result;
            LoadedDocument document = CreateLoadedDocument(new ClassFactory(@class).Value, namespaceName);
            string documentText = document.ToSourceCode();
            string expectedResult = TypeTextProvider.GetTypeText(type);
            documentText.TrimEnd().Should().Be(expectedResult.TrimEnd());
        }

        protected async Task TestAbstractClassAsync(Type type)
        {
            IAbstractClass @class = await Solution.Find().AbstractClassByNameAsync<IAbstractClass>(type.Name());
            string namespaceName = new FindNamespaceForClassVisitor(@class).Result;
            LoadedDocument document = CreateLoadedDocument(new AbstractClassFactory(@class).Value, namespaceName);
            string documentText = document.ToSourceCode();
            string expectedResult = TypeTextProvider.GetTypeText(type);
            documentText.TrimEnd().Should().Be(expectedResult.TrimEnd());
        }

        protected async Task TestSealedClassAsync(Type type)
        {
            ISealedClass @class = await Solution.Find().SealedClassByNameAsync<ISealedClass>(type.Name());
            string namespaceName = new FindNamespaceForClassVisitor(@class).Result;
            LoadedDocument document = CreateLoadedDocument(new SealedClassFactory(@class).Value, namespaceName);
            string documentText = document.ToSourceCode();
            string expectedResult = TypeTextProvider.GetTypeText(type);
            documentText.TrimEnd().Should().Be(expectedResult.TrimEnd());
        }

        protected async Task TestStaticClassAsync(Type type)
        {
            IStaticClass @class = await Solution.Find().StaticClassByNameAsync<IStaticClass>(type.Name());
            string namespaceName = new FindNamespaceForClassVisitor(@class).Result;
            LoadedDocument document = CreateLoadedDocument(new StaticClassFactory(@class).Value, namespaceName);
            string documentText = document.ToSourceCode();
            string expectedResult = TypeTextProvider.GetTypeText(type);
            documentText.TrimEnd().Should().Be(expectedResult.TrimEnd());
        }

        protected async Task TestStructAsync(Type type)
        {
            IStruct @struct = await Solution.Find().StructByNameAsync<IStruct>(type.Name());
            string namespaceName = new FindNamespaceForStructVisitor(@struct).Result;
            LoadedDocument document = CreateLoadedDocument(new StructFactory(@struct).Value, namespaceName);
            string documentText = document.ToSourceCode();
            string expectedResult = TypeTextProvider.GetTypeText(type);
            documentText.TrimEnd().Should().Be(expectedResult.TrimEnd());
        }

        private LoadedDocument CreateLoadedDocument(Class @class, string namespaceName)
        {
            if (!IsConstructorTest)
            {
                @class.Constructors.Clear();
                if (!IsNestedConstructorTest)
                {
                    foreach (List<ClassConstructor> constructors in
                        @class.Classes.AbstractClasses.Select(nestedClass => nestedClass.Constructors)
                        .Concat(@class.Classes.Classes.Select(nestedClass => nestedClass.Constructors))
                        .Concat(@class.Classes.SealedClasses.Select(nestedClass => nestedClass.Constructors)))
                    {
                        constructors.Clear();
                    }
                }
            }
            
            return CreateLoadedDocument(@class, namespaceName, classes => classes.Classes.Add(@class));
        }

        private LoadedDocument CreateLoadedDocument(AbstractClass @class, string namespaceName)
        {
            if (!IsConstructorTest)
            {
                @class.Constructors.Clear();
                if (!IsNestedConstructorTest)
                {
                    foreach (List<ClassConstructor> constructors in
                        @class.Classes.AbstractClasses.Select(nestedClass => nestedClass.Constructors)
                        .Concat(@class.Classes.Classes.Select(nestedClass => nestedClass.Constructors))
                        .Concat(@class.Classes.SealedClasses.Select(nestedClass => nestedClass.Constructors)))
                    {
                        constructors.Clear();
                    }
                }
            }

            return CreateLoadedDocument(@class, namespaceName, classes => classes.AbstractClasses.Add(@class));
        }

        private LoadedDocument CreateLoadedDocument(SealedClass @class, string namespaceName)
        {
            if (!IsConstructorTest)
            {
                @class.Constructors.Clear();
                if (!IsNestedConstructorTest)
                {
                    foreach (List<ClassConstructor> constructors in
                        @class.Classes.AbstractClasses.Select(nestedClass => nestedClass.Constructors)
                        .Concat(@class.Classes.Classes.Select(nestedClass => nestedClass.Constructors))
                        .Concat(@class.Classes.SealedClasses.Select(nestedClass => nestedClass.Constructors)))
                    {
                        constructors.Clear();
                    }
                }
            }

            return CreateLoadedDocument(@class, namespaceName, classes => classes.SealedClasses.Add(@class));
        }

        private LoadedDocument CreateLoadedDocument(StaticClass @class, string namespaceName)
        {
            if (!IsNestedConstructorTest)
            {
                foreach (List<ClassConstructor> constructors in
                    @class.Classes.AbstractClasses.Select(nestedClass => nestedClass.Constructors)
                    .Concat(@class.Classes.Classes.Select(nestedClass => nestedClass.Constructors))
                    .Concat(@class.Classes.SealedClasses.Select(nestedClass => nestedClass.Constructors)))
                {
                    constructors.Clear();
                }
            }

            return CreateLoadedDocument(@class, namespaceName, classes => classes.StaticClasses.Add(@class));
        }

        private LoadedDocument CreateLoadedDocument(
            IVisitable<IGenericVisitor> type,
            string namespaceName,
            Action<ClassCollection> addAction)
        {
            return CreateLoadedDocument(type, namespaceName, document => addAction(document.Classes), @namespace => addAction(@namespace.Classes));
        }

        private LoadedDocument CreateLoadedDocument(
            IVisitable<IGenericVisitor> type,
            string namespaceName,
            Action<LoadedDocument> addToDocumentAction,
            Action<Namespace> addToNamespaceAction)
        {
            type.Accept(new FixMethodBodyVisitor());
            LoadedDocument document = new LoadedDocument();
            if (string.IsNullOrWhiteSpace(namespaceName))
            {
                addToDocumentAction(document);
            }
            else
            {
                Namespace @namespace = new Namespace()
                {
                    Name = namespaceName,
                };
                addToNamespaceAction(@namespace);
                document.Namespaces.Add(@namespace);
            }

            return document;
        }

        private LoadedDocument CreateLoadedDocument(Struct @struct, string namespaceName)
        {
            if (!IsConstructorTest)
            {
                @struct.Constructors.Clear();
                if (!IsNestedConstructorTest)
                {
                    foreach (List<ClassConstructor> constructors in
                        @struct.Classes.AbstractClasses.Select(nestedClass => nestedClass.Constructors)
                        .Concat(@struct.Classes.Classes.Select(nestedClass => nestedClass.Constructors))
                        .Concat(@struct.Classes.SealedClasses.Select(nestedClass => nestedClass.Constructors)))
                    {
                        constructors.Clear();
                    }
                }
            }

            return CreateLoadedDocument(
                @struct,
                namespaceName,
                document => document.Structs.Structs.Add(@struct),
                @namespace => @namespace.Structs.Structs.Add(@struct));
        }
    }
}
