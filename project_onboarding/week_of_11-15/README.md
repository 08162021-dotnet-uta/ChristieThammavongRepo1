# Coding Challenge Description

## JavaScript

### Challenge 1

Write two functions:

- One to retrieve all unique substrings that start and end with a vowel.
- One to retrieve all unique substrings that start and end with a consonant.
The resulting array should be sorted in lexicographic ascending order (same order as a dictionary).

Examples:

getVowelSubstrings("apple")
--> ["a", "apple", "e"]

getVowelSubstrings("hmm") --> []

getConsonantSubstrings("aviation")
--> ["n", "t", "tion", "v", "viat", "viation"]

getConsonantSubstrings("motor")
-->["m", "mot", "motor", "r", "t", "tor"]

Notes:
- Remember the output array should have unique values.
- The word itself counts as a potential substring.
- Exclude the empty string when outputting the array.

### Challenge 2

Write a function redundant that takes in a string 'str' and returns a function that returns 'str'.

Examples:

const f1 = redundant("apple")
<br>
f1() --> "apple"

const f2 = redundant("pear")
<br>
f2() --> "pear"

const f3 = redundant("")
<br>
f3() -->""

Notes:
Your function should return a 'function', not a string.

<br>

## C#/.NET

Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.

Examples:

ReverseCase("Happy Birthday") --> "hAPPY bIRTHDAY"

ReverseCase("MANY THANKS") --> "many thanks"

ReverseCase("sPoNtAnEoUs") --> "SpOnTaNeOuS"