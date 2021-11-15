function redundant(str)
{
  function string()
  {
    return str;
  }
  return string;
}

const f1 = redundant("apple");
console.log(f1()); // "apple"

const f2 = redundant("pear")
console.log(f2()); // "pear"

const f3 = redundant("")
console.log(f3()); // ""