using CSharpDom.TestTarget.Structs.NestedStaticClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStaticClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPublicMethod));
        }
    }
}
