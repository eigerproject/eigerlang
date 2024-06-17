﻿using EigerLang.Errors;
using EigerLang.Parsing;

namespace EigerLang.Execution.BuiltInTypes;

public class Value(string filename,int line, int pos)
{
    public virtual dynamic AddedTo(object other)
    {
        throw new EigerError(filename, line, pos, $"{Globals.InvalidOperationStr}: {this.GetType().Name} + {other.GetType().Name}", EigerError.ErrorType.InvalidOperationError);
    }

    public virtual dynamic SubbedBy(object other)
    {
        throw new EigerError(filename, line, pos, $"{Globals.InvalidOperationStr}: {this.GetType().Name} - {other.GetType().Name}", EigerError.ErrorType.InvalidOperationError);
    }
    public virtual dynamic MultedBy(object other)
    {
        throw new EigerError(filename, line, pos, $"{Globals.InvalidOperationStr}: {this.GetType().Name} * {other.GetType().Name}", EigerError.ErrorType.InvalidOperationError);
    }

    public virtual dynamic DivedBy(object other)
    {
        throw new EigerError(filename, line, pos, $"{Globals.InvalidOperationStr}: {this.GetType().Name} / {other.GetType().Name}", EigerError.ErrorType.InvalidOperationError);
    }

    public virtual Boolean ComparisonEqeq(object other)
    {
        throw new EigerError(filename, line, pos, $"{Globals.InvalidOperationStr}: {this.GetType().Name} ?= {other.GetType().Name}", EigerError.ErrorType.InvalidOperationError);
    }

    public virtual Boolean ComparisonNeqeq(object other)
    {
        throw new EigerError(filename, line, pos, $"{Globals.InvalidOperationStr}: {this.GetType().Name} != {other.GetType().Name}", EigerError.ErrorType.InvalidOperationError);
    }

    public virtual Boolean ComparisonGT(object other)
    {
        throw new EigerError(filename, line, pos, $"{Globals.InvalidOperationStr}: {this.GetType().Name} > {other.GetType().Name}", EigerError.ErrorType.InvalidOperationError);
    }

    public virtual Boolean ComparisonLTE(object other)
    {
        throw new EigerError(filename, line, pos, $"{Globals.InvalidOperationStr}: {this.GetType().Name} <= {other.GetType().Name}", EigerError.ErrorType.InvalidOperationError);
    }

    public virtual Boolean ComparisonGTE(object other)
    {
        throw new EigerError(filename, line, pos, $"{Globals.InvalidOperationStr}: {this.GetType().Name} >= {other.GetType().Name}", EigerError.ErrorType.InvalidOperationError);
    }

    public virtual Boolean ComparisonLT(object other)
    {
        throw new EigerError(filename, line, pos, $"{Globals.InvalidOperationStr}: {this.GetType().Name} < {other.GetType().Name}", EigerError.ErrorType.InvalidOperationError);
    }

    public virtual Value GetIndex(int idx)
    {
        throw new EigerError(filename, line, pos, "Object is not iterable", EigerError.ErrorType.RuntimeError);
    }

    public virtual void SetIndex(int idx,Value val)
    {
        throw new EigerError(filename, line, pos, "Object is not iterable", EigerError.ErrorType.RuntimeError);
    }

    public virtual Value GetAttr(ASTNode attr)
    {
        throw new EigerError(filename, line, pos, "Not an object", EigerError.ErrorType.RuntimeError);
    }

    public virtual void SetAttr(ASTNode attr, Value val)
    {
        throw new EigerError(filename, line, pos, "Not an object", EigerError.ErrorType.RuntimeError);
    }

    public static Value ToEigerValue(string filename,int line,int pos,dynamic val)
    {
        if (val is double || val is int)
        {
            return new Number(filename, line, pos, val);
        }
        else if(val is string)
        {
            return new String(filename, line, pos, val);
        }
        throw new EigerError(filename, line, pos, "Invalid Data type", EigerError.ErrorType.ParserError);
    }
}