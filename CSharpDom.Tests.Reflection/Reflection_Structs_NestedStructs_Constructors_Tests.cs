using CSharpDom.TestTarget.Structs.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_Structs_NestedStructs_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith1ParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith2ParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicConstructor));
        }
    }
}
