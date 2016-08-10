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
            TestStructAsync(typeof(StructWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithPrivateMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithPublicMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithStaticMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithStaticMethod));
        }
    }
}
