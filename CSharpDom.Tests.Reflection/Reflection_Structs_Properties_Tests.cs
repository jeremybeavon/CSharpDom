using CSharpDom.TestTarget.Structs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithInternalPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithPrivatePropertyUsingReflection()
        {
            TestStruct(typeof(StructWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithPublicPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithStaticPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithStaticProperty));
        }
    }
}
