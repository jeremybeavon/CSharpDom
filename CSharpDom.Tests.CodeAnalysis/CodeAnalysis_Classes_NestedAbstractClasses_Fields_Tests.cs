using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
