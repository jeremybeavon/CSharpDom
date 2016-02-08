using CSharpDom.Common;
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
    public abstract class AbstractClassTests<TProject>
        where TProject : IProject
    {
        public abstract ISolution<TProject> Solution { get; }

        protected async Task TestClassAsync(Type type)
        {
            IClass @class = await Solution.Find().ClassByNameAsync<IClass>(type.Name());
            string namespaceName = new FindNamespaceForClassVisitor(@class).Result;
            LoadedDocument document = new LoadedDocument();
            Class serializableClass = new ClassFactory(@class).Value;
            serializableClass.Constructors.Clear();
            if (string.IsNullOrWhiteSpace(namespaceName))
            {
                document.Classes.Add(serializableClass);
            }
            else
            {
                Namespace @namespace = new Namespace()
                {
                    Name = namespaceName,
                    Classes = { serializableClass }
                };
                document.Namespaces.Add(@namespace);
            }

            string documentText = document.ToSourceCode();
            string expectedResult = TypeTextProvider.GetTypeText(type);
            documentText.Should().Be(expectedResult);
        }
    }
}
