using CSharpDom.TestTarget.Structs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_Structs_Constructors_Tests()
        {
            IsConstructorTest = true;
        }

        [TestMethod]
        public void TestStructWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithInternalConstructorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithPrivateConstructorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithPublicConstructorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPublicConstructor));
        }
    }
}
