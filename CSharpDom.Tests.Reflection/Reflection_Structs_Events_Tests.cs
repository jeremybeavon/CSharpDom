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
            TestStructAsync(typeof(StructWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithPrivateEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithPublicEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithPublicEvent));
        }

        [TestMethod]
        public void TestStructWithStaticEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithStaticEvent));
        }
    }
}
