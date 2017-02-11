using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStructWithInternalAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPrivateAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPublicAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithStaticAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithStaticAutoProperty));
        }
    }
}
