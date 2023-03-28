using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Creational.Builder.Theory
{
    internal class ConcreteBuilder : IBuilder
    {
        private Product product = new Product();

        public ConcreteBuilder()
        {
            Reset();
        }

        private void Reset()
        {
            product = new Product();
        }

        public void BuildPartA()
        {
            product.Add("PartA1");
        }

        public void BuildPartB()
        {
            product.Add("PartB1");
        }

        public void BuildPartC()
        {
            product.Add("PartC1");
        }

        // Concrete Builders are supposed to provide their own methods for
        // retrieving results. That's because various types of builders may
        // create entirely different products that don't follow the same
        // interface. Therefore, such methods cannot be declared in the base
        // Builder interface (at least in a statically typed programming
        // language).
        //
        // Usually, after returning the end result to the client, a builder
        // instance is expected to be ready to start producing another product.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetProduct` method body. However, this behavior is not
        // mandatory, and you can make your builders wait for an explicit reset
        // call from the client code before disposing of the previous result.
        public Product GetProduct()
        {
            Product result = product;

            this.Reset();

            return result;
        }
    }
}
