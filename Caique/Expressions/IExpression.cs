using System;
using System.Collections.Generic;
using Caique.Models;

namespace Caique.Expressions
{
    interface IExpression
    {
        BaseType Cast     { get; set; }
        BaseType BaseType { get; set; }
        T Accept<T>(IExpressionVisitor<T> expr);
    }
}
