using CSharpDom.TestTarget.Structs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithInternalEventUsingReflection()
        {
            TestStruct(typeof(StructWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithPrivateEventUsingReflection()
        {
            TestStruct(typeof(StructWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithPublicEventUsingReflection()
        {
            TestStruct(typeof(StructWithPublicEvent));
        }

        [TestMethod]
        public void TestStructWithStaticEventUsingReflection()
        {
            TestStruct(typeof(StructWithStaticEvent));
        }
    }
}
