using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Serialization;
using CSharpDom.Serialization.Factories;
using CSharpDom.Text;
using CSharpDom.TestTarget.Classes;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Common
{
    public abstract class AbstractClassTests
    {
        public abstract ISolution Solution { get; }

        protected Task TestPublicClassAsync()
        {
            return TestClassAsync(typeof(PublicClass));
        }

        /*protected Task TestInternalClassAsync()
        {
            return TestClassAsync(typeof(InternalClass))
        }*/

        private async Task TestClassAsync(Type type)
        {
            Solution solution = await new SolutionFactory(Solution).ValueAsync();
            LoadSolution(solution, type);
            string solutionText = await solution.ToSourceCodeAsync();
            string expectedResult = TypeTextProvider.GetTypeText(type);
            solutionText.Should().Be(expectedResult);
        }

        private void LoadSolution(Solution solution, Type type)
        {
            bool isClassFound = false;
            string typeName = type.Name();
            foreach (Project project in solution.Projects.ToArray())
            {
                if (isClassFound)
                {
                    solution.Projects.Remove(project);
                    continue;
                }

                isClassFound = LoadProject(project, isClassFound, type.Namespace, typeName);
            }
        }

        private bool LoadProject(Project project, bool isClassFound, string namespaceToFind, string classToFind)
        {
            foreach (Document document in project.Documents.ToArray())
            {
                if (isClassFound)
                {
                    project.Documents.Remove(document);
                    continue;
                }

                isClassFound = LoadDocument(document.LoadedDocument, isClassFound, namespaceToFind, classToFind);
            }

            return isClassFound;
        }

        private bool LoadDocument(LoadedDocument document, bool isTypeFound, string namespaceToFind, string typeToFind)
        {
            document.Delegates.Clear();
            document.Enums.Clear();
            document.Interfaces.Clear();
            document.Structs.Clear();
            if (isTypeFound)
            {
                document.Namespaces.Clear();
                document.Classes.Clear();
                return true;
            }

            if (string.IsNullOrWhiteSpace(namespaceToFind))
            {
                document.Namespaces.Clear();
                isTypeFound = LoadClasses(document.Classes, isTypeFound, typeToFind);
            }
            else
            {
                document.Classes.Clear();
                isTypeFound = LoadNamespaces(document.Namespaces, isTypeFound, namespaceToFind, typeToFind);
            }

            return isTypeFound;
        }

        private bool LoadNamespaces(List<Namespace> namespaces, bool isTypeFound, string namespaceToFind, string typeToFind)
        {
            foreach (Namespace @namespace in namespaces.ToArray())
            {
                @namespace.Delegates.Clear();
                @namespace.Enums.Clear();
                @namespace.Interfaces.Clear();
                @namespace.Structs.Clear();
                if (isTypeFound || @namespace.Name != namespaceToFind)
                {
                    namespaces.Remove(@namespace);
                    continue;
                }

                isTypeFound = LoadClasses(@namespace.Classes, isTypeFound, typeToFind);
                if (!isTypeFound)
                {
                    namespaces.Remove(@namespace);
                }
            }

            return isTypeFound;
        }

        private bool LoadClasses(List<Class> classes, bool isTypeFound, string typeToFind)
        {
            foreach (Class @class in classes.ToArray())
            {
                if (isTypeFound)
                {
                    classes.Remove(@class);
                    continue;
                }

                isTypeFound = @class.Name == typeToFind;
                @class.Constructors.Clear();
                if (!isTypeFound)
                {
                    classes.Remove(@class);
                }
            }

            return isTypeFound;
        }
    }
}
