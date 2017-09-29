using CSharpDom.TestTarget.Classes.NestedStaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStaticClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicProperty));
        }
    }
}
