﻿/*
 * EIGERLANG NODETYPE ENUM
*/

namespace EigerLang.Parsing;

public enum NodeType
{
    Block,
    If,
    While,
    ForTo,
    Return,
    FuncCall,
    FuncDef,
    FuncDefInline,
    BinOp,
    Literal,
    Identifier,
    Array,
    ElementAccess,
    Class,
    AttrAccess,
    Dataclass,
    Include,
    UnaryOp,
    Break
}