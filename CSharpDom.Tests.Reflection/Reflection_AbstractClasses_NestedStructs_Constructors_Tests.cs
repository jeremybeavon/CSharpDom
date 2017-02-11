using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStructs_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_AbstractClasses_NestedStructs_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstructorWith1AttributeUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstructorWith1ParameterUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstructorWith2ParametersUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithInternalConstructorUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPrivateConstructorUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPublicConstructorUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithPublicConstructor));
        }
    }
}
