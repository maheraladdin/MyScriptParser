
using System;
using System.IO;
using System.Runtime.Serialization;
using com.calitha.goldparser.lalr;
using com.calitha.commons;

namespace com.calitha.goldparser
{

    [Serializable()]
    public class SymbolException : System.Exception
    {
        public SymbolException(string message) : base(message)
        {
        }

        public SymbolException(string message,
            Exception inner) : base(message, inner)
        {
        }

        protected SymbolException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }

    }

    [Serializable()]
    public class RuleException : System.Exception
    {

        public RuleException(string message) : base(message)
        {
        }

        public RuleException(string message,
                             Exception inner) : base(message, inner)
        {
        }

        protected RuleException(SerializationInfo info,
                                StreamingContext context) : base(info, context)
        {
        }

    }

    enum SymbolConstants : int
    {
        SYMBOL_EOF                         =   0, // (EOF)
        SYMBOL_ERROR                       =   1, // (Error)
        SYMBOL_WHITESPACE                  =   2, // Whitespace
        SYMBOL_MINUS                       =   3, // '-'
        SYMBOL_MINUSMINUS                  =   4, // '--'
        SYMBOL_EXCLAM                      =   5, // '!'
        SYMBOL_EXCLAMEQ                    =   6, // '!='
        SYMBOL_EXCLAMEQEQ                  =   7, // '!=='
        SYMBOL_PERCENT                     =   8, // '%'
        SYMBOL_PERCENTEQ                   =   9, // '%='
        SYMBOL_AMP                         =  10, // '&'
        SYMBOL_AMPAMP                      =  11, // '&&'
        SYMBOL_AMPEQ                       =  12, // '&='
        SYMBOL_LPAREN                      =  13, // '('
        SYMBOL_RPAREN                      =  14, // ')'
        SYMBOL_TIMES                       =  15, // '*'
        SYMBOL_TIMESEQ                     =  16, // '*='
        SYMBOL_COMMA                       =  17, // ','
        SYMBOL_DIV                         =  18, // '/'
        SYMBOL_DIVEQ                       =  19, // '/='
        SYMBOL_COLON                       =  20, // ':'
        SYMBOL_SEMI                        =  21, // ';'
        SYMBOL_QUESTION                    =  22, // '?'
        SYMBOL_LBRACKET                    =  23, // '['
        SYMBOL_RBRACKET                    =  24, // ']'
        SYMBOL_CARET                       =  25, // '^'
        SYMBOL_CARETEQ                     =  26, // '^='
        SYMBOL_LBRACE                      =  27, // '{'
        SYMBOL_PIPE                        =  28, // '|'
        SYMBOL_PIPEPIPE                    =  29, // '||'
        SYMBOL_PIPEEQ                      =  30, // '|='
        SYMBOL_RBRACE                      =  31, // '}'
        SYMBOL_TILDE                       =  32, // '~'
        SYMBOL_PLUS                        =  33, // '+'
        SYMBOL_PLUSPLUS                    =  34, // '++'
        SYMBOL_PLUSEQ                      =  35, // '+='
        SYMBOL_LT                          =  36, // '<'
        SYMBOL_LTLT                        =  37, // '<<'
        SYMBOL_LTLTEQ                      =  38, // '<<='
        SYMBOL_LTEQ                        =  39, // '<='
        SYMBOL_EQ                          =  40, // '='
        SYMBOL_MINUSEQ                     =  41, // '-='
        SYMBOL_EQEQ                        =  42, // '=='
        SYMBOL_EQEQEQ                      =  43, // '==='
        SYMBOL_GT                          =  44, // '>'
        SYMBOL_GTEQ                        =  45, // '>='
        SYMBOL_GTGT                        =  46, // '>>'
        SYMBOL_GTGTEQ                      =  47, // '>>='
        SYMBOL_GTGTGT                      =  48, // '>>>'
        SYMBOL_GTGTGTEQ                    =  49, // '>>>='
        SYMBOL_BREAK                       =  50, // break
        SYMBOL_CASE                        =  51, // case
        SYMBOL_CATCH                       =  52, // catch
        SYMBOL_CONST                       =  53, // const
        SYMBOL_CONTINUE                    =  54, // continue
        SYMBOL_DECIMALLITERAL              =  55, // DecimalLiteral
        SYMBOL_DEFAULT                     =  56, // default
        SYMBOL_DO                          =  57, // do
        SYMBOL_ELSE                        =  58, // else
        SYMBOL_FALSE                       =  59, // false
        SYMBOL_FINALLY                     =  60, // finally
        SYMBOL_FOR                         =  61, // for
        SYMBOL_HEXINTEGERLITERAL           =  62, // HexIntegerLiteral
        SYMBOL_IDENTIFIER                  =  63, // Identifier
        SYMBOL_IF                          =  64, // if
        SYMBOL_LET                         =  65, // let
        SYMBOL_NEWLINE                     =  66, // NewLine
        SYMBOL_OF                          =  67, // of
        SYMBOL_STRINGLITERAL               =  68, // StringLiteral
        SYMBOL_SWITCH                      =  69, // switch
        SYMBOL_TRUE                        =  70, // true
        SYMBOL_TRY                         =  71, // try
        SYMBOL_TYPEOF                      =  72, // typeof
        SYMBOL_VAR                         =  73, // var
        SYMBOL_WHILE                       =  74, // while
        SYMBOL_ADDITIVEEXPRESSION          =  75, // <Additive Expression>
        SYMBOL_ADDITIVEOPERATIONS          =  76, // <Additive Operations>
        SYMBOL_ARRAYLITERAL                =  77, // <Array Literal>
        SYMBOL_ASSIGNMENTEXPRESSION        =  78, // <Assignment Expression>
        SYMBOL_ASSIGNMENTOPERATOR          =  79, // <Assignment Operator>
        SYMBOL_BITWISEANDEXPRESSION        =  80, // <Bitwise And Expression>
        SYMBOL_BITWISEOREXPRESSION         =  81, // <Bitwise Or Expression>
        SYMBOL_BITWISEXOREXPRESSION        =  82, // <Bitwise XOr Expression>
        SYMBOL_BLOCKSTATEMENT              =  83, // <Block Statement>
        SYMBOL_BOOLEANLITERAL              =  84, // <Boolean Literal>
        SYMBOL_BREAKSTATEMENT              =  85, // <Break Statement>
        SYMBOL_CASEBLOCK                   =  86, // <Case Block>
        SYMBOL_CASECLAUSE                  =  87, // <Case Clause>
        SYMBOL_CASECLAUSES                 =  88, // <Case Clauses>
        SYMBOL_CATCH2                      =  89, // <Catch>
        SYMBOL_CONDITIONALEXPRESSION       =  90, // <Conditional Expression>
        SYMBOL_CONTINUESTATEMENT           =  91, // <Continue Statement>
        SYMBOL_DEFAULTCLAUSE               =  92, // <Default Clause>
        SYMBOL_ELEMENT                     =  93, // <Element>
        SYMBOL_EQUALITYEXPRESSION          =  94, // <Equality Expression>
        SYMBOL_EQUALITYOPERATIONS          =  95, // <Equality Operations>
        SYMBOL_EXPRESSION                  =  96, // <Expression>
        SYMBOL_FINALLY2                    =  97, // <Finally>
        SYMBOL_IFELSESTATEMENT             =  98, // <If Else Statement>
        SYMBOL_IFSTATEMENT                 =  99, // <If Statement>
        SYMBOL_INDECREAMENT                = 100, // <In De Creament>
        SYMBOL_INITIALIZER                 = 101, // <Initializer>
        SYMBOL_ITERATIONSTATEMENT          = 102, // <Iteration Statement>
        SYMBOL_LITERAL                     = 103, // <Literal>
        SYMBOL_LOGICALANDEXPRESSION        = 104, // <Logical And Expression>
        SYMBOL_LOGICALOREXPRESSION         = 105, // <Logical Or Expression>
        SYMBOL_MULTIPLICATIVEEXPRESSION    = 106, // <Multiplicative Expression>
        SYMBOL_MULTIPLICATIVEOPERATIONS    = 107, // <Multiplicative Operations>
        SYMBOL_NL                          = 108, // <nl>
        SYMBOL_NLOPT                       = 109, // <nl Opt>
        SYMBOL_NUMERICLITERAL              = 110, // <Numeric Literal>
        SYMBOL_POSTFIXEXPRESSION           = 111, // <Postfix Expression>
        SYMBOL_PROGRAM                     = 112, // <Program>
        SYMBOL_RELATIONALEXPRESSION        = 113, // <Relational Expression>
        SYMBOL_RELATIONALOPERATIONS        = 114, // <Relational Operations>
        SYMBOL_SHIFTEXPRESSION             = 115, // <Shift Expression>
        SYMBOL_SHIFTOPERATIONS             = 116, // <Shift Operations>
        SYMBOL_START                       = 117, // <Start>
        SYMBOL_STATEMENT                   = 118, // <Statement>
        SYMBOL_STATEMENTLIST               = 119, // <Statement List>
        SYMBOL_SWITCHSTATEMENT             = 120, // <Switch Statement>
        SYMBOL_TRYSTATEMENT                = 121, // <Try Statement>
        SYMBOL_UNARYEXPRESSION             = 122, // <Unary Expression>
        SYMBOL_UNARYOPERATIONS             = 123, // <Unary Operations>
        SYMBOL_VARIABLEDECLARATION         = 124, // <Variable Declaration>
        SYMBOL_VARIABLEDECLARATIONKEYWORDS = 125, // <Variable Declaration Keywords>
        SYMBOL_VARIABLEDECLARATIONLIST     = 126, // <Variable Declaration List>
        SYMBOL_VARIABLESTATEMENT           = 127  // <Variable Statement>
    };

    enum RuleConstants : int
    {
        RULE_NL_NEWLINE                                      =   0, // <nl> ::= NewLine <nl>
        RULE_NL                                              =   1, // <nl> ::= 
        RULE_NLOPT_NEWLINE                                   =   2, // <nl Opt> ::= NewLine <nl Opt>
        RULE_NLOPT                                           =   3, // <nl Opt> ::= 
        RULE_START                                           =   4, // <Start> ::= <nl Opt> <Program>
        RULE_PROGRAM                                         =   5, // <Program> ::= <Statement List>
        RULE_STATEMENTLIST_SEMI                              =   6, // <Statement List> ::= <Statement> ';' <nl> <Statement List>
        RULE_STATEMENTLIST_SEMI2                             =   7, // <Statement List> ::= <Statement> ';'
        RULE_STATEMENT                                       =   8, // <Statement> ::= <Block Statement>
        RULE_STATEMENT2                                      =   9, // <Statement> ::= <Variable Statement>
        RULE_STATEMENT3                                      =  10, // <Statement> ::= <If Statement>
        RULE_STATEMENT4                                      =  11, // <Statement> ::= <If Else Statement>
        RULE_STATEMENT5                                      =  12, // <Statement> ::= <Iteration Statement>
        RULE_STATEMENT6                                      =  13, // <Statement> ::= <Continue Statement>
        RULE_STATEMENT7                                      =  14, // <Statement> ::= <Break Statement>
        RULE_STATEMENT8                                      =  15, // <Statement> ::= <Switch Statement>
        RULE_STATEMENT9                                      =  16, // <Statement> ::= <Try Statement>
        RULE_STATEMENT10                                     =  17, // <Statement> ::= <Expression>
        RULE_EXPRESSION                                      =  18, // <Expression> ::= <Assignment Expression>
        RULE_EXPRESSION_COMMA                                =  19, // <Expression> ::= <Expression> ',' <Assignment Expression>
        RULE_BLOCKSTATEMENT_LBRACE_RBRACE                    =  20, // <Block Statement> ::= '{' '}'
        RULE_BLOCKSTATEMENT_LBRACE_RBRACE2                   =  21, // <Block Statement> ::= '{' <Statement List> '}'
        RULE_VARIABLESTATEMENT                               =  22, // <Variable Statement> ::= <Variable Declaration Keywords> <Variable Declaration List>
        RULE_VARIABLEDECLARATIONKEYWORDS_VAR                 =  23, // <Variable Declaration Keywords> ::= var
        RULE_VARIABLEDECLARATIONKEYWORDS_LET                 =  24, // <Variable Declaration Keywords> ::= let
        RULE_VARIABLEDECLARATIONKEYWORDS_CONST               =  25, // <Variable Declaration Keywords> ::= const
        RULE_VARIABLEDECLARATIONLIST                         =  26, // <Variable Declaration List> ::= <Variable Declaration>
        RULE_VARIABLEDECLARATIONLIST_COMMA                   =  27, // <Variable Declaration List> ::= <Variable Declaration List> ',' <Variable Declaration>
        RULE_VARIABLEDECLARATION_IDENTIFIER                  =  28, // <Variable Declaration> ::= Identifier
        RULE_VARIABLEDECLARATION_IDENTIFIER2                 =  29, // <Variable Declaration> ::= Identifier <Initializer>
        RULE_INITIALIZER_EQ                                  =  30, // <Initializer> ::= '=' <Assignment Expression>
        RULE_ASSIGNMENTEXPRESSION                            =  31, // <Assignment Expression> ::= <Conditional Expression>
        RULE_ASSIGNMENTEXPRESSION2                           =  32, // <Assignment Expression> ::= <Literal> <Assignment Operator> <Assignment Expression>
        RULE_CONDITIONALEXPRESSION                           =  33, // <Conditional Expression> ::= <Logical Or Expression>
        RULE_CONDITIONALEXPRESSION_QUESTION_COLON            =  34, // <Conditional Expression> ::= <Logical Or Expression> '?' <Assignment Expression> ':' <Assignment Expression>
        RULE_LOGICALOREXPRESSION                             =  35, // <Logical Or Expression> ::= <Logical And Expression>
        RULE_LOGICALOREXPRESSION_PIPEPIPE                    =  36, // <Logical Or Expression> ::= <Logical Or Expression> '||' <Logical And Expression>
        RULE_LOGICALANDEXPRESSION                            =  37, // <Logical And Expression> ::= <Bitwise Or Expression>
        RULE_LOGICALANDEXPRESSION_AMPAMP                     =  38, // <Logical And Expression> ::= <Logical And Expression> '&&' <Bitwise Or Expression>
        RULE_BITWISEOREXPRESSION                             =  39, // <Bitwise Or Expression> ::= <Bitwise XOr Expression>
        RULE_BITWISEOREXPRESSION_PIPE                        =  40, // <Bitwise Or Expression> ::= <Bitwise Or Expression> '|' <Bitwise XOr Expression>
        RULE_BITWISEXOREXPRESSION                            =  41, // <Bitwise XOr Expression> ::= <Bitwise And Expression>
        RULE_BITWISEXOREXPRESSION_CARET                      =  42, // <Bitwise XOr Expression> ::= <Bitwise XOr Expression> '^' <Bitwise And Expression>
        RULE_BITWISEANDEXPRESSION                            =  43, // <Bitwise And Expression> ::= <Equality Expression>
        RULE_BITWISEANDEXPRESSION_AMP                        =  44, // <Bitwise And Expression> ::= <Bitwise And Expression> '&' <Equality Expression>
        RULE_EQUALITYEXPRESSION                              =  45, // <Equality Expression> ::= <Relational Expression>
        RULE_EQUALITYEXPRESSION2                             =  46, // <Equality Expression> ::= <Equality Expression> <Equality Operations> <Relational Expression>
        RULE_EQUALITYOPERATIONS_EQEQ                         =  47, // <Equality Operations> ::= '=='
        RULE_EQUALITYOPERATIONS_EXCLAMEQ                     =  48, // <Equality Operations> ::= '!='
        RULE_EQUALITYOPERATIONS_EQEQEQ                       =  49, // <Equality Operations> ::= '==='
        RULE_EQUALITYOPERATIONS_EXCLAMEQEQ                   =  50, // <Equality Operations> ::= '!=='
        RULE_RELATIONALEXPRESSION                            =  51, // <Relational Expression> ::= <Shift Expression>
        RULE_RELATIONALEXPRESSION2                           =  52, // <Relational Expression> ::= <Relational Expression> <Relational Operations> <Shift Expression>
        RULE_RELATIONALOPERATIONS_LT                         =  53, // <Relational Operations> ::= '<'
        RULE_RELATIONALOPERATIONS_GT                         =  54, // <Relational Operations> ::= '>'
        RULE_RELATIONALOPERATIONS_LTEQ                       =  55, // <Relational Operations> ::= '<='
        RULE_RELATIONALOPERATIONS_GTEQ                       =  56, // <Relational Operations> ::= '>='
        RULE_SHIFTEXPRESSION                                 =  57, // <Shift Expression> ::= <Shift Expression> <Shift Operations> <Additive Expression>
        RULE_SHIFTEXPRESSION2                                =  58, // <Shift Expression> ::= <Additive Expression>
        RULE_SHIFTOPERATIONS_LTLT                            =  59, // <Shift Operations> ::= '<<'
        RULE_SHIFTOPERATIONS_GTGT                            =  60, // <Shift Operations> ::= '>>'
        RULE_SHIFTOPERATIONS_GTGTGT                          =  61, // <Shift Operations> ::= '>>>'
        RULE_ADDITIVEEXPRESSION                              =  62, // <Additive Expression> ::= <Additive Expression> <Additive Operations> <Multiplicative Expression>
        RULE_ADDITIVEEXPRESSION2                             =  63, // <Additive Expression> ::= <Multiplicative Expression>
        RULE_ADDITIVEOPERATIONS_PLUS                         =  64, // <Additive Operations> ::= '+'
        RULE_ADDITIVEOPERATIONS_MINUS                        =  65, // <Additive Operations> ::= '-'
        RULE_MULTIPLICATIVEEXPRESSION                        =  66, // <Multiplicative Expression> ::= <Unary Expression>
        RULE_MULTIPLICATIVEEXPRESSION2                       =  67, // <Multiplicative Expression> ::= <Unary Expression> <Multiplicative Operations> <Multiplicative Expression>
        RULE_MULTIPLICATIVEOPERATIONS_TIMES                  =  68, // <Multiplicative Operations> ::= '*'
        RULE_MULTIPLICATIVEOPERATIONS_DIV                    =  69, // <Multiplicative Operations> ::= '/'
        RULE_MULTIPLICATIVEOPERATIONS_PERCENT                =  70, // <Multiplicative Operations> ::= '%'
        RULE_UNARYEXPRESSION                                 =  71, // <Unary Expression> ::= <Postfix Expression>
        RULE_UNARYEXPRESSION2                                =  72, // <Unary Expression> ::= <Unary Operations> <Unary Expression>
        RULE_UNARYOPERATIONS_TYPEOF                          =  73, // <Unary Operations> ::= typeof
        RULE_UNARYOPERATIONS_PLUS                            =  74, // <Unary Operations> ::= '+'
        RULE_UNARYOPERATIONS_MINUS                           =  75, // <Unary Operations> ::= '-'
        RULE_UNARYOPERATIONS_TILDE                           =  76, // <Unary Operations> ::= '~'
        RULE_UNARYOPERATIONS_EXCLAM                          =  77, // <Unary Operations> ::= '!'
        RULE_UNARYOPERATIONS                                 =  78, // <Unary Operations> ::= <In De Creament>
        RULE_INDECREAMENT_PLUSPLUS                           =  79, // <In De Creament> ::= '++'
        RULE_INDECREAMENT_MINUSMINUS                         =  80, // <In De Creament> ::= '--'
        RULE_POSTFIXEXPRESSION                               =  81, // <Postfix Expression> ::= <Literal>
        RULE_POSTFIXEXPRESSION2                              =  82, // <Postfix Expression> ::= <Postfix Expression> <In De Creament>
        RULE_LITERAL                                         =  83, // <Literal> ::= <Boolean Literal>
        RULE_LITERAL2                                        =  84, // <Literal> ::= <Numeric Literal>
        RULE_LITERAL3                                        =  85, // <Literal> ::= <Array Literal>
        RULE_LITERAL_STRINGLITERAL                           =  86, // <Literal> ::= StringLiteral
        RULE_LITERAL_IDENTIFIER                              =  87, // <Literal> ::= Identifier
        RULE_BOOLEANLITERAL_TRUE                             =  88, // <Boolean Literal> ::= true
        RULE_BOOLEANLITERAL_FALSE                            =  89, // <Boolean Literal> ::= false
        RULE_NUMERICLITERAL_DECIMALLITERAL                   =  90, // <Numeric Literal> ::= DecimalLiteral
        RULE_NUMERICLITERAL_HEXINTEGERLITERAL                =  91, // <Numeric Literal> ::= HexIntegerLiteral
        RULE_ARRAYLITERAL_LBRACKET_RBRACKET                  =  92, // <Array Literal> ::= '[' ']'
        RULE_ARRAYLITERAL_LBRACKET_RBRACKET2                 =  93, // <Array Literal> ::= '[' <Element> ']'
        RULE_ELEMENT                                         =  94, // <Element> ::= <Literal>
        RULE_ELEMENT_COMMA                                   =  95, // <Element> ::= <Literal> ',' <Element>
        RULE_ASSIGNMENTOPERATOR_EQ                           =  96, // <Assignment Operator> ::= '='
        RULE_ASSIGNMENTOPERATOR_TIMESEQ                      =  97, // <Assignment Operator> ::= '*='
        RULE_ASSIGNMENTOPERATOR_DIVEQ                        =  98, // <Assignment Operator> ::= '/='
        RULE_ASSIGNMENTOPERATOR_PERCENTEQ                    =  99, // <Assignment Operator> ::= '%='
        RULE_ASSIGNMENTOPERATOR_PLUSEQ                       = 100, // <Assignment Operator> ::= '+='
        RULE_ASSIGNMENTOPERATOR_MINUSEQ                      = 101, // <Assignment Operator> ::= '-='
        RULE_ASSIGNMENTOPERATOR_LTLTEQ                       = 102, // <Assignment Operator> ::= '<<='
        RULE_ASSIGNMENTOPERATOR_GTGTEQ                       = 103, // <Assignment Operator> ::= '>>='
        RULE_ASSIGNMENTOPERATOR_GTGTGTEQ                     = 104, // <Assignment Operator> ::= '>>>='
        RULE_ASSIGNMENTOPERATOR_AMPEQ                        = 105, // <Assignment Operator> ::= '&='
        RULE_ASSIGNMENTOPERATOR_CARETEQ                      = 106, // <Assignment Operator> ::= '^='
        RULE_ASSIGNMENTOPERATOR_PIPEEQ                       = 107, // <Assignment Operator> ::= '|='
        RULE_IFSTATEMENT_IF_LPAREN_RPAREN                    = 108, // <If Statement> ::= if '(' <Expression> ')' <Statement>
        RULE_IFELSESTATEMENT_IF_LPAREN_RPAREN_ELSE           = 109, // <If Else Statement> ::= if '(' <Expression> ')' <Statement> else <Statement>
        RULE_SWITCHSTATEMENT_SWITCH_LPAREN_RPAREN            = 110, // <Switch Statement> ::= switch '(' <Expression> ')' <Case Block>
        RULE_CASEBLOCK_LBRACE_RBRACE                         = 111, // <Case Block> ::= '{' '}'
        RULE_CASEBLOCK_LBRACE_RBRACE2                        = 112, // <Case Block> ::= '{' <Case Clauses> '}'
        RULE_CASEBLOCK_LBRACE_RBRACE3                        = 113, // <Case Block> ::= '{' <Case Clauses> <Default Clause> '}'
        RULE_CASEBLOCK_LBRACE_RBRACE4                        = 114, // <Case Block> ::= '{' <Case Clauses> <Default Clause> <Case Clauses> '}'
        RULE_CASEBLOCK_LBRACE_RBRACE5                        = 115, // <Case Block> ::= '{' <Default Clause> <Case Clauses> '}'
        RULE_CASEBLOCK_LBRACE_RBRACE6                        = 116, // <Case Block> ::= '{' <Default Clause> '}'
        RULE_CASECLAUSES                                     = 117, // <Case Clauses> ::= <Case Clause>
        RULE_CASECLAUSES2                                    = 118, // <Case Clauses> ::= <Case Clauses> <Case Clause>
        RULE_CASECLAUSE_CASE_COLON                           = 119, // <Case Clause> ::= case <Expression> ':' <Statement List>
        RULE_CASECLAUSE_CASE_COLON2                          = 120, // <Case Clause> ::= case <Expression> ':'
        RULE_DEFAULTCLAUSE_DEFAULT_COLON                     = 121, // <Default Clause> ::= default ':'
        RULE_DEFAULTCLAUSE_DEFAULT_COLON2                    = 122, // <Default Clause> ::= default ':' <Statement List>
        RULE_ITERATIONSTATEMENT_DO_WHILE_LPAREN_RPAREN       = 123, // <Iteration Statement> ::= do <Statement> while '(' <Expression> ')'
        RULE_ITERATIONSTATEMENT_WHILE_LPAREN_RPAREN          = 124, // <Iteration Statement> ::= while '(' <Expression> ')' <Statement>
        RULE_ITERATIONSTATEMENT_FOR_LPAREN_SEMI_SEMI_RPAREN  = 125, // <Iteration Statement> ::= for '(' <Expression> ';' <Expression> ';' <Expression> ')' <Statement>
        RULE_ITERATIONSTATEMENT_FOR_LPAREN_SEMI_SEMI_RPAREN2 = 126, // <Iteration Statement> ::= for '(' <Variable Declaration Keywords> <Variable Declaration List> ';' <Expression> ';' <Expression> ')' <Statement>
        RULE_ITERATIONSTATEMENT_FOR_LPAREN_OF_RPAREN         = 127, // <Iteration Statement> ::= for '(' <Variable Declaration Keywords> <Variable Declaration> of <Expression> ')' <Statement>
        RULE_CONTINUESTATEMENT_CONTINUE                      = 128, // <Continue Statement> ::= continue
        RULE_BREAKSTATEMENT_BREAK                            = 129, // <Break Statement> ::= break
        RULE_TRYSTATEMENT_TRY                                = 130, // <Try Statement> ::= try <Block Statement> <Catch>
        RULE_TRYSTATEMENT_TRY2                               = 131, // <Try Statement> ::= try <Block Statement> <Finally>
        RULE_TRYSTATEMENT_TRY3                               = 132, // <Try Statement> ::= try <Block Statement> <Catch> <Finally>
        RULE_CATCH_CATCH_LPAREN_IDENTIFIER_RPAREN            = 133, // <Catch> ::= catch '(' Identifier ')' <Block Statement>
        RULE_FINALLY_FINALLY                                 = 134  // <Finally> ::= finally <Block Statement>
    };

    public class MyParser
    {
        private LALRParser parser;
        RichTextBox rtb;

        public MyParser(string filename,RichTextBox rtb)
        {
            FileStream stream = new FileStream(filename,
                                               FileMode.Open, 
                                               FileAccess.Read, 
                                               FileShare.Read);
            this.rtb = rtb;
            Init(stream);
            stream.Close();
        }

        public MyParser(string baseName, string resourceName)
        {
            byte[] buffer = ResourceUtil.GetByteArrayResource(
                System.Reflection.Assembly.GetExecutingAssembly(),
                baseName,
                resourceName);
            MemoryStream stream = new MemoryStream(buffer);
            Init(stream);
            stream.Close();
        }

        public MyParser(Stream stream)
        {
            Init(stream);
        }

        private void Init(Stream stream)
        {
            CGTReader reader = new CGTReader(stream);
            parser = reader.CreateNewParser();
            parser.TrimReductions = false;
            parser.StoreTokens = LALRParser.StoreTokensMode.NoUserObject;

            parser.OnTokenError += new LALRParser.TokenErrorHandler(TokenErrorEvent);
            parser.OnParseError += new LALRParser.ParseErrorHandler(ParseErrorEvent);
        }

        public void Parse(string source)
        {
            NonterminalToken token = parser.Parse(source);
            if (token != null)
            {
                Object obj = CreateObject(token);
                //todo: Use your object any way you like
            }
        }

        private Object CreateObject(Token token)
        {
            if (token is TerminalToken)
                return CreateObjectFromTerminal((TerminalToken)token);
            else
                return CreateObjectFromNonterminal((NonterminalToken)token);
        }

        private Object CreateObjectFromTerminal(TerminalToken token)
        {
            switch (token.Symbol.Id)
            {
                case (int)SymbolConstants.SYMBOL_EOF :
                //(EOF)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ERROR :
                //(Error)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHITESPACE :
                //Whitespace
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MINUS :
                //'-'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MINUSMINUS :
                //'--'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXCLAM :
                //'!'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXCLAMEQ :
                //'!='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXCLAMEQEQ :
                //'!=='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PERCENT :
                //'%'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PERCENTEQ :
                //'%='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_AMP :
                //'&'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_AMPAMP :
                //'&&'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_AMPEQ :
                //'&='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LPAREN :
                //'('
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RPAREN :
                //')'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TIMES :
                //'*'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TIMESEQ :
                //'*='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMMA :
                //','
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DIV :
                //'/'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DIVEQ :
                //'/='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COLON :
                //':'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SEMI :
                //';'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_QUESTION :
                //'?'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LBRACKET :
                //'['
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RBRACKET :
                //']'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CARET :
                //'^'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CARETEQ :
                //'^='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LBRACE :
                //'{'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PIPE :
                //'|'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PIPEPIPE :
                //'||'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PIPEEQ :
                //'|='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RBRACE :
                //'}'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TILDE :
                //'~'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PLUS :
                //'+'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PLUSPLUS :
                //'++'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PLUSEQ :
                //'+='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LT :
                //'<'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LTLT :
                //'<<'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LTLTEQ :
                //'<<='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LTEQ :
                //'<='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQ :
                //'='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MINUSEQ :
                //'-='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQEQ :
                //'=='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQEQEQ :
                //'==='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_GT :
                //'>'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_GTEQ :
                //'>='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_GTGT :
                //'>>'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_GTGTEQ :
                //'>>='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_GTGTGT :
                //'>>>'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_GTGTGTEQ :
                //'>>>='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BREAK :
                //break
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CASE :
                //case
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CATCH :
                //catch
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CONST :
                //const
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CONTINUE :
                //continue
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DECIMALLITERAL :
                //DecimalLiteral
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DEFAULT :
                //default
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DO :
                //do
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ELSE :
                //else
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FALSE :
                //false
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FINALLY :
                //finally
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FOR :
                //for
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_HEXINTEGERLITERAL :
                //HexIntegerLiteral
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IDENTIFIER :
                //Identifier
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IF :
                //if
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LET :
                //let
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NEWLINE :
                //NewLine
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OF :
                //of
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STRINGLITERAL :
                //StringLiteral
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SWITCH :
                //switch
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TRUE :
                //true
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TRY :
                //try
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TYPEOF :
                //typeof
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_VAR :
                //var
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHILE :
                //while
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ADDITIVEEXPRESSION :
                //<Additive Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ADDITIVEOPERATIONS :
                //<Additive Operations>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ARRAYLITERAL :
                //<Array Literal>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ASSIGNMENTEXPRESSION :
                //<Assignment Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ASSIGNMENTOPERATOR :
                //<Assignment Operator>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BITWISEANDEXPRESSION :
                //<Bitwise And Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BITWISEOREXPRESSION :
                //<Bitwise Or Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BITWISEXOREXPRESSION :
                //<Bitwise XOr Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BLOCKSTATEMENT :
                //<Block Statement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BOOLEANLITERAL :
                //<Boolean Literal>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BREAKSTATEMENT :
                //<Break Statement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CASEBLOCK :
                //<Case Block>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CASECLAUSE :
                //<Case Clause>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CASECLAUSES :
                //<Case Clauses>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CATCH2 :
                //<Catch>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CONDITIONALEXPRESSION :
                //<Conditional Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CONTINUESTATEMENT :
                //<Continue Statement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DEFAULTCLAUSE :
                //<Default Clause>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ELEMENT :
                //<Element>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQUALITYEXPRESSION :
                //<Equality Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQUALITYOPERATIONS :
                //<Equality Operations>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXPRESSION :
                //<Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FINALLY2 :
                //<Finally>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IFELSESTATEMENT :
                //<If Else Statement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IFSTATEMENT :
                //<If Statement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_INDECREAMENT :
                //<In De Creament>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_INITIALIZER :
                //<Initializer>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ITERATIONSTATEMENT :
                //<Iteration Statement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LITERAL :
                //<Literal>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LOGICALANDEXPRESSION :
                //<Logical And Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LOGICALOREXPRESSION :
                //<Logical Or Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MULTIPLICATIVEEXPRESSION :
                //<Multiplicative Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MULTIPLICATIVEOPERATIONS :
                //<Multiplicative Operations>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NL :
                //<nl>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NLOPT :
                //<nl Opt>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NUMERICLITERAL :
                //<Numeric Literal>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_POSTFIXEXPRESSION :
                //<Postfix Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PROGRAM :
                //<Program>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RELATIONALEXPRESSION :
                //<Relational Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RELATIONALOPERATIONS :
                //<Relational Operations>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SHIFTEXPRESSION :
                //<Shift Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SHIFTOPERATIONS :
                //<Shift Operations>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_START :
                //<Start>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STATEMENT :
                //<Statement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STATEMENTLIST :
                //<Statement List>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SWITCHSTATEMENT :
                //<Switch Statement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TRYSTATEMENT :
                //<Try Statement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_UNARYEXPRESSION :
                //<Unary Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_UNARYOPERATIONS :
                //<Unary Operations>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_VARIABLEDECLARATION :
                //<Variable Declaration>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_VARIABLEDECLARATIONKEYWORDS :
                //<Variable Declaration Keywords>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_VARIABLEDECLARATIONLIST :
                //<Variable Declaration List>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_VARIABLESTATEMENT :
                //<Variable Statement>
                //todo: Create a new object that corresponds to the symbol
                return null;

            }
            throw new SymbolException("Unknown symbol");
        }

        public Object CreateObjectFromNonterminal(NonterminalToken token)
        {
            switch (token.Rule.Id)
            {
                case (int)RuleConstants.RULE_NL_NEWLINE :
                //<nl> ::= NewLine <nl>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_NL :
                //<nl> ::= 
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_NLOPT_NEWLINE :
                //<nl Opt> ::= NewLine <nl Opt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_NLOPT :
                //<nl Opt> ::= 
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_START :
                //<Start> ::= <nl Opt> <Program>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PROGRAM :
                //<Program> ::= <Statement List>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENTLIST_SEMI :
                //<Statement List> ::= <Statement> ';' <nl> <Statement List>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENTLIST_SEMI2 :
                //<Statement List> ::= <Statement> ';'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT :
                //<Statement> ::= <Block Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT2 :
                //<Statement> ::= <Variable Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT3 :
                //<Statement> ::= <If Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT4 :
                //<Statement> ::= <If Else Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT5 :
                //<Statement> ::= <Iteration Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT6 :
                //<Statement> ::= <Continue Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT7 :
                //<Statement> ::= <Break Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT8 :
                //<Statement> ::= <Switch Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT9 :
                //<Statement> ::= <Try Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT10 :
                //<Statement> ::= <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRESSION :
                //<Expression> ::= <Assignment Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRESSION_COMMA :
                //<Expression> ::= <Expression> ',' <Assignment Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BLOCKSTATEMENT_LBRACE_RBRACE :
                //<Block Statement> ::= '{' '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BLOCKSTATEMENT_LBRACE_RBRACE2 :
                //<Block Statement> ::= '{' <Statement List> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VARIABLESTATEMENT :
                //<Variable Statement> ::= <Variable Declaration Keywords> <Variable Declaration List>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VARIABLEDECLARATIONKEYWORDS_VAR :
                //<Variable Declaration Keywords> ::= var
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VARIABLEDECLARATIONKEYWORDS_LET :
                //<Variable Declaration Keywords> ::= let
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VARIABLEDECLARATIONKEYWORDS_CONST :
                //<Variable Declaration Keywords> ::= const
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VARIABLEDECLARATIONLIST :
                //<Variable Declaration List> ::= <Variable Declaration>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VARIABLEDECLARATIONLIST_COMMA :
                //<Variable Declaration List> ::= <Variable Declaration List> ',' <Variable Declaration>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VARIABLEDECLARATION_IDENTIFIER :
                //<Variable Declaration> ::= Identifier
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VARIABLEDECLARATION_IDENTIFIER2 :
                //<Variable Declaration> ::= Identifier <Initializer>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_INITIALIZER_EQ :
                //<Initializer> ::= '=' <Assignment Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENTEXPRESSION :
                //<Assignment Expression> ::= <Conditional Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENTEXPRESSION2 :
                //<Assignment Expression> ::= <Literal> <Assignment Operator> <Assignment Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CONDITIONALEXPRESSION :
                //<Conditional Expression> ::= <Logical Or Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CONDITIONALEXPRESSION_QUESTION_COLON :
                //<Conditional Expression> ::= <Logical Or Expression> '?' <Assignment Expression> ':' <Assignment Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LOGICALOREXPRESSION :
                //<Logical Or Expression> ::= <Logical And Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LOGICALOREXPRESSION_PIPEPIPE :
                //<Logical Or Expression> ::= <Logical Or Expression> '||' <Logical And Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LOGICALANDEXPRESSION :
                //<Logical And Expression> ::= <Bitwise Or Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LOGICALANDEXPRESSION_AMPAMP :
                //<Logical And Expression> ::= <Logical And Expression> '&&' <Bitwise Or Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BITWISEOREXPRESSION :
                //<Bitwise Or Expression> ::= <Bitwise XOr Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BITWISEOREXPRESSION_PIPE :
                //<Bitwise Or Expression> ::= <Bitwise Or Expression> '|' <Bitwise XOr Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BITWISEXOREXPRESSION :
                //<Bitwise XOr Expression> ::= <Bitwise And Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BITWISEXOREXPRESSION_CARET :
                //<Bitwise XOr Expression> ::= <Bitwise XOr Expression> '^' <Bitwise And Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BITWISEANDEXPRESSION :
                //<Bitwise And Expression> ::= <Equality Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BITWISEANDEXPRESSION_AMP :
                //<Bitwise And Expression> ::= <Bitwise And Expression> '&' <Equality Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EQUALITYEXPRESSION :
                //<Equality Expression> ::= <Relational Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EQUALITYEXPRESSION2 :
                //<Equality Expression> ::= <Equality Expression> <Equality Operations> <Relational Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EQUALITYOPERATIONS_EQEQ :
                //<Equality Operations> ::= '=='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EQUALITYOPERATIONS_EXCLAMEQ :
                //<Equality Operations> ::= '!='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EQUALITYOPERATIONS_EQEQEQ :
                //<Equality Operations> ::= '==='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EQUALITYOPERATIONS_EXCLAMEQEQ :
                //<Equality Operations> ::= '!=='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_RELATIONALEXPRESSION :
                //<Relational Expression> ::= <Shift Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_RELATIONALEXPRESSION2 :
                //<Relational Expression> ::= <Relational Expression> <Relational Operations> <Shift Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_RELATIONALOPERATIONS_LT :
                //<Relational Operations> ::= '<'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_RELATIONALOPERATIONS_GT :
                //<Relational Operations> ::= '>'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_RELATIONALOPERATIONS_LTEQ :
                //<Relational Operations> ::= '<='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_RELATIONALOPERATIONS_GTEQ :
                //<Relational Operations> ::= '>='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SHIFTEXPRESSION :
                //<Shift Expression> ::= <Shift Expression> <Shift Operations> <Additive Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SHIFTEXPRESSION2 :
                //<Shift Expression> ::= <Additive Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SHIFTOPERATIONS_LTLT :
                //<Shift Operations> ::= '<<'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SHIFTOPERATIONS_GTGT :
                //<Shift Operations> ::= '>>'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SHIFTOPERATIONS_GTGTGT :
                //<Shift Operations> ::= '>>>'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ADDITIVEEXPRESSION :
                //<Additive Expression> ::= <Additive Expression> <Additive Operations> <Multiplicative Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ADDITIVEEXPRESSION2 :
                //<Additive Expression> ::= <Multiplicative Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ADDITIVEOPERATIONS_PLUS :
                //<Additive Operations> ::= '+'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ADDITIVEOPERATIONS_MINUS :
                //<Additive Operations> ::= '-'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MULTIPLICATIVEEXPRESSION :
                //<Multiplicative Expression> ::= <Unary Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MULTIPLICATIVEEXPRESSION2 :
                //<Multiplicative Expression> ::= <Unary Expression> <Multiplicative Operations> <Multiplicative Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MULTIPLICATIVEOPERATIONS_TIMES :
                //<Multiplicative Operations> ::= '*'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MULTIPLICATIVEOPERATIONS_DIV :
                //<Multiplicative Operations> ::= '/'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MULTIPLICATIVEOPERATIONS_PERCENT :
                //<Multiplicative Operations> ::= '%'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_UNARYEXPRESSION :
                //<Unary Expression> ::= <Postfix Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_UNARYEXPRESSION2 :
                //<Unary Expression> ::= <Unary Operations> <Unary Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_UNARYOPERATIONS_TYPEOF :
                //<Unary Operations> ::= typeof
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_UNARYOPERATIONS_PLUS :
                //<Unary Operations> ::= '+'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_UNARYOPERATIONS_MINUS :
                //<Unary Operations> ::= '-'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_UNARYOPERATIONS_TILDE :
                //<Unary Operations> ::= '~'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_UNARYOPERATIONS_EXCLAM :
                //<Unary Operations> ::= '!'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_UNARYOPERATIONS :
                //<Unary Operations> ::= <In De Creament>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_INDECREAMENT_PLUSPLUS :
                //<In De Creament> ::= '++'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_INDECREAMENT_MINUSMINUS :
                //<In De Creament> ::= '--'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_POSTFIXEXPRESSION :
                //<Postfix Expression> ::= <Literal>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_POSTFIXEXPRESSION2 :
                //<Postfix Expression> ::= <Postfix Expression> <In De Creament>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LITERAL :
                //<Literal> ::= <Boolean Literal>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LITERAL2 :
                //<Literal> ::= <Numeric Literal>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LITERAL3 :
                //<Literal> ::= <Array Literal>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LITERAL_STRINGLITERAL :
                //<Literal> ::= StringLiteral
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LITERAL_IDENTIFIER :
                //<Literal> ::= Identifier
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BOOLEANLITERAL_TRUE :
                //<Boolean Literal> ::= true
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BOOLEANLITERAL_FALSE :
                //<Boolean Literal> ::= false
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_NUMERICLITERAL_DECIMALLITERAL :
                //<Numeric Literal> ::= DecimalLiteral
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_NUMERICLITERAL_HEXINTEGERLITERAL :
                //<Numeric Literal> ::= HexIntegerLiteral
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ARRAYLITERAL_LBRACKET_RBRACKET :
                //<Array Literal> ::= '[' ']'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ARRAYLITERAL_LBRACKET_RBRACKET2 :
                //<Array Literal> ::= '[' <Element> ']'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ELEMENT :
                //<Element> ::= <Literal>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ELEMENT_COMMA :
                //<Element> ::= <Literal> ',' <Element>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENTOPERATOR_EQ :
                //<Assignment Operator> ::= '='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENTOPERATOR_TIMESEQ :
                //<Assignment Operator> ::= '*='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENTOPERATOR_DIVEQ :
                //<Assignment Operator> ::= '/='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENTOPERATOR_PERCENTEQ :
                //<Assignment Operator> ::= '%='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENTOPERATOR_PLUSEQ :
                //<Assignment Operator> ::= '+='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENTOPERATOR_MINUSEQ :
                //<Assignment Operator> ::= '-='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENTOPERATOR_LTLTEQ :
                //<Assignment Operator> ::= '<<='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENTOPERATOR_GTGTEQ :
                //<Assignment Operator> ::= '>>='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENTOPERATOR_GTGTGTEQ :
                //<Assignment Operator> ::= '>>>='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENTOPERATOR_AMPEQ :
                //<Assignment Operator> ::= '&='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENTOPERATOR_CARETEQ :
                //<Assignment Operator> ::= '^='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENTOPERATOR_PIPEEQ :
                //<Assignment Operator> ::= '|='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_IFSTATEMENT_IF_LPAREN_RPAREN :
                //<If Statement> ::= if '(' <Expression> ')' <Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_IFELSESTATEMENT_IF_LPAREN_RPAREN_ELSE :
                //<If Else Statement> ::= if '(' <Expression> ')' <Statement> else <Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SWITCHSTATEMENT_SWITCH_LPAREN_RPAREN :
                //<Switch Statement> ::= switch '(' <Expression> ')' <Case Block>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CASEBLOCK_LBRACE_RBRACE :
                //<Case Block> ::= '{' '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CASEBLOCK_LBRACE_RBRACE2 :
                //<Case Block> ::= '{' <Case Clauses> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CASEBLOCK_LBRACE_RBRACE3 :
                //<Case Block> ::= '{' <Case Clauses> <Default Clause> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CASEBLOCK_LBRACE_RBRACE4 :
                //<Case Block> ::= '{' <Case Clauses> <Default Clause> <Case Clauses> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CASEBLOCK_LBRACE_RBRACE5 :
                //<Case Block> ::= '{' <Default Clause> <Case Clauses> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CASEBLOCK_LBRACE_RBRACE6 :
                //<Case Block> ::= '{' <Default Clause> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CASECLAUSES :
                //<Case Clauses> ::= <Case Clause>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CASECLAUSES2 :
                //<Case Clauses> ::= <Case Clauses> <Case Clause>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CASECLAUSE_CASE_COLON :
                //<Case Clause> ::= case <Expression> ':' <Statement List>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CASECLAUSE_CASE_COLON2 :
                //<Case Clause> ::= case <Expression> ':'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_DEFAULTCLAUSE_DEFAULT_COLON :
                //<Default Clause> ::= default ':'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_DEFAULTCLAUSE_DEFAULT_COLON2 :
                //<Default Clause> ::= default ':' <Statement List>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ITERATIONSTATEMENT_DO_WHILE_LPAREN_RPAREN :
                //<Iteration Statement> ::= do <Statement> while '(' <Expression> ')'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ITERATIONSTATEMENT_WHILE_LPAREN_RPAREN :
                //<Iteration Statement> ::= while '(' <Expression> ')' <Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ITERATIONSTATEMENT_FOR_LPAREN_SEMI_SEMI_RPAREN :
                //<Iteration Statement> ::= for '(' <Expression> ';' <Expression> ';' <Expression> ')' <Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ITERATIONSTATEMENT_FOR_LPAREN_SEMI_SEMI_RPAREN2 :
                //<Iteration Statement> ::= for '(' <Variable Declaration Keywords> <Variable Declaration List> ';' <Expression> ';' <Expression> ')' <Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ITERATIONSTATEMENT_FOR_LPAREN_OF_RPAREN :
                //<Iteration Statement> ::= for '(' <Variable Declaration Keywords> <Variable Declaration> of <Expression> ')' <Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CONTINUESTATEMENT_CONTINUE :
                //<Continue Statement> ::= continue
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BREAKSTATEMENT_BREAK :
                //<Break Statement> ::= break
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TRYSTATEMENT_TRY :
                //<Try Statement> ::= try <Block Statement> <Catch>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TRYSTATEMENT_TRY2 :
                //<Try Statement> ::= try <Block Statement> <Finally>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TRYSTATEMENT_TRY3 :
                //<Try Statement> ::= try <Block Statement> <Catch> <Finally>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CATCH_CATCH_LPAREN_IDENTIFIER_RPAREN :
                //<Catch> ::= catch '(' Identifier ')' <Block Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FINALLY_FINALLY :
                //<Finally> ::= finally <Block Statement>
                //todo: Create a new object using the stored tokens.
                return null;

            }
            throw new RuleException("Unknown rule");
        }

        private void TokenErrorEvent(LALRParser parser, TokenErrorEventArgs args)
        {
            string message = "Token error with input: '"+args.Token.ToString()+"'";
            //todo: Report message to UI?
        }

        private void ParseErrorEvent(LALRParser parser, ParseErrorEventArgs args)
        {
            string message = "Parse error caused by token: '" + args.UnexpectedToken.ToString() + "'";
            string ErrorInLine = $"In Line: {args.UnexpectedToken.Location.LineNr + 1}";
            string ExpectedTokens = $"Expected Tokens: {args.ExpectedTokens.ToString()}";
            //todo: Report message to UI?
            rtb.Text = $"{message}\n{ErrorInLine}\n{ExpectedTokens}";
        }

    }
}
