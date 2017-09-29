using CSharpDom.TestTarget.Classes.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithConstFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithVolatileFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithVolatileField));
        }
    }
}
