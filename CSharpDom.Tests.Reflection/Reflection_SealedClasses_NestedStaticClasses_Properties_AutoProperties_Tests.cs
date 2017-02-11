using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStaticClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithInternalAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPrivateAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPublicAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}
