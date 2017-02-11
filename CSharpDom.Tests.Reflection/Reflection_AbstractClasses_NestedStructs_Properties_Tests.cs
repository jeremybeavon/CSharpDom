using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStructs_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStructWithInternalPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPrivatePropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPublicPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithStaticPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithStaticProperty));
        }
    }
}
