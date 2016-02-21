﻿using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Search;
using CSharpDom.Serialization;
using CSharpDom.Serialization.Factories;
using CSharpDom.Text;
using FluentAssertions;
using System;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Common
{
    public abstract class AbstractSolutionTests<TProject>
        where TProject : IProject
    {
        public abstract ISolution<TProject> Solution { get; }

        protected virtual bool IsConstructorTest
        {
            get { return false; }
        }

        protected async Task TestClassAsync(Type type)
        {
            IClass @class = await Solution.Find().ClassByNameAsync<IClass>(type.Name());
            string namespaceName = new FindNamespaceForClassVisitor(@class).Result;
            LoadedDocument document = CreateLoadedDocument(new ClassFactory(@class).Value, namespaceName);
            string documentText = document.ToSourceCode();
            string expectedResult = TypeTextProvider.GetTypeText(type);
            documentText.Should().Be(expectedResult);
        }

        protected async Task TestStructAsync(Type type)
        {
            IStruct @struct = await Solution.Find().StructByNameAsync<IStruct>(type.Name());
            string namespaceName = new FindNamespaceForStructVisitor(@struct).Result;
            LoadedDocument document = CreateLoadedDocument(new StructFactory(@struct).Value, namespaceName);
            string documentText = document.ToSourceCode();
            string expectedResult = TypeTextProvider.GetTypeText(type);
            documentText.Should().Be(expectedResult);
        }

        private LoadedDocument CreateLoadedDocument(Class @class, string namespaceName)
        {
            if (!IsConstructorTest)
            {
                @class.Constructors.Clear();
            }

            @class.Accept(new FixMethodBodyVisitor());
            LoadedDocument document = new LoadedDocument();
            if (string.IsNullOrWhiteSpace(namespaceName))
            {
                document.Classes.Classes.Add(@class);
            }
            else
            {
                Namespace @namespace = new Namespace()
                {
                    Name = namespaceName,
                    Classes = { Classes = { @class } }
                };
                document.Namespaces.Add(@namespace);
            }

            return document;
        }

        private LoadedDocument CreateLoadedDocument(Struct @struct, string namespaceName)
        {
            if (!IsConstructorTest)
            {
                @struct.Constructors.Clear();
            }

            @struct.Accept(new FixMethodBodyVisitor());
            LoadedDocument document = new LoadedDocument();
            if (string.IsNullOrWhiteSpace(namespaceName))
            {
                document.Structs.Structs.Add(@struct);
            }
            else
            {
                Namespace @namespace = new Namespace()
                {
                    Name = namespaceName,
                    Structs = { Structs = { @struct } }
                };
                document.Namespaces.Add(@namespace);
            }

            return document;
        }
    }
}