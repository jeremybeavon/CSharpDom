using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStaticClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithConstFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithInternalFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPrivateFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPublicFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithReadOnlyFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithVolatileFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithVolatileField));
        }
    }
}
