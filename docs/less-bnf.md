LESS language BNF

```bnf
stylesheet ::= styles
styles ::= style | style styles

ruleset ::= selectors '{' declarations '}'
selectors ::= selector | selector ',' selectors
selector ::= element_name | element element_args | element_args
element_args ::= element_arg | element_arg element_args
element_arg ::= '#' identifier | class | attribute | pseudo
declarations ::= declaration | declaration ';' declarations | e
declaration ::= property : ':' expr

expr ::= 

identifier ::= 
class ::= '.' identifier
element_name ::= 
psudo ::= ':' identifier
```
