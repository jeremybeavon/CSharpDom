using CSharpDom.TestTarget.Structs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithInternalEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithPrivateEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithPublicEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPublicEvent));
        }

        [TestMethod]
        public void TestStructWithStaticEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithStaticEvent));
        }
    }
}
