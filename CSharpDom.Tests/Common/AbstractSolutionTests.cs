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
    public abstract class AbstractSolutionTests
    {
        public abstract TypeCache TypeCache { get; }

        protected bool IsConstructorTest { get; set; }

        protected bool IsNestedConstructorTest { get; set; }

        protected void TestClass(Type type)
        {
            IClass @class = TypeCache.Classes[type.Name()];
            string namespaceName = new FindNamespaceForClassVisitor(@class).Result;
            LoadedDocument document = CreateLoadedDocument(new ClassFactory(@class).Value, namespaceName);
            string documentText = document.ToSourceCode();
            Verify(type, documentText);
        }

        protected void TestAbstractClass(Type type)
        {
            IAbstractClass @class = TypeCache.AbstractClasses[type.Name()];
            string namespaceName = new FindNamespaceForClassVisitor(@class).Result;
            LoadedDocument document = CreateLoadedDocument(new AbstractClassFactory(@class).Value, namespaceName);
            string documentText = document.ToSourceCode();
            Verify(type, documentText);
        }

        protected void TestSealedClass(Type type)
        {
            ISealedClass @class = TypeCache.SealedClasses[type.Name()];
            string namespaceName = new FindNamespaceForClassVisitor(@class).Result;
            LoadedDocument document = CreateLoadedDocument(new SealedClassFactory(@class).Value, namespaceName);
            string documentText = document.ToSourceCode();
            Verify(type, documentText);
        }

        protected void TestStaticClass(Type type)
        {
            IStaticClass @class = TypeCache.StaticClasses[type.Name()];
            string namespaceName = new FindNamespaceForClassVisitor(@class).Result;
            LoadedDocument document = CreateLoadedDocument(new StaticClassFactory(@class).Value, namespaceName);
            string documentText = document.ToSourceCode();
            Verify(type, documentText);
        }

        protected void TestStruct(Type type)
        {
            IStruct @struct = TypeCache.Structs[type.Name()];
            string namespaceName = new FindNamespaceForStructVisitor(@struct).Result;
            LoadedDocument document = CreateLoadedDocument(new StructFactory(@struct).Value, namespaceName);
            string documentText = document.ToSourceCode();
            Verify(type, documentText);
        }

        private static void Verify(Type type, string documentText)
        {
            string expectedResult = TypeTextProvider.GetTypeText(type);
            ToString(documentText).Should().Be(ToString(expectedResult));
        }

        private static string ToString(string text)
        {
            return text.Trim().Replace("\r", string.Empty);
        }

        private static void RemoveNestedConstructors(
            List<ClassConstructor> constructors,
            ClassNestedClassCollection nestedClasses,
            ClassNestedStructCollection nestedStructs)
        {
            constructors.Clear();
            foreach (ClassNestedAbstractClass @class in nestedClasses.AbstractClasses)
            {
                RemoveNestedConstructors(@class.Constructors, @class.Classes, @class.Structs);
            }

            foreach (ClassNestedClass @class in nestedClasses.Classes)
            {
                RemoveNestedConstructors(@class.Constructors, @class.Classes, @class.Structs);
            }

            foreach (ClassNestedSealedClass @class in nestedClasses.SealedClasses)
            {
                RemoveNestedConstructors(@class.Constructors, @class.Classes, @class.Structs);
            }

            foreach (ClassNestedStaticClass @class in nestedClasses.StaticClasses)
            {
                RemoveNestedConstructors(@class.Classes);
            }

            foreach (ClassNestedStruct @struct in nestedStructs.Structs)
            {
                RemoveNestedConstructors(@struct.Constructors, @struct.Classes, @struct.Structs);
            }
        }

        private static void RemoveNestedConstructors(StaticClassNestedClassCollection nestedClasses)
        {
            foreach (StaticClassNestedAbstractClass nestedClass in nestedClasses.AbstractClasses)
            {
                RemoveNestedConstructors(nestedClass.Constructors, nestedClass.Classes, nestedClass.Structs);
            }

            foreach (StaticClassNestedClass nestedClass in nestedClasses.Classes)
            {
                RemoveNestedConstructors(nestedClass.Constructors, nestedClass.Classes, nestedClass.Structs);
            }

            foreach (StaticClassNestedSealedClass nestedClass in nestedClasses.SealedClasses)
            {
                RemoveNestedConstructors(nestedClass.Constructors, nestedClass.Classes, nestedClass.Structs);
            }

            foreach (StaticClassNestedStaticClass nestedClass in nestedClasses.StaticClasses)
            {
                RemoveNestedConstructors(nestedClass.Classes);
            }
        }

        private static void RemoveNestedConstructors(
            List<StructConstructor> constructors,
            StructNestedClassCollection nestedClasses,
            StructNestedStructCollection nestedStructs)
        {
            foreach (StructNestedAbstractClass nestedClass in nestedClasses.AbstractClasses)
            {
                RemoveNestedConstructors(nestedClass.Constructors, nestedClass.Classes, nestedClass.Structs);
            }

            foreach (StructNestedClass nestedClass in nestedClasses.Classes)
            {
                RemoveNestedConstructors(nestedClass.Constructors, nestedClass.Classes, nestedClass.Structs);
            }

            foreach (StructNestedSealedClass nestedClass in nestedClasses.SealedClasses)
            {
                RemoveNestedConstructors(nestedClass.Constructors, nestedClass.Classes, nestedClass.Structs);
            }

            foreach (StructNestedStaticClass nestedClass in nestedClasses.StaticClasses)
            {
                RemoveNestedConstructors(nestedClass.Classes);
            }

            foreach (StructNestedStruct nestedStruct in nestedStructs.Structs)
            {
                RemoveNestedConstructors(nestedStruct.Constructors, nestedStruct.Classes, nestedStruct.Structs);
            }
        }

        private LoadedDocument CreateLoadedDocument(Class @class, string namespaceName)
        {
            if (!IsConstructorTest)
            {
                @class.Constructors.Clear();
                if (!IsNestedConstructorTest)
                {
                    RemoveNestedConstructors(@class.Constructors, @class.Classes, @class.Structs);
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
                    RemoveNestedConstructors(@class.Constructors, @class.Classes, @class.Structs);
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
                    RemoveNestedConstructors(@class.Constructors, @class.Classes, @class.Structs);
                }
            }

            return CreateLoadedDocument(@class, namespaceName, classes => classes.SealedClasses.Add(@class));
        }

        private LoadedDocument CreateLoadedDocument(StaticClass @class, string namespaceName)
        {
            if (!IsNestedConstructorTest)
            {
                RemoveNestedConstructors(@class.Classes);
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
                    RemoveNestedConstructors(@struct.Constructors, @struct.Classes, @struct.Structs);
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
