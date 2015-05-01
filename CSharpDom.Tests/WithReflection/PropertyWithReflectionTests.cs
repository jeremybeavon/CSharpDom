using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithReflection;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.WithReflection
{
    [TestClass]
    public sealed class PropertyWithReflectionTests
    {
        private static readonly string solutionFile =
            Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\CSharpDom.sln"));

        [TestMethod]
        public async Task Test_Property_IsCorrect()
        {
            SolutionWithReflection solution = await SolutionWithReflection.OpenSolutionAsync(solutionFile);
            ProjectWithReflection project = solution.Projects.Single(proj => proj.Project.Name == "CSharpDom");
            ClassWithReflection methodNodeClass = await project.Classes.GetSingle(
                document => Path.GetFileName(document.FullFilePath) == "PropertyWithReflection.cs",
                @class => true);
            PropertyWithReflection property = methodNodeClass.Properties.Single(prop => prop.Name == "Name");
            PropertyInfo expectedProperty = GetProperty((PropertyWithReflection prop) => prop.Name);
            property.PropertyInfo.Should().BeSameAs(expectedProperty);

        }

        private static PropertyInfo GetProperty<TClass, TPropertyValue>(Expression<Func<TClass, TPropertyValue>> expression)
        {
            return (PropertyInfo)((MemberExpression)expression.Body).Member;
        }
    }
}
