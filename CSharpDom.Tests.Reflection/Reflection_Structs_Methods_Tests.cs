using CSharpDom.TestTarget.Structs.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithInternalMethodUsingReflection()
        {
            TestStruct(typeof(StructWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithPrivateMethodUsingReflection()
        {
            TestStruct(typeof(StructWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithPublicMethodUsingReflection()
        {
            TestStruct(typeof(StructWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithStaticMethodUsingReflection()
        {
            TestStruct(typeof(StructWithStaticMethod));
        }
    }
}
