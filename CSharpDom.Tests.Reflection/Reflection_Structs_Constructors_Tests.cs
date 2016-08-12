using CSharpDom.TestTarget.Structs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_Structs_Constructors_Tests()
        {
            IsConstructorTest = true;
        }

        [TestMethod]
        public void TestStructWithConstructorWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithConstructorWith1ParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithConstructorWith2ParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithInternalConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestStructAsync(typeof(StructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestStructAsync(typeof(StructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithPrivateConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithPublicConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithPublicConstructor));
        }
    }
}
