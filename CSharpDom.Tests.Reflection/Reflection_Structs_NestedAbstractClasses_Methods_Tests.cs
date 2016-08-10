using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverrideMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualMethod));
        }
    }
}
