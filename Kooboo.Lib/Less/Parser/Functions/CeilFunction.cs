namespace dotless.Core.Parser.Functions
{
    using Infrastructure;
    using Infrastructure.Nodes;
    using System;
    using Tree;

    public class CeilFunction : NumberFunctionBase
    {
        protected override Node Eval(Env env, Number number, Node[] args)
        {
            return new Number(Math.Ceiling(number.Value), number.Unit);
        }
    }
}