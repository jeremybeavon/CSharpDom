using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedStructs_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithInternalFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPrivateFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPublicFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithStaticFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithVolatileFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithVolatileField));
        }
    }
}
