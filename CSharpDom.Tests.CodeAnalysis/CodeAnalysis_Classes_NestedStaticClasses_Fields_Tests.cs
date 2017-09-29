using CSharpDom.TestTarget.Classes.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStaticClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedStaticClassWithConstFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithVolatileField));
        }
    }
}
