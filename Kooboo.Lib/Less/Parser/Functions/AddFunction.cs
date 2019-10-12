namespace dotless.Core.Parser.Functions
{
    using Infrastructure;
    using Infrastructure.Nodes;
    using System.Linq;
    using Tree;
    using Utils;

    public class AddFunction : Function
    {
        protected override Node Evaluate(Env env)
        {
            Guard.ExpectAllNodes<Number>(Arguments, this, Location);

            var value = Arguments.Cast<Number>().Select(d => d.Value).Aggregate(0d, (a, b) => a + b);

            return new Number(value);
        }
    }
}