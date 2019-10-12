namespace dotless.Core.Parser.Functions
{
    using Infrastructure;
    using Infrastructure.Nodes;
    using System;
    using Tree;

    public class AbsFunction : NumberFunctionBase
    {
        protected override Node Eval(Env env, Number number, Node[] args)
        {
            WarnNotSupportedByLessJS("abs(number)");

            return new Number(Math.Abs(number.Value), number.Unit);
        }
    }
}